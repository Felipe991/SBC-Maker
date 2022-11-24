namespace SBC_Maker.Logica
{
    public class Nodo
    {
        private Regla regla;
        private Hecho hecho;
        private int nivel;
        private List<List<Relacion>> relaciones;

        public Nodo(Regla regla, Hecho hecho, int nivel)
        {
            this.Regla = regla;
            this.Hecho = hecho;
            this.Nivel = nivel;
            this.relaciones = new List<List<Relacion>>();
        }

        public Hecho Hecho { get => hecho; set => hecho = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        internal Regla Regla { get => regla; set => regla = value; }
    }
}