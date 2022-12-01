using SBC_Maker.Logica.Configuracion;

namespace SBC_Maker.Logica
{
    public class Nodo
    {
        private Regla regla;
        private Hecho hecho;
        private int nivel;
        private List<List<Relacion>> antecedentes;
        private List<Relacion> consecuentes;
        private Posicion posicion;

        public Nodo(Regla regla, Hecho hecho, int nivel)
        {
            this.Regla = regla;
            this.Hecho = hecho;
            this.Nivel = nivel;
            this.Posicion = new Posicion();
            this.Antecedentes = new List<List<Relacion>>();
            this.Consecuentes = new List<Relacion>();
        }
        public List<Nodo> GetRoots()
        {
            List<Nodo> roots = new List<Nodo>();
            foreach (List<Relacion> antecedentes in this.Antecedentes)
            {
                foreach (Relacion antecedente in antecedentes)
                {
                    if (antecedente.Nodo.Nivel == 0 && !roots.Contains(antecedente.Nodo))
                    {
                        roots.Add(antecedente.Nodo);
                    }
                }
            }
            return roots;
        }

        public Hecho Hecho { get => hecho; set => hecho = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public List<List<Relacion>> Antecedentes { get => antecedentes; set => antecedentes = value; }
        public List<Relacion> Consecuentes { get => consecuentes; set => consecuentes = value; }
        internal Regla Regla { get => regla; set => regla = value; }
        public Posicion Posicion { get => posicion; set => posicion = value; }
    }
}