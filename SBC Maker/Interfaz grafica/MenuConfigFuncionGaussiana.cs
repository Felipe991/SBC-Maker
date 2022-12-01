using SBC_Maker.Logica;
using SBC_Maker.Logica.Conjuntos_Difusos;
using ScottPlot.Plottable;
using static SBC_Maker.Logica.Utiles;
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
        public FuncionGaussiana funcGaussiana;
        public ScatterPlot plotGaussiana;
        private List<string> memoriaTextBoxes;
        private Utiles utiles = new Utiles();
        
        public MenuConfigFuncionGaussiana(FuncionGaussiana funcionGaussiana, ScatterPlot plotGrafico)
        {
            this.funcGaussiana = funcionGaussiana;
            this.plotGaussiana = plotGrafico;
            InitializeComponent();
            RellenarCampos();
            IniciarMemoria();
            IniciarGrafico();
        }


        private void RellenarCampos()
        {
            textBoxCentro.Text = funcGaussiana.CentroG.ToString();
            textBoxDesviacionEstandar.Text = funcGaussiana.DesviacionEstandar.ToString();
        }

        private void IniciarMemoria()
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
            formsPlot1.Plot.AddScatter(valoresX, valoresY, plotGaussiana.Color);
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
            if (IsDouble(textBoxDesviacionEstandar.Text))
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
            if (IsDouble(textBoxCentro.Text))
            {
                Double textoParseado = Double.Parse(textBoxCentro.Text);
                funcGaussiana.CentroG = textoParseado;
                ActualizarValoresGrafico();
                return;
            }
            textBoxCentro.Text = memoriaTextBoxes[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
