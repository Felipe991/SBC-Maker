﻿namespace SBC_Maker.Logica
{
    public class Pregunta
    {
        private string enunciado;

        public Pregunta(string enunciado)
        {
            this.Enunciado = enunciado;
        }

        public string Enunciado { get => enunciado; set => enunciado = value; }
    }
}