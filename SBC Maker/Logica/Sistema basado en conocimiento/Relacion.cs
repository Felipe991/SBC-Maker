﻿namespace SBC_Maker.Logica
{
    public class Relacion
    {
        private Nodo nodo;
        private int numeroRelacion;
        private string explicacion;
        public List<string>? respuestasNecesarias = new List<string>();
        
        public Relacion(Nodo nodo, int numeroRelacion, string explicacion = "")
        {
            this.Nodo = nodo;
            this.explicacion = explicacion;
            this.NumeroRelacion = numeroRelacion;
        }

        public Nodo Nodo { get => nodo; set => nodo = value; }
        public int NumeroRelacion { get => numeroRelacion; set => numeroRelacion = value; }
        public List<string> RespuestasNecesarias { get => respuestasNecesarias; set => respuestasNecesarias = value; }
        
    }
}