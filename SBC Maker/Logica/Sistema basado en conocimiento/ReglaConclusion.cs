using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class ReglaConclusion : Regla
    {
        private string indicacion;
        public ReglaConclusion(string nombre, string indicacion) : base(nombre)
        {
            this.Indicacion = indicacion;
        }

        public string Indicacion { get => indicacion; set => indicacion = value; }
    }
}
