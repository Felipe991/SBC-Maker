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
       
        public static bool VerifyNewRelacion(Nodo antecedente, Nodo consecuente, Relacion relacion)
        {
            if (!VerifyAntecedentes(antecedente, consecuente, relacion)) return false;
            if (!VerifyConsecuentes(consecuente, relacion, new List<Nodo>())) return false;
            return true;
        }
        
        private static bool VerifyAntecedentes (Nodo antecedente, Nodo consecuente, Relacion relacion)
        {
            if (!VerifyAntecedenteIndirecto(antecedente, consecuente, relacion)) return false;
            if (!VerifyAntecedentesAntecedente(antecedente, consecuente)) return false;
            return true;
        }
        private static bool VerifyAntecedenteIndirecto(Nodo antecedente, Nodo consecuente, Relacion relacion)
        {
            if (antecedente.Regla.Equals(consecuente.Regla))
            {
                return false;
            }
            foreach (List<Relacion> antecedentesConsecuente in consecuente.Antecedentes)
            {
                foreach (Relacion relacionAntecedente in antecedentesConsecuente)
                {
                    if (!VerifyAntecedenteIndirecto(antecedente, relacionAntecedente.Nodo, relacion))
                    {
                        if (relacionAntecedente.respuestasNecesarias.SequenceEqual(relacion.respuestasNecesarias)) return false;
                    }
                }
            }
            return true;
        }
        private static bool VerifyAntecedentesAntecedente(Nodo antecedente, Nodo consecuente)
        {
            foreach (List<Relacion> antecedentesAntecedente in antecedente.Antecedentes)
            {
                foreach (Relacion relacionAntecedente in antecedentesAntecedente)
                {
                    foreach (List<Relacion> antecedentesConsecuente in consecuente.Antecedentes)
                    {
                        foreach (Relacion relacionAnterior in antecedentesConsecuente)
                        {
                            if (!VerifyAntecedentes(relacionAntecedente.Nodo, relacionAnterior.Nodo, relacionAntecedente))
                            {
                                if (relacionAnterior.respuestasNecesarias.SequenceEqual(relacionAntecedente.respuestasNecesarias)) return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        private static bool VerifyConsecuentes(Nodo consecuente, Relacion relacion, List<Nodo> recorridos)
        {
            if (relacion.Nodo.Regla.Equals(consecuente.Regla))
            {
                return false;
            }
            recorridos.Add(consecuente);
            foreach (Nodo siguiente in consecuente.Consecuentes)
            {
                if (!recorridos.Contains(siguiente))
                {
                    if (!VerifyConsecuentes(siguiente, relacion, recorridos)) return false;
                }
            }
            foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                foreach (Relacion anterior in antecedentes)
                {
                    if (!recorridos.Contains(anterior.Nodo))
                    {
                        if (!VerifyConsecuentes(anterior.Nodo, relacion, recorridos))
                        {
                            if (anterior.respuestasNecesarias.SequenceEqual(relacion.respuestasNecesarias)) return false;
                        }
                    }
                }
            }
            return true;
        }
        public static bool VerifyInalcanzableNew(Nodo consecuente, Relacion relacion)
        {
            if (!VerifyConsecuentesInalcanzable(consecuente, relacion, new List<Nodo>())) return false;
            return true;
        }

        public static bool VerifyExistentRelacion(Nodo antecedente, Nodo consecuente, Relacion relacionAntecedente)
        {
            List<Relacion> relaciones = new List<Relacion>();
            relaciones.AddRange(consecuente.Antecedentes[relacionAntecedente.NumeroRelacion - 1]);

            foreach (Relacion relacion in relaciones)
            {
                if (!VerifyAntecedenteIndirecto(antecedente, consecuente, relacion)) return false;

            }
            
            relaciones.Add(relacionAntecedente);
            if (!VerifySameRelacion(relaciones, consecuente.Antecedentes)) return false;

            return true;
        }
        private static bool VerifySameRelacion(List<Relacion> relaciones, List<List<Relacion>> listaAntecedentes)
        {
            foreach(List<Relacion> antecedentes in listaAntecedentes)
            {
                bool flag = true;
                foreach(Relacion antecedente in antecedentes)
                {
                    Relacion relacion = relaciones.Find(x => x.Nodo.Equals(antecedente.Nodo));
                    if(relacion != null)
                    {
                        if (relacion.NumeroRelacion == antecedente.NumeroRelacion ||
                            !relacion.respuestasNecesarias.SequenceEqual(antecedente.respuestasNecesarias))
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) return false;
            }
            return true;
        }

        public static bool VerifyInalcanzable(Nodo antecedente, Nodo consecuente, Relacion relacionAntecedente)
        {

            List<Relacion> relaciones = new List<Relacion>();
            relaciones.AddRange(consecuente.Antecedentes[relacionAntecedente.NumeroRelacion - 1]);

            List<Nodo> recorridos = new List<Nodo>();
            recorridos.Add(consecuente);

            foreach (Relacion relacion in relaciones)
            {
                if (!VerifyAntecedenteIndirectoInalcanzable(antecedente, consecuente, relacion)) return false;
                if (!VerifyConsecuentesInalcanzable(consecuente, relacion, recorridos)) return false;

            }
            return true;
        }
        private static bool VerifyAntecedenteIndirectoInalcanzable(Nodo antecedente, Nodo consecuente, Relacion relacion)
        {
            if (antecedente.Regla.Equals(consecuente.Regla))
            {
                return false;
            }
            foreach (List<Relacion> antecedentesConsecuente in consecuente.Antecedentes)
            {
                foreach (Relacion relacionAntecedente in antecedentesConsecuente)
                {
                    if (!VerifyAntecedenteIndirecto(antecedente, relacionAntecedente.Nodo, relacion))
                    {
                        if (!relacionAntecedente.respuestasNecesarias.SequenceEqual(relacion.respuestasNecesarias)) return false;
                    }
                }
            }
            return true;
        }
        private static bool VerifyConsecuentesInalcanzable(Nodo consecuente, Relacion relacion, List<Nodo> recorridos)
        {
            if (relacion.Nodo.Regla.Equals(consecuente.Regla))
            {
                return false;
            }
            recorridos.Add(consecuente);
            foreach (Nodo siguiente in consecuente.Consecuentes)
            {
                if (!recorridos.Contains(siguiente))
                {
                    if (!VerifyConsecuentes(siguiente, relacion, recorridos)) return false;
                }
            }
            foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
            {
                foreach (Relacion anterior in antecedentes)
                {
                    if (!recorridos.Contains(anterior.Nodo))
                    {
                        if (!VerifyConsecuentes(anterior.Nodo, relacion, recorridos))
                        {
                            if (!anterior.respuestasNecesarias.SequenceEqual(relacion.respuestasNecesarias)) return false;
                        }
                    }
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
                DeleteConsecuenteFromAntecedente(consecuente.Antecedentes, relacionesRemanentes, nodo,consecuente);
                consecuente.Antecedentes = relacionesRemanentes;
                ResetNumeroRelacion(consecuente.Antecedentes);
            }
        }
        private static void DeleteConsecuenteFromAntecedente(List<List<Relacion>> relacionesOriginales, List<List<Relacion>> relacionesRemanentes, Nodo antecedente ,Nodo consecuente)
        {
            foreach (List<Relacion> antecedentes in relacionesOriginales)
            {
                bool isRemanente = false;
                foreach (Relacion relacionAntecedente in antecedentes)
                {
                    foreach(List<Relacion> antecedentesRemanentes in relacionesRemanentes)
                    {
                        Relacion equivalente = antecedentesRemanentes.Find(antecedenteRemanente => antecedenteRemanente.Nodo == relacionAntecedente.Nodo);
                        if (equivalente != null )
                        {
                            isRemanente = true;
                            break;
                        }
                    }
                    if (!isRemanente && !relacionAntecedente.Nodo.Equals(antecedente)) relacionAntecedente.Nodo.Consecuentes.Remove(consecuente);
                }
            }
        }
        private static void DeleteConsecuenteFromAntecedente(List<List<Relacion>> relacionesOriginales, List<List<Relacion>> relacionesRemanentes, Nodo consecuente)
        {
            foreach (List<Relacion> antecedentes in relacionesOriginales)
            {
                bool isRemanente = false;
                foreach (Relacion relacionAntecedente in antecedentes)
                {
                    foreach (List<Relacion> antecedentesRemanentes in relacionesRemanentes)
                    {
                        Relacion equivalente = antecedentesRemanentes.Find(antecedenteRemanente => antecedenteRemanente.Nodo == relacionAntecedente.Nodo);
                        if (equivalente != null)
                        {
                            isRemanente = true;
                            break;
                        }
                    }
                    if (!isRemanente) relacionAntecedente.Nodo.Consecuentes.Remove(consecuente);
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
        public static void DeleteRelacion(Nodo antecedente, Nodo consecuente, Relacion relacionAntecedente)
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
        }
    }
}
