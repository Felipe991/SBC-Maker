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
        private bool MOSTRAREXPLICACION, MENORLARGOCAMINO, MAYORPROFUNDIDAD, MAYORINFORMACION;
        private List<Nodo> baseConocimiento;
        private List<Nodo> reglasAplicables;
        private List<Nodo> conclusiones = new List<Nodo>();

        public MotorDeInferencia(SBC sbc)
        {
            this.MAXCONCLUSIONES = sbc.ConfiguracionMotor.ConclusionesNecesarias;
            this.MOSTRAREXPLICACION = sbc.ConfiguracionMotor.Explicacion;
            this.MENORLARGOCAMINO = sbc.ConfiguracionMotor.MetodoResolucion[0];
            this.MAYORPROFUNDIDAD = sbc.ConfiguracionMotor.MetodoResolucion[1];
            this.MAYORINFORMACION = sbc.ConfiguracionMotor.MetodoResolucion[2];
            this.baseConocimiento = sbc.BaseConocimiento;
            this.reglasAplicables = GetNodosInicio();
        }

        public Nodo ChainForward(Nodo preguntado)
        {
            foreach(Nodo consecuente in preguntado.Consecuentes)
            {
                if (!consecuente.IsPreguntable()) continue;
                List<List<Relacion>> antecedentesRemanentes = GetRemanentes(consecuente, preguntado);

                if (reglasAplicables.Contains(consecuente) || conclusiones.Contains(consecuente))
                {
                    consecuente.Antecedentes.Clear();
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
            return ResolucionConflicto();
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
                if (!consecuente.Equals(nodo) && consecuente.IsPreguntable())
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
                if (!consecuente.IsPreguntable()) continue;
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
                    if (consecuente.IsPreguntable() && !this.reglasAplicables.Contains(consecuente))
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
            Nodo mejorNodo = null;
            //Tabaja sobre reglas aplicables
            foreach (Nodo reglaAplicable in this.reglasAplicables)
            {
                //NOSE XD supongo que depende de las constantes
                mejorNodo = reglaAplicable;
            }

            return mejorNodo;
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
