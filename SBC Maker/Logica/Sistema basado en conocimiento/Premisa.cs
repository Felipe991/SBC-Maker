using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class Premisa : Relacion
    {
        private List<string> respuestasNecesarias;

        public Premisa(List<string> respuestasNecesarias, Nodo nodo) : base(nodo)
        {
            this.respuestasNecesarias = respuestasNecesarias;
        }
        
    }
}
