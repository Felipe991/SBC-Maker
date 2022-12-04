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
        public static void AsignarNivelGlobal(List<Nodo> listaAdyacencia)
        {
            List<Nodo> pseudoRoot = GetNivelesCero(listaAdyacencia);
            SetNivelCero(listaAdyacencia);
            foreach (Nodo nodo in pseudoRoot)
            {
                foreach (Nodo siguiente in nodo.Consecuentes)
                {
                    AsignarNivel(nodo, siguiente);
                }
            }
        }
        private static List<Nodo> GetNivelesCero(List<Nodo> listaAdyacencia)
        {
            List<Nodo> nivelesCero = new List<Nodo>();
            foreach(Nodo nodo in listaAdyacencia)
            {
                if (nodo.Nivel == 0) nivelesCero.Add(nodo);
            }
            return nivelesCero;
        }
        private static void SetNivelCero(List<Nodo> listaAdyacencia)
        {
            foreach(Nodo nodo in listaAdyacencia)
            {
                nodo.Nivel = 0;
            }
        }

        public static bool VerifyCycle(Nodo antecedente, Nodo consecuente)
        {
            if (VerifySameRoots(antecedente, consecuente)) return consecuente.Nivel >= antecedente.Nivel;
            return true;
        }

        private static bool VerifySameRoots(Nodo antecedente, Nodo consecuente)
        {
            List<Nodo> rootsConsecuente = new List<Nodo>();
            consecuente.GetRoots(rootsConsecuente);
            List<Nodo> rootsAntecedente = new List<Nodo>();
            antecedente.GetRoots(rootsAntecedente);
            foreach (Nodo rootAntecedente in rootsAntecedente)
            {
                foreach (Nodo rootConsecuente in rootsConsecuente)
                {
                    if (rootAntecedente.Equals(rootConsecuente)) return true;
                }
            }
            return false;
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
                    if(!VerifyRedundancy(antecedente, anterior.Nodo)) return false;
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
            DeleteFromAntecedentes(nodo);
            DeleteFromConsecuentes(nodo);
            return listaAdyacencia.Remove(nodo);
        }
        private static void DeleteFromAntecedentes(Nodo nodo)
        {
            foreach (List<Relacion> antecedentes in nodo.Antecedentes)
            {
                foreach (Relacion antecedente in antecedentes)
                {
                    antecedente.Nodo.Consecuentes.Remove(antecedente.Nodo.Consecuentes.Find(consecuente => consecuente == nodo));
                }
            }
        }
        private static void DeleteFromConsecuentes(Nodo nodo)
        {
            foreach (Nodo consecuente in nodo.Consecuentes)
            {
                List<List<Relacion>> relacionesRemanentes = new List<List<Relacion>>();
                foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
                {
                    Relacion antecedente = antecedentes.Find(antecedente => antecedente.Nodo == nodo);
                    if (antecedente == null)
                    {
                        relacionesRemanentes.Add(antecedentes);
                    }
                }
                DeleteConsecuenteFromAntecedente(consecuente.Antecedentes, relacionesRemanentes, consecuente);
                consecuente.Antecedentes = relacionesRemanentes;
                ResetNumeroRelacion(consecuente.Antecedentes);
            }
        }

        private static void DeleteConsecuenteFromAntecedente(List<List<Relacion>> relacionesOriginales, List<List<Relacion>> relacionesRemanentes, Nodo consecuente)
        {
            foreach (List<Relacion> antecedentes in relacionesOriginales)
            {
                bool isRemanente = false;
                foreach (Relacion antecedente in antecedentes)
                {
                    foreach(List<Relacion> antecedentesRemanentes in relacionesRemanentes)
                    {
                        Relacion equivalente = antecedentesRemanentes.Find(antecedenteRemanente => antecedenteRemanente.Nodo == antecedente.Nodo);
                        if (equivalente != null)
                        {
                            isRemanente = true;
                            break;
                        }
                    }
                    if (!isRemanente) antecedente.Nodo.Consecuentes.Remove(consecuente);
                }
            }
        }
        private static void ResetNumeroRelacion(List<List<Relacion>> listaAntecedentes)
        {
            int i = 1;
            foreach (List<Relacion> antecedentes in listaAntecedentes)
            {
                foreach (Relacion relacionAntecedente in antecedentes)
                {
                    relacionAntecedente.NumeroRelacion = i;
                }
                i++;
            }
        }
        public static void DeleteRelacion(Nodo antecedente/*B*/, Nodo consecuente/*d*/, Relacion relacionAntecedente/*b-3->c*/)
        {
            List<List<Relacion>> relacionesRemanentes = new List<List<Relacion>>();
            foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                if (!antecedentes.Contains(relacionAntecedente))
                {
                    relacionesRemanentes.Add(antecedentes);
                }
            }
            DeleteConsecuenteFromAntecedente(consecuente.Antecedentes, relacionesRemanentes, consecuente);
            consecuente.Antecedentes = relacionesRemanentes;
            ResetNumeroRelacion(consecuente.Antecedentes);
            //Para cada antecedente del consecuente en la lista que se encuentre la relacion que voy a borrar:
        }

    }
}
