using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class PreguntaDifusa : Pregunta
    {
        ConjuntoDifuso conjuntoDifuso;
        public PreguntaDifusa(ConjuntoDifuso conjuntoDifuso,string enunciado) : base(enunciado)
        {
            this.ConjuntoDifuso = ConjuntoDifuso;
        }

        public ConjuntoDifuso ConjuntoDifuso { get => conjuntoDifuso; set => conjuntoDifuso = value; }
    }
}
