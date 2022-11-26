using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Interfaz_grafica
{
    internal class Utiles
    {
        public Utiles()
        {
            
        }

        public bool IsDouble(string texto)
        {
            if (double.TryParse(texto, out double d) && !Double.IsNaN(d) && !Double.IsInfinity(d))
            {
                return true;
            }
            return false;
        }

        public bool IsGreater(Double debeSerMayor, Double debeSerMenor)
        {
            if (debeSerMayor > debeSerMenor)
            {
                return true;
            }
            return false;
        }
    }
}
