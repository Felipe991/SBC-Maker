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
                List<List<Relacion>> antecedentesRemanentes = new List<List<Relacion>>();
                foreach(List<Relacion> antecedentes in consecuente.Antecedentes)
                {
                    Relacion relacion = antecedentes.Find(x => x.Nodo.Equals(preguntado));
                    if(relacion != null)
                    {
                        if (SatisfyRespuesta(preguntado, relacion))
                        {
                            if (CheckRelacion(antecedentes))
                            {
                                this.reglasAplicables.Add(consecuente);
                                break;
                            }
                            antecedentesRemanentes.Add(antecedentes);
                        }
                    }
                }
                consecuente.Antecedentes = antecedentesRemanentes;
                //Llamo a un método recursivo que verifique si no le quedan antecedentes
                    //a su vez este se llama a sí mismo con cada consecuente
                if (antecedentesRemanentes.Count() == 0)
                {
                        
                }
            }
            this.reglasAplicables.Remove(preguntado);
            CleanAplicables();
            if (this.reglasAplicables.Count() < 0 || conclusiones.Count() == this.MAXCONCLUSIONES) return null;
            return ResolucionConflicto();
        }
        private bool SatisfyRespuesta(Nodo preguntado, Relacion relacion)
        {
            string respuesta = relacion.respuestasNecesarias.Find(x => x.Equals(preguntado.Hecho.RespuestaFinal));
            return respuesta != null;
        }
        private void CleanAplicables()
        {
            List<Nodo> aplicablesRemantentes = new List<Nodo>();
            foreach (Nodo aplicable in this.reglasAplicables)
            {
                foreach(Nodo consecuente in aplicable.Consecuentes)
                {
                    if (consecuente.Antecedentes.Count() > 0 && !this.reglasAplicables.Contains(consecuente))
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

        private bool CheckRelacion(List<Relacion> antecedentes)
        {
            foreach (Relacion relacion in antecedentes)
            {
                if (relacion.Nodo.Hecho.RespuestaFinal == "") return false;
            }
            return true;
        }


        //Busco reglas aplicables, Una regla es aplicable si
        // (isPreguntable (es decir si no se ha recorrido o si responderla me lleva a una conclusion valida)
        //  Algunas de sus relaciones antecedentes se cumple en su totalidad, Si es regla inicio este no aplica)
        //Si no existen reglas aplicables -> exit
        //Reviso si tengo conclusiones y las agrego
        //Si se ha llegado al limite de conclusiones MAXCONCLUSIONES -> exit
        //Soluciono conflictos entre reglas aplicables
        //Pregunto por la regla aplicable
        //Agrego el hecho a la respectiva regla
        //Propagar isPreguntable
        //Propagar hacia abajo (tomar en cuenta antecedentes de consecuentes al momento de propagar)
        //Una vez propagado hacia abajo hay que tener en cuenta aquellas reglas
        //que ya no tiene sentido preguntar, es decir, mirar hacia arriba y ver a quienes
        //le afecta los cambios
        //Repetir proceso

        //-> exit es mostrar conclusiones y explicacion en caso de ser necesario (MOSTRAREXPLICACION)
        //Para mostrar conclusiones simplemente se accede a la lista de conclusiones y se muestrran todas
        //Para mostrar la explicacion se debe empezar del nodo conclusion hacia arriba pasando por todos
        //los nodos construyendo la explicacion salto por salto 

    }
}
