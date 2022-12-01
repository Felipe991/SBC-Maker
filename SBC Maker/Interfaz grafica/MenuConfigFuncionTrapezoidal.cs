using SBC_Maker.Logica.Conjuntos_Difusos;
using ScottPlot.Plottable;
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
    public partial class MenuConfigFuncionTrapezoidal : Form
    {
        public FuncionTrapezoidal funcTrapezoidal;
        public ScatterPlot plotTrapezoidal; 
        private Utiles utiles = new Utiles();
        private List<string> memoriaTextBoxes;
        
        public MenuConfigFuncionTrapezoidal(FuncionTrapezoidal funcionTrapezoidal,ScatterPlot plotGrafico)
        {
            this.funcTrapezoidal = funcionTrapezoidal;
            this.plotTrapezoidal = plotGrafico;
            InitializeComponent();
            RellenarCampos();
            IniciarMemoria();
            IniciarGrafico();
        }

        private void RellenarCampos()
        {
            textBoxLimIzquierdo.Text = funcTrapezoidal.LimIzquierdo.ToString();
            textBoxCentroIzq.Text = funcTrapezoidal.CentroIzq.ToString();
            textBoxCentroDer.Text = funcTrapezoidal.CentroDer.ToString();
            textBoxLimDerecho.Text = funcTrapezoidal.LimDerecho.ToString();
        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label("Unidades");
            formsPlot1.Plot.YAxis.Label("Pertenencia");
            formsPlot1.Plot.Title(funcTrapezoidal.Nombre);
            ActualizarValoresGrafico();
        }
        
        private void ActualizarValoresGrafico()
        {
            Double[] valoresX = funcTrapezoidal.getValoresX();
            Double[] valoresY = funcTrapezoidal.getValoresY();
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(valoresX, valoresY, plotTrapezoidal.Color);
            formsPlot1.Refresh();
        }

        private void MenuConfigFuncionTrapezoidal_Load(object sender, EventArgs e)
        {

        }
        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
        private void IniciarMemoria()
        {
            memoriaTextBoxes = new List<string>();
            memoriaTextBoxes.Add(textBoxLimIzquierdo.Text);
            memoriaTextBoxes.Add(textBoxCentroIzq.Text);
            memoriaTextBoxes.Add(textBoxCentroDer.Text);
            memoriaTextBoxes.Add(textBoxLimDerecho.Text);
        }

        private void textBoxLimIzquierdo_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[0] = textBoxLimIzquierdo.Text;
        }

        private void textBoxCentroIzq_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[1] = textBoxCentroIzq.Text;
        }

        private void textBoxCentroDer_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[2] = textBoxCentroDer.Text;
        }
        
        private void textBoxLimDerecho_Enter(object sender, EventArgs e)
        {
            memoriaTextBoxes[3] = textBoxLimDerecho.Text;
        }

        private void textBoxLimIzquierdo_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxLimIzquierdo.Text))
            {
                Double textoParseado = Double.Parse(textBoxLimIzquierdo.Text);
                if (textoParseado < funcTrapezoidal.centroIzq
                    ||(textoParseado == funcTrapezoidal.centroIzq && !funcTrapezoidal.isRecto()))
                {
                    funcTrapezoidal.LimIzquierdo = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxLimIzquierdo.Text = memoriaTextBoxes[0];
        }

        private void textBoxCentroIzq_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxCentroIzq.Text))
            {
                Double textoParseado = Double.Parse(textBoxCentroIzq.Text);
                if ((textoParseado > funcTrapezoidal.LimIzquierdo
                    && textoParseado<funcTrapezoidal.CentroDer)
                    ||(textoParseado == funcTrapezoidal.LimIzquierdo && !funcTrapezoidal.isRecto()))
                {
                    funcTrapezoidal.CentroIzq = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxCentroIzq.Text = memoriaTextBoxes[1];
        }

        private void textBoxCentroDer_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxCentroDer.Text))
            {
                Double textoParseado = Double.Parse(textBoxCentroDer.Text);
                if ((textoParseado> funcTrapezoidal.CentroIzq
                    && textoParseado<funcTrapezoidal.LimDerecho)
                    || (textoParseado == funcTrapezoidal.LimDerecho && !funcTrapezoidal.isRecto()))
                {
                    funcTrapezoidal.CentroDer = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxCentroDer.Text = memoriaTextBoxes[2];
        }

        private void textBoxLimDerecho_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxLimDerecho.Text))
            {
                Double textoParseado = Double.Parse(textBoxLimDerecho.Text);
                if ((textoParseado>funcTrapezoidal.CentroDer)
                    || (textoParseado == funcTrapezoidal.CentroDer && !funcTrapezoidal.isRecto()))
                {
                    funcTrapezoidal.LimDerecho = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxLimDerecho.Text = memoriaTextBoxes[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBoxCentroIzq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
