using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class ReglaInicio : Regla
    {
        Pregunta pregunta;

        public ReglaInicio(string nombre, Pregunta pregunta) : base(nombre)
        {
            this.pregunta = pregunta;
        }

        public Pregunta Pregunta { get => pregunta; set => pregunta = value; }
    }
}
