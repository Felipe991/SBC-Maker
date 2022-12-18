using SBC_Maker.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class ConclusionUserControl : UserControl
    {
        public ConclusionUserControl( Nodo conclusion, bool showExplicacion)
        {
            InitializeComponent();
            this.nombreConclusionLabel.Text = conclusion.Regla.Nombre;
            this.richTextBoxIndicacion.Text = ((ReglaConclusion)conclusion.Regla).Indicacion;
            if (showExplicacion) fillTextBoxesExplicaciones(conclusion);
            else 
            {
                this.richTextBoxExplicacionProposicional.Text += "Explicación deshabilitada";
                this.richTextBoxExplicacionNatural.Text += "Explicación deshabilitada";
            } 
        }

        private void fillTextBoxesExplicaciones(Nodo conclusion)
        {
            (List<string>,List<string>) explicaciones = getExplicaciones(conclusion);
            List<string> explicacionesProposicionales = explicaciones.Item1;
            List<string> explicacionesNaturales = explicaciones.Item2;
            
            explicacionesNaturales.Reverse();
            explicacionesProposicionales.Reverse();
            for (int i = 0; i < explicacionesProposicionales.Count; i++)
            {
                this.richTextBoxExplicacionProposicional.Text += explicacionesProposicionales[i]+Environment.NewLine;
                if (explicacionesNaturales[i]!="") this.richTextBoxExplicacionNatural.Text += explicacionesNaturales[i]+Environment.NewLine;
            }
        }
        
        private (List<string>,List<string>)getExplicaciones(Nodo conclusion)
        {
            List<string> explicacionesProposicionales = new();
            List<string> explicacionesNaturales = new();
            List<Nodo> nodosRecorridos = new();
            recorrerHaciaArriba(conclusion,nodosRecorridos,explicacionesProposicionales,explicacionesNaturales);
            return (explicacionesProposicionales,explicacionesNaturales);
        }
        
        private void recorrerHaciaArriba(Nodo nodo, List<Nodo> nodosRecorridos,List<string> explicacionesProp, List<string> explicacionesNat)
        {
            nodosRecorridos.Add(nodo);
            if (nodo.Nivel == 0) return;
            (string , string) aux = buildExplicaciones(nodo);
            explicacionesProp.Add(aux.Item1);
            explicacionesNat.Add(aux.Item2);
            List<Relacion> relacionesAntecedentes = nodo.Antecedentes[nodo.IndiceRelacionCumplida];
            foreach (Relacion relacionAntecedente in relacionesAntecedentes)
            {
                if (!nodosRecorridos.Contains(relacionAntecedente.Nodo))
                    recorrerHaciaArriba(relacionAntecedente.Nodo, nodosRecorridos, explicacionesProp,explicacionesNat);
            }
        }
        
        private (string,string) buildExplicaciones(Nodo nodo)
        {
            string explicacionProposicional = "";
            string explicacionNatural = "";
            List<Relacion> relacionesAntecedentes = nodo.Antecedentes[nodo.IndiceRelacionCumplida];
            explicacionProposicional += getTipoReglaString(nodo);
            explicacionProposicional += nodo.Regla.Nombre + " <- ( ";
            foreach (Relacion relacionAntecedente in relacionesAntecedentes)
            {
                if (relacionAntecedente.Explicacion != "") explicacionNatural += relacionAntecedente.Explicacion + " y ";
                explicacionProposicional += "( ";
                explicacionProposicional += getTipoReglaString(relacionAntecedente.Nodo);
                explicacionProposicional += relacionAntecedente.Nodo.Regla.Nombre + " ";
                string enunciado = ((ReglaInformacion)relacionAntecedente.Nodo.Regla).Pregunta.Enunciado;
                explicacionProposicional += "P: " + enunciado + " R: " + relacionAntecedente.Nodo.Hecho.RespuestaFinal;
                explicacionProposicional += " ) ";
                if (relacionesAntecedentes.IndexOf(relacionAntecedente) == relacionesAntecedentes.Count - 1) explicacionProposicional += ")";
                else explicacionProposicional += "y ";
            }
            return (explicacionProposicional, explicacionNatural);
        }

        private string getTipoReglaString(Nodo nodo)
        {
            if (nodo.Regla is ReglaConclusion) return "[C] ";
            else if (nodo.Nivel == 0) return "[I] ";
            return "[i] ";
        }
    }
}
