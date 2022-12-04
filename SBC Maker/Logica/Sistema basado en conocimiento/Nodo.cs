using SBC_Maker.Logica.Configuracion;

namespace SBC_Maker.Logica
{
    public class Nodo
    {
        private Regla regla;
        private Hecho hecho;
        private int nivel;
        private List<List<Relacion>> antecedentes;
        private List<Nodo> consecuentes;
        private Posicion posicion;

        public Nodo(Regla regla, Hecho hecho, int nivel)
        {
            this.Regla = regla;
            this.Hecho = hecho;
            this.Nivel = nivel;
            this.Posicion = new Posicion();
            this.Antecedentes = new List<List<Relacion>>();
            this.Consecuentes = new List<Nodo>();
        }

        public void GetRoots(List<Nodo> roots)
        {
            if (this.Nivel1 == 0)
            {
                roots.Add(this);
            }
            foreach (List<Relacion> antecedentes in this.Antecedentes)
            {
                foreach (Relacion antecedente in antecedentes)
                {
                    if (antecedente.Nodo.Nivel == 0 && !roots.Contains(antecedente.Nodo))
                    {
                        roots.Add(antecedente.Nodo);
                    }
                    else
                    {
                        antecedente.Nodo.GetRoots(roots);
                    }
                }
            }
        }

        public Hecho Hecho { get => hecho; set => hecho = value; }
        public int Nivel { get => Nivel1; set => Nivel1 = value; }
        public List<List<Relacion>> Antecedentes { get => antecedentes; set => antecedentes = value; }
        public List<Nodo> Consecuentes { get => consecuentes; set => consecuentes = value; }
        internal Regla Regla { get => regla; set => regla = value; }
        public Posicion Posicion { get => posicion; set => posicion = value; }
        public int Nivel1 { get => nivel; set => nivel = value; }
    }
}