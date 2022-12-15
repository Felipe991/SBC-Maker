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
            if (showExplicacion) this.richTextBox1.Text+= buildExplicaciones(conclusion);
            else this.richTextBox1.Text+="Explicacion deshabilitada";
        }

        private List<string>buildExplicaciones(Nodo conclusion)
        {
            List<string> explicaciones = new();
            List<Nodo> nodosRecorridos = new();
            recorrerHaciaArriba(conclusion,nodosRecorridos,explicaciones);
            return explicaciones;
        }
        
        private void recorrerHaciaArriba(Nodo nodo, List<Nodo> nodosRecorridos,List<string> explicaciones)
        {
            nodosRecorridos.Add(nodo);
            if (nodo.Nivel == 0) return;
            explicaciones.Add(buildExplicacion(nodo));
            List<Relacion> relacionesAntecedentes = nodo.Antecedentes[nodo.IndiceRelacionCumplida];
            foreach (Relacion relacionAntecedente in relacionesAntecedentes)
            {
                if (!nodosRecorridos.Contains(relacionAntecedente.Nodo))
                    recorrerHaciaArriba(relacionAntecedente.Nodo, nodosRecorridos, explicaciones);
            }
        }
        
        private string buildExplicacion(Nodo nodo)
        {
            string explicacion = "";
            List<Relacion> relacionesAntecedentes = nodo.Antecedentes[nodo.IndiceRelacionCumplida];
            explicacion += getTipoReglaString(nodo);
            explicacion += nodo.Regla.Nombre + " -> ( ";
            foreach (Relacion relacionAntecedente in relacionesAntecedentes)
            {
                explicacion += getTipoReglaString(relacionAntecedente.Nodo);
                explicacion += relacionAntecedente.Nodo.Regla.Nombre + " ";
                if (relacionAntecedente.Explicacion != "") explicacion += relacionAntecedente.Explicacion+" ";
                else explicacion += "R:" + relacionAntecedente.Nodo.Hecho.RespuestaFinal+" ";
                if (relacionesAntecedentes.IndexOf(relacionAntecedente) == relacionesAntecedentes.Count - 1) explicacion += ")";
                else explicacion += "y ";
            }
            return explicacion;
        }

        private string getTipoReglaString(Nodo nodo)
        {
            if (nodo.Regla is ReglaConclusion) return "[C] ";
            else if (nodo.Nivel == 0) return "[I] ";
            return "[i] ";
        }
    }
}
