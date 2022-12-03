using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class Utiles
    {
        public static bool IsDouble(string texto)
        {
            if (double.TryParse(texto, out double d) && !double.IsNaN(d) && !double.IsInfinity(d))
            {
                return true;
            }
            return false;
        }
        public static bool IsGreater(double debeSerMayor, double debeSerMenor)
        {
            if (debeSerMayor >= debeSerMenor)
            {
                return true;
            }
            return false;
        }

        public static bool IsUnique(string nombre, List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                if (nodo.Regla.Nombre == nombre)
                {
                    return false;
                }
            }
            return true;
        }
        public static void AsignarNivel(Nodo antecedente, Nodo consecuente)
        {
            int nuevoNivel = antecedente.Nivel + 1;
            if (consecuente.Nivel < nuevoNivel)
            {
                consecuente.Nivel = nuevoNivel;
                foreach (Nodo siguiente in consecuente.Consecuentes)
                {
                    AsignarNivel(consecuente, siguiente);
                }
            }
        }

        public static bool VerifyCycle(Nodo antecedente, Nodo consecuente)
        {
            if (VerifyRoots(antecedente, consecuente)) return consecuente.Nivel >= antecedente.Nivel;
            return true;
        }

        private static bool VerifyRoots(Nodo antecedente, Nodo consecuente)
        {
            List<Nodo> rootsConsecuente = consecuente.GetRoots();
            List<Nodo> rootsAntecedente = antecedente.GetRoots();
            foreach (Nodo rootAntecedente in rootsAntecedente)
            {
                foreach (Nodo rootConsecuente in rootsConsecuente)
                {
                    if (rootAntecedente.Equals(rootConsecuente)) return false;
                }
            }
            return true;
        }

        public static bool VerifyRedundancy(Nodo antecedente, Nodo consecuente)
        {
            if (antecedente.Regla.Equals(consecuente.Regla))
            {
                return false;
            }
            foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                foreach (Relacion anterior in antecedentes)
                {
                    VerifyRedundancy(antecedente, anterior.Nodo);
                }
            }
            return true;
        }
        public static bool VerifyRedundancy(Nodo objetivo, Nodo actual, int numeroRelacion)
        {
            List<Relacion> antecedentes = actual.Antecedentes[numeroRelacion - 1];
            foreach(Relacion antecedente in antecedentes)
            {
                if (!VerifyRedundancy(objetivo, antecedente.Nodo))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VerifyStructure(List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                switch (nodo.Regla)
                {
                    case ReglaInformacion:
                        bool isInicio = ((ReglaInformacion)nodo.Regla).ReglaInicio;
                        if(isInicio && (nodo.Antecedentes.Count() > 0 || nodo.Consecuentes.Count() < 1)) return false;
                        if (!isInicio && (nodo.Antecedentes.Count() < 1 || nodo.Consecuentes.Count() < 1)) return false; 
                        break;
                    case ReglaConclusion:
                        if (nodo.Antecedentes.Count() < 1 || nodo.Consecuentes.Count() > 0) return false;
                        break;
                }
            }
            return true;
        }
        public static bool DeleteNodo(Nodo nodo, List<Nodo> listaAdyacencia)
        {
            foreach (List<Relacion> antecedentes in nodo.Antecedentes)
            {
                foreach(Relacion antecedente in antecedentes)
                {
                    antecedente.Nodo.Consecuentes.Remove(antecedente.Nodo.Consecuentes.Find(consecuente => consecuente == nodo));
                }
            }   
            
            foreach (Nodo consecuente in nodo.Consecuentes)
            {
                foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
                {
                    antecedentes.Remove(antecedentes.Find(antecedente => antecedente.Nodo == nodo));
                }
            }


            return listaAdyacencia.Remove(nodo);
        }
    }
}
