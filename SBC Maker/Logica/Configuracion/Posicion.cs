namespace SBC_Maker.Logica.Configuracion
{
    public class Posicion
    {
        private int x;
        private int y;
        private Nodo nodo;

        public Posicion(int x, int y, Nodo nodo)
        {
            this.X = x;
            this.Y = y;
            this.nodo = nodo;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Nodo Nodo { get => nodo; set => nodo = value; }
    }
}