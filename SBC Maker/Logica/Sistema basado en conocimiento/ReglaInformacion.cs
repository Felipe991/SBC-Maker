﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class ReglaInformacion : Regla
    {
        Pregunta pregunta;
        public ReglaInformacion(string nombre, string? explicacion, Pregunta pregunta) : base(nombre, explicacion)
        {
            this.Pregunta = pregunta;
        }

        public Pregunta Pregunta { get => pregunta; set => pregunta = value; }
    }
}