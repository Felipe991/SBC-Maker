namespace SBC_Maker.Logica
{
    public class Nodo
    {
        private Regla regla;
        private Hecho hecho;
        private int nivel;
        private List<List<Relacion>> antecedentes;
        private List<Relacion> consecuentes;

        public Nodo(Regla regla, Hecho hecho, int nivel)
        {
            this.Regla = regla;
            this.Hecho = hecho;
            this.Nivel = nivel;
            this.Antecedentes = new List<List<Relacion>>();
            this.Consecuentes = new List<Relacion>();
        }


        public Hecho Hecho { get => hecho; set => hecho = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public List<List<Relacion>> Antecedentes { get => antecedentes; set => antecedentes = value; }
        public List<Relacion> Consecuentes { get => consecuentes; set => consecuentes = value; }
        internal Regla Regla { get => regla; set => regla = value; }
    }
}