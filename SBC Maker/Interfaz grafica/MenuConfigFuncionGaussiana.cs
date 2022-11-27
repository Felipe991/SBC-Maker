using SBC_Maker.Logica.Conjuntos_Difusos;
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
    public partial class MenuConfigFuncionGaussiana : Form
    {
        private FuncionGaussiana funcGaussiana;
        private List<string> memoriaTextBoxes;
        private Utiles utiles = new Utiles();
        
        public MenuConfigFuncionGaussiana(string nombreFuncion)
        {
            InitializeComponent();
            iniciarMemoria();
            funcGaussiana = new FuncionGaussiana(Double.Parse(textBoxCentro.Text),
                                       Double.Parse(textBoxDesviacionEstandar.Text),
                                       nombreFuncion);
            IniciarGrafico();
        }
        
        private void iniciarMemoria()
        {
            memoriaTextBoxes = new List<string>();
            memoriaTextBoxes.Add(textBoxDesviacionEstandar.Text);
            memoriaTextBoxes.Add(textBoxCentro.Text);
        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label("Unidades");
            formsPlot1.Plot.YAxis.Label("Pertenencia");
            formsPlot1.Plot.Title(funcGaussiana.Nombre);
            ActualizarValoresGrafico();
        }

        private void ActualizarValoresGrafico()
        {
            Double[] valoresX = getValoresX();
            Double[] valoresY = getValoresY();
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(valoresX, valoresY, Color.Red);
            formsPlot1.Refresh();
        }

        private double[] getValoresX()
        {
            List<Double> valorsX = new List<Double>();
            for (Double i = funcGaussiana.Centro-(funcGaussiana.DesviacionEstandar*7);
                i <= funcGaussiana.Centro + (funcGaussiana.DesviacionEstandar * 7);
                i+=funcGaussiana.DesviacionEstandar/3)
            {
                valorsX.Add(i);
            }
            return valorsX.ToArray();
        }

        private double[] getValoresY()
        {
            List<Double> valores = new List<Double>();
            for (Double i = funcGaussiana.Centro - (funcGaussiana.DesviacionEstandar * 7);
                i <= funcGaussiana.Centro + (funcGaussiana.DesviacionEstandar * 7);
                i += funcGaussiana.DesviacionEstandar/3)
            {
                valores.Add(funcGaussiana.CalcularPertenencia(i));
            }
            return valores.ToArray();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxDesviacionEstandar_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[0] = textBoxDesviacionEstandar.Text;
        }

        private void textBoxMedia_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[1] = textBoxCentro.Text;
        }

        private void textBoxDesviacionEstandar_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxDesviacionEstandar.Text))
            {
                Double textoParseado = Double.Parse(textBoxDesviacionEstandar.Text);
                if (textoParseado>0)
                {
                    funcGaussiana.DesviacionEstandar = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxDesviacionEstandar.Text = memoriaTextBoxes[0];
        }

        private void textBoxMedia_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxCentro.Text))
            {
                Double textoParseado = Double.Parse(textBoxCentro.Text);
                funcGaussiana.Centro = textoParseado;
                ActualizarValoresGrafico();
                return;
            }
            textBoxCentro.Text = memoriaTextBoxes[1];
        }
    }
}
