using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class Grafo
    {
        private List<Nodo> nodos;

        public Grafo()
        {
            nodos = new List<Nodo>();
        }
        
        public void addNodo(Nodo nodo)
        {
            this.nodos.Add(nodo);
        }

        public void removeNodo(Nodo nodo)
        {
            this.nodos.Remove(nodo);
        }
    }
}
