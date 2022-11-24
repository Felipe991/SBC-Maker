namespace SBC_Maker.Logica
{
    public class Relacion
    {
        private Nodo nodo;
        
        public Relacion(Nodo nodo)
        {
            this.Nodo = nodo;
        }

        public Nodo Nodo { get => nodo; set => nodo = value; }
    }
}