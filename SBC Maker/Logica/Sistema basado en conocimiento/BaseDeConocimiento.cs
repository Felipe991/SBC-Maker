using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class BaseDeConocimiento
    {
        private List<Nodo> listaAdyacencia;

        public BaseDeConocimiento()
        {
            listaAdyacencia = new List<Nodo>();
        }
        
        public void addNodo(Nodo nodo)
        {
            this.listaAdyacencia.Add(nodo);
        }

        public void removeNodo(Nodo nodo)
        {
            this.listaAdyacencia.Remove(nodo);
        }
    }
}
