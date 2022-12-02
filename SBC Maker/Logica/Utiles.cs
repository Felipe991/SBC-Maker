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
                    if (rootAntecedente == rootConsecuente) return false;
                }
            }
            return true;
        }

        public static bool VerifyRedundancy(Nodo antecedente, Nodo consecuente)
        {
            if (antecedente.Regla.Nombre == consecuente.Regla.Nombre)
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

        public static bool VerifyStructure(List<Nodo> listaAdyacencia)
        {
            foreach (Nodo nodo in listaAdyacencia)
            {
                switch (nodo.Regla)
                {
                    case ReglaInicio:
                        if (nodo.Antecedentes.Count() > 0 || nodo.Consecuentes.Count() < 1) return false;
                        break;
                    case ReglaInformacion:
                        if (nodo.Antecedentes.Count() < 1 || nodo.Consecuentes.Count() < 1) return false;
                        break;
                    case ReglaConclusion:
                        if (nodo.Antecedentes.Count() < 1 || nodo.Consecuentes.Count() > 0) return false;
                        break;
                }
            }
            return true;
        }
        public static bool DeleteNodo(Regla regla, List<Nodo> listaAdyacencia)
        {
            Nodo nodo = listaAdyacencia.Find(nodo => nodo.Regla == regla);
            
            foreach (List<Relacion> antecedentes in nodo.Antecedentes)
            {
                foreach(Relacion antecedente in antecedentes)
                {
                    antecedente.Nodo.Consecuentes.Remove(antecedente.Nodo.Consecuentes.Find(relacion => relacion.Nodo == nodo));
                }
            }   
            
            foreach (Relacion consecuente in nodo.Consecuentes)
            {
                foreach (List<Relacion> antecedentes in consecuente.Nodo.Antecedentes)
                {
                    antecedentes.Remove(antecedentes.Find(antecedente => antecedente.Nodo == nodo));
                }
            }


            return listaAdyacencia.Remove(nodo);
        }
    }
}
