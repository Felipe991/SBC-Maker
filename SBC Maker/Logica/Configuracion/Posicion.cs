namespace SBC_Maker.Logica.Configuracion
{
    [Serializable]
    public class Posicion
    {
        private int x;
        private int y;

        public Posicion(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}