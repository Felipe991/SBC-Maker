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

        public List<Nodo> ChainForward()
        {
            List<Nodo> conclusiones = new List<Nodo>();
            while(this.reglasAplicables.Count()>0 && conclusiones.Count()<this.MAXCONCLUSIONES)
            {

                
            }
            return conclusiones;
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

        private bool isAplicable(Nodo nodo)
        {


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
