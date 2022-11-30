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
        
        public bool VerifyCycle(Nodo antecedente, Nodo consecuente )
        {
            return consecuente.Nivel > antecedente.Nivel;
        }

        public bool VerifyRedundancy(Nodo antecedente, Nodo consecuente)
        {
            if (antecedente.Regla.Nombre == consecuente.Regla.Nombre)
            {
                return false;
            }
            foreach(List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                foreach(Relacion anterior in antecedentes)
                {
                    VerifyRedundancy(antecedente, anterior.Nodo);
                }
            } 
            return true;
        }

        public bool VerifyStructure (List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                switch (nodo.Regla)
                {
                    case ReglaConclusion:
                        if (nodo.Antecedentes.Count() < 1 || nodo.Consecuentes.Count() > 0) return false;
                        break;
                    case ReglaInformacion:
                        if (nodo.Consecuentes.Count() < 1) return false;
                        break;
                }
            }
            return true;
        }
    }
}
