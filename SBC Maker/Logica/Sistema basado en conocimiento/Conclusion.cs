using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class Conclusion : Regla
    {
        private string indicacion;
        public Conclusion(string nombre, string? explicacion,string indicacion) : base(nombre, explicacion)
        {
            this.Indicacion = indicacion;
        }

        public string Indicacion { get => indicacion; set => indicacion = value; }
    }
}
