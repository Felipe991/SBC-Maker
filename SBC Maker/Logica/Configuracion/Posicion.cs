namespace SBC_Maker.Logica.Configuracion
{
    public class Posicion
    {
        private int x;
        private int y;
        private string nombreRegla;

        public Posicion(int x, int y, string nombreRegla)
        {
            this.X = x;
            this.Y = y;
            this.NombreRegla = nombreRegla;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string NombreRegla { get => nombreRegla; set => nombreRegla = value; }
    }
}