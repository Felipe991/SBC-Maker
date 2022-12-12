using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    [Serializable]
    public class ReglaInformacion : Regla
    {
        Pregunta pregunta;
        bool  reglaInicio = false;
        public ReglaInformacion(string nombre, Pregunta pregunta) : base(nombre)
        {
            this.Pregunta = pregunta;
        }

        public Pregunta Pregunta { get => pregunta; set => pregunta = value; }
        public bool ReglaInicio { get => reglaInicio; set => reglaInicio = value; }
    }
}
