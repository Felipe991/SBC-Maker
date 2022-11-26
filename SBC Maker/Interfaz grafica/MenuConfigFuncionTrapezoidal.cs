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
    public partial class MenuConfigFuncionTrapezoidal : Form
    {
        private FuncionTrapezoidal funcTrapezoidal;
        private Utiles utiles = new Utiles();
        private List<string> memoriaTextBoxes;
        public MenuConfigFuncionTrapezoidal(string nombreFuncion)
        {
            InitializeComponent();
            iniciarMemoria();

            funcTrapezoidal = new FuncionTrapezoidal(Double.Parse(textBoxLimIzquierdo.Text),
                                       Double.Parse(textBoxCentroIzq.Text),
                                       Double.Parse(textBoxCentroDer.Text),
                                       Double.Parse(textBoxLimDerecho.Text),
                                       nombreFuncion);
            IniciarGrafico();
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
            Double[] valoresX = getValoresX();
            Double[] valoresY = getValoresY();
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(valoresX, valoresY, Color.Red);
            formsPlot1.Refresh();
        }

        private double[] getValoresX()
        {
            List<Double> valorsX = new List<Double>();
            valorsX.Add(funcTrapezoidal.LimIzquierdo);
            valorsX.Add(funcTrapezoidal.CentroIzq);
            valorsX.Add(funcTrapezoidal.CentroDer);
            valorsX.Add(funcTrapezoidal.LimDerecho);
            return valorsX.ToArray();
        }

        private double[] getValoresY()
        {
            List<Double> valores = new List<Double>();
            valores.Add(funcTrapezoidal.CalcularPertenencia(funcTrapezoidal.LimIzquierdo));
            valores.Add(funcTrapezoidal.CalcularPertenencia(funcTrapezoidal.CentroIzq));
            valores.Add(funcTrapezoidal.CalcularPertenencia(funcTrapezoidal.CentroDer));
            valores.Add(funcTrapezoidal.CalcularPertenencia(funcTrapezoidal.LimDerecho));
            return valores.ToArray();
        }

        private void MenuConfigFuncionTrapezoidal_Load(object sender, EventArgs e)
        {

        }
        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
        private void iniciarMemoria()
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
                if (!utiles.IsGreater(textoParseado, funcTrapezoidal.CentroIzq))
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
                if (utiles.IsGreater(textoParseado, funcTrapezoidal.LimIzquierdo)
                    && !utiles.IsGreater(textoParseado, funcTrapezoidal.CentroDer))
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
                if (utiles.IsGreater(textoParseado, funcTrapezoidal.CentroIzq)
                    && !utiles.IsGreater(textoParseado, funcTrapezoidal.LimDerecho))
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
                if (utiles.IsGreater(textoParseado, funcTrapezoidal.CentroDer))
                {
                    funcTrapezoidal.LimDerecho = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxLimDerecho.Text = memoriaTextBoxes[3];
        }

    }
}
