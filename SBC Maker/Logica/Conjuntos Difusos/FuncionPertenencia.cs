﻿namespace SBC_Maker.Logica
{
    public class FuncionPertenencia
    {
        private string nombre;

        public FuncionPertenencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public virtual Double CalcularPertenencia(Double x)
        {
            return 0;
        }
    }
}