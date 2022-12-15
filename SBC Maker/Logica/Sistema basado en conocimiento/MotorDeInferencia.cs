using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Sistema_basado_en_conocimiento
{
    public class MotorDeInferencia
    {
        private int MAXCONCLUSIONES;
        private bool MOSTRAREXPLICACION, MENORLARGOCAMINO, MAYORINFORMACION, MAYORPROFUNDIDAD; 
        private List<Nodo> baseConocimiento;
        private List<Nodo> reglasAplicables;
        private List<Nodo> conclusiones = new List<Nodo>();

        public MotorDeInferencia(SBC sbc)
        {
            this.MAXCONCLUSIONES = sbc.ConfiguracionMotor.ConclusionesNecesarias;
            this.MOSTRAREXPLICACION = sbc.ConfiguracionMotor.Explicacion;
            this.MENORLARGOCAMINO = sbc.ConfiguracionMotor.MetodoResolucion[0];
            this.MAYORINFORMACION = sbc.ConfiguracionMotor.MetodoResolucion[1];
            this.MAYORPROFUNDIDAD = sbc.ConfiguracionMotor.MetodoResolucion[2];
            this.baseConocimiento = sbc.BaseConocimiento;
            this.reglasAplicables = GetNodosInicio();
        }

        public Nodo ChainForward(Nodo preguntado)
        {
            foreach(Nodo consecuente in preguntado.Consecuentes)
            {
                if (!consecuente.IsAlcanzable() || consecuente.PremisasCumplidas) continue;
                List<List<Relacion>> antecedentesRemanentes = GetRemanentes(consecuente, preguntado);

                if (reglasAplicables.Contains(consecuente) || conclusiones.Contains(consecuente))
                {
                    consecuente.PremisasCumplidas = true;
                }
                else
                {
                    if (antecedentesRemanentes.Count() == 0) DeleteInalcanzable(preguntado, consecuente);
                    else consecuente.Antecedentes = antecedentesRemanentes;
                }
            }
            this.reglasAplicables.Remove(preguntado);
            CleanAplicables();
            if (this.reglasAplicables.Count() == 0 || conclusiones.Count() == this.MAXCONCLUSIONES) return null;
            return this.reglasAplicables.Count() > 1 ? ResolucionConflicto() : this.reglasAplicables[0];
        }
        
        private List<List<Relacion>> GetRemanentes(Nodo consecuente, Nodo preguntado)
        {
            List<List<Relacion>> antecedentesRemanentes = new List<List<Relacion>>();
            foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                Relacion relacion = antecedentes.Find(x => x.Nodo.Equals(preguntado));
                if (relacion != null)
                {
                    if (SatisfyRespuesta(preguntado, relacion))
                    {
                        if (CheckRelacion(antecedentes))
                        {
                            if (consecuente.Regla is ReglaConclusion) this.conclusiones.Add(consecuente);
                            else this.reglasAplicables.Add(consecuente);
                            consecuente.IndiceRelacionCumplida = consecuente.Antecedentes.IndexOf(antecedentes);
                            break;
                        }
                        antecedentesRemanentes.Add(antecedentes);
                    }
                }
            }
            return antecedentesRemanentes;
        }

        private bool SatisfyRespuesta(Nodo preguntado, Relacion relacion)
        {
            string respuesta = relacion.respuestasNecesarias.Find(x => x.Equals(preguntado.Hecho.RespuestaFinal));
            return respuesta != null;
        }
        private bool CheckRelacion(List<Relacion> antecedentes)
        {
            foreach (Relacion relacion in antecedentes)
            {
                if (relacion.Nodo.Hecho.RespuestaFinal == null) return false;
            }
            return true;
        }
        private void DeleteInalcanzable(Nodo antecedente,Nodo nodo)
        {
            List<Nodo> recorridos = new List<Nodo>();
            recorridos.Add(antecedente);
            
            DeleteInAntecedentes(nodo,recorridos);
            nodo.Antecedentes.Clear();

            DeleteInConsecuentes(nodo);
        }
        
        private void DeleteInAntecedentes(Nodo nodo, List<Nodo> recorridos)
        {
            foreach (List<Relacion> antecedentes in nodo.Antecedentes)
            {
                foreach (Relacion antecedente in antecedentes)
                {
                    if (recorridos.Contains(antecedente.Nodo)) continue;
                    recorridos.Add(antecedente.Nodo);
                    
                    if (AportaInfo(nodo,antecedente)) continue;
                    DeleteAntecedente(antecedente, recorridos);
                }
            }
        }
        private bool AportaInfo(Nodo nodo, Relacion antecedente)
        {
            bool aportaInfo = false;
            foreach (Nodo consecuente in antecedente.Nodo.Consecuentes)
            {
                if (!consecuente.Equals(nodo) && consecuente.IsAlcanzable())
                {
                    aportaInfo = true;
                    break;
                }
            }
            return aportaInfo;
        }
        private void DeleteAntecedente(Relacion antecedente, List<Nodo> recorridos)
        {
            DeleteInAntecedentes(antecedente.Nodo, recorridos);
            antecedente.Nodo.Antecedentes.Clear();

        }
        private void DeleteInConsecuentes(Nodo nodo)
        {
            foreach (Nodo consecuente in nodo.Consecuentes)
            {
                if (!consecuente.IsAlcanzable()) continue;
                List<List<Relacion>> antecedentesRemanentes = new List<List<Relacion>>();
                foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
                {
                    Relacion relacion = antecedentes.Find(x => x.Nodo.Equals(nodo));
                    if (relacion == null)
                    {
                        antecedentesRemanentes.Add(antecedentes);
                    }
                }
                if (antecedentesRemanentes.Count() == 0) DeleteInalcanzable(nodo,consecuente);
                else consecuente.Antecedentes = antecedentesRemanentes;
            }
        }
        private void CleanAplicables()
        {
            List<Nodo> aplicablesRemantentes = new List<Nodo>();
            foreach (Nodo aplicable in this.reglasAplicables)
            {
                foreach(Nodo consecuente in aplicable.Consecuentes)
                {
                    if (consecuente.IsAlcanzable() && !consecuente.PremisasCumplidas)
                    {
                        aplicablesRemantentes.Add(aplicable);
                        break;
                    }
                    
                }
            }
            this.reglasAplicables = aplicablesRemantentes;
        }
    
        private Nodo ResolucionConflicto()
        {
            List<Nodo> reglasAplicablesAux = new List<Nodo>();
            reglasAplicablesAux.AddRange(this.reglasAplicables);
            
            if (MENORLARGOCAMINO) 
                reglasAplicablesAux = resolucionMenorLargoCamino(reglasAplicablesAux);
            if (MAYORINFORMACION && reglasAplicablesAux.Count() > 1) 
                reglasAplicablesAux = resolucionMayorInformacion(reglasAplicablesAux);
            if (MAYORPROFUNDIDAD && reglasAplicablesAux.Count() > 1) 
                reglasAplicablesAux = resolucionMayorProfundidad(reglasAplicablesAux);
            
            return reglasAplicablesAux[0];
        }

        //Dear Pelao:
        //Para cada regla aplicable se selecciona la lista de relaciones que lo satisface
        //Si es de inicio lo anterior no aplica y solamente se instancia una lista vacia
        //A la par de esto se crea una lista de nodos que se recorren para evitar redundancias
        //Una vez teniendo estos dos parametros listos se empieza a contar
        //Por cada una de las relaciones antecedente de la lista se cuenta a partir del nodo
        //Utilizo tu metodo para recorrer la estructura y rellenar la lista de nodos recorridos
        //Una vez se termina el rellenado recursivo se utiliza .Count() de la lista para saber la cantidad de nodos de info
        //Si es igual se agrega a la lista auxiliar
        //Si es mayor se vacia la lista auxiliar y se agrega el nodo
        //Una vez terminado el ciclo se retorna la lista auxiliar
        private List<Nodo> resolucionMayorInformacion(List<Nodo> reglasAplicablesAux)
        {
            List<Nodo> aux = new();
            int cantidadInformacion = 0;
            foreach(Nodo nodoAux in reglasAplicablesAux)
            {
                var relacionesAntecedentes = nodoAux.Nivel == 0 ? new List<Relacion>():nodoAux.Antecedentes[nodoAux.IndiceRelacionCumplida];
                List<Nodo> nodosRecorridos = new();
                foreach(Relacion relacionAntecedente in relacionesAntecedentes)
                {
                    contarCantidadInformacion(relacionAntecedente.Nodo,nodosRecorridos);
                }
                if (cantidadInformacion == nodosRecorridos.Count()) aux.Add(nodoAux);
                else if (cantidadInformacion < nodosRecorridos.Count())
                {
                    cantidadInformacion = nodosRecorridos.Count();
                    aux = new List<Nodo>(){nodoAux};
                }
            }
            return aux;
        }

        //Se recorren los nodos hacia arriba recursivamente, almacenando los recorridos en nodosRecorridos
        //Al igual que el metodo de resolucionMayorInformacion se selecciona la lista de relaciones que satisfacen al nodo
        //Siempre se tendrá una lista de relaciones que lo satisfacen porque se esta recorriendo hacia arriba
        //Se detiene su recursión al encontrarse parado en una raiz
        private void contarCantidadInformacion(Nodo nodo,List<Nodo> nodosRecorridos)
        {
            nodosRecorridos.Add(nodo);
            if (nodo.Nivel == 0) return;
            List<Relacion> relacionesAntecedentes = nodo.Antecedentes[nodo.IndiceRelacionCumplida];
            foreach (Relacion relacionAntecedente in relacionesAntecedentes)
            {
                if(!nodosRecorridos.Contains(relacionAntecedente.Nodo))
                    contarCantidadInformacion(relacionAntecedente.Nodo, nodosRecorridos);
            }
        }


        /*  DE TODO ESTO A DOS MISERABLES LINEAS XD
         *  Hay que aprender LINQ, está pana
         *  List<Nodo> aux = new List<Nodo>();
            int mayorNivel = 0;
            foreach(Nodo aplicable in reglasAplicablesAux)
            {
                if (aplicable.Nivel == mayorNivel) aux.Add(aplicable);
                else if(aplicable.Nivel > mayorNivel)
                {
                    aux.Clear();
                    aux.Add(aplicable);
                    mayorNivel = aplicable.Nivel;
                }
            }
            return aux;
         */
        private List<Nodo> resolucionMayorProfundidad(List<Nodo> reglasAplicablesAux)
        {
            var nodosPorNivel = reglasAplicablesAux.GroupBy(nodo => nodo.Nivel);
            return nodosPorNivel.OrderByDescending(nodos => nodos.Key).First().ToList();
        }

        private List<Nodo> resolucionMenorLargoCamino(List<Nodo> reglasAplicablesAux)
        {
            List<Nodo> aux = new List<Nodo>();
            return aux;
        }

        private List<Nodo> GetNodosInicio()
        {
            List<Nodo> nodosInicio = new List<Nodo>();
            foreach (Nodo nodo in this.baseConocimiento)
            {
                Regla regla = nodo.Regla;
                switch (regla)
                {
                    case (ReglaInformacion):
                        if (((ReglaInformacion)regla).ReglaInicio) nodosInicio.Add(nodo);
                        break;
                }
            }
            return nodosInicio;
        }
    }
}
