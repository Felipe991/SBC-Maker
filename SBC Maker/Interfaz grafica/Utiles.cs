using SBC_Maker.Logica;
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

        public bool IsUnique(Regla regla, List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                if (nodo.Regla.Nombre == regla.Nombre)
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool VerifyCicle(Nodo antecedente, Nodo consecuente )
        {
            return consecuente.Nivel > antecedente.Nivel;
        }

        public bool VerifyRedundancy(Nodo antecedente, Nodo consecuente)
        {

            return true;
        }

        public bool VerifyStructure (List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                switch (nodo.Regla)
                {
                    case ReglaConclusion:

                        break;
                    case ReglaInformacion:

                        break;
                    default:

                        break;
                }
            }
            
            return true;
        }
    }
}
