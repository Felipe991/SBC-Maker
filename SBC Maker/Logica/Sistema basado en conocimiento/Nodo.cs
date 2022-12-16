using SBC_Maker.Logica.Configuracion;

namespace SBC_Maker.Logica
{
    [Serializable]
    public class Nodo
    {
        private Regla regla;
        private Hecho hecho;
        private int nivel;
        private List<List<Relacion>> antecedentes;
        private List<Nodo> consecuentes;
        private Posicion posicion;
        private bool premisasCumplidas;
        private bool isAlcanzable;
        private int indiceRelacionCumplida = -1;

        public Nodo(Regla regla, Hecho hecho, int nivel)
        {
            this.Regla = regla;
            this.Hecho = hecho;
            this.Nivel = nivel;
            this.Posicion = new Posicion();
            this.Antecedentes = new List<List<Relacion>>();
            this.Consecuentes = new List<Nodo>();
            this.PremisasCumplidas = false;
            this.isAlcanzable = true;
        }

        public void GetRoots(List<Nodo> roots)
        {
            if (this.Nivel == 0)
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
        /*public bool IsAlcanzable()
        {
            return this.Antecedentes.Count > 0;
        }*/
        public Hecho Hecho { get => hecho; set => hecho = value; }
        public List<List<Relacion>> Antecedentes { get => antecedentes; set => antecedentes = value; }
        public List<Nodo> Consecuentes { get => consecuentes; set => consecuentes = value; }
        internal Regla Regla { get => regla; set => regla = value; }
        public Posicion Posicion { get => posicion; set => posicion = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public bool PremisasCumplidas { get => premisasCumplidas; set => premisasCumplidas = value; }
        public int IndiceRelacionCumplida { get => indiceRelacionCumplida; set => indiceRelacionCumplida = value; }
        public bool IsAlcanzable { get => isAlcanzable; set => isAlcanzable = value; }
    }
}