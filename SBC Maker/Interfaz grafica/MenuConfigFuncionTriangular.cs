using SBC_Maker.Logica.Conjuntos_Difusos;
using ScottPlot;
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
    public partial class MenuConfigFuncionTriangular : Form 
    {
        public FuncionTriangular funcTriangular;
        private ScatterPlot plotTriangular;
        private Utiles utiles = new Utiles();
        private List<string> memoriaTextBoxes;
        public MenuConfigFuncionTriangular(FuncionTriangular funcionTriangular, ScatterPlot plotGrafico)
        {
            this.funcTriangular = funcionTriangular;
            this.plotTriangular = plotGrafico;
            InitializeComponent();
            RellenarCampos();
            IniciarMemoria();
            IniciarGrafico();
        }


        private void RellenarCampos()
        {
            textBoxLimIzquierdo.Text = funcTriangular.LimiteIzquierdo.ToString();
            textBoxMedia.Text = funcTriangular.Centro.ToString();
            textBoxLimDerecho.Text = funcTriangular.LimiteDerecho.ToString();
        }

        private void IniciarMemoria()
        {
            memoriaTextBoxes = new List<string>();
            memoriaTextBoxes.Add(textBoxLimIzquierdo.Text);
            memoriaTextBoxes.Add(textBoxMedia.Text);
            memoriaTextBoxes.Add(textBoxLimDerecho.Text);
        }

        private void MenuConfigFuncionTriangular_Load(object sender, EventArgs e)
        {

        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label("Unidades");
            formsPlot1.Plot.YAxis.Label("Pertenencia");
            formsPlot1.Plot.Title(funcTriangular.Nombre);
            ActualizarValoresGrafico();
        }

        private void ActualizarValoresGrafico()
        {
            Double[] valoresX = funcTriangular.getValoresX();
            Double[] valoresY = funcTriangular.getValoresY();
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(valoresX, valoresY, plotTriangular.Color);
            formsPlot1.Refresh();
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLimIzquierdo_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxLimIzquierdo.Text))
            {
                Double textoParseado = Double.Parse(textBoxLimIzquierdo.Text);
                if (textoParseado<funcTriangular.Centro 
                    || (textoParseado == funcTriangular.Centro && !funcTriangular.isRecto()))
                {
                    funcTriangular.LimiteIzquierdo = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxLimIzquierdo.Text = memoriaTextBoxes[0];
        }

        private void textBoxMedia_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxMedia.Text))
            {
                Double textoParseado = Double.Parse(textBoxMedia.Text);
                if (textoParseado>funcTriangular.LimiteIzquierdo
                    && textoParseado<funcTriangular.limiteDerecho
                    || ((textoParseado == funcTriangular.LimiteIzquierdo || textoParseado == funcTriangular.LimiteDerecho) && !funcTriangular.isRecto()))
                {
                    funcTriangular.Centro = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxMedia.Text = memoriaTextBoxes[1];
        }

        private void textBoxLimDerecho_Leave(object sender, EventArgs e)
        {
            if (utiles.IsDouble(textBoxLimDerecho.Text))
            {
                Double textoParseado = Double.Parse(textBoxLimDerecho.Text);
                if (textoParseado>funcTriangular.Centro
                    | (textoParseado == funcTriangular.Centro && !funcTriangular.isRecto()))
                {
                    funcTriangular.LimiteDerecho = textoParseado;
                    ActualizarValoresGrafico();
                    return;
                }
            }
            textBoxLimDerecho.Text = memoriaTextBoxes[2];
        }

        private void textBoxLimIzquierdo_Enter(object sender, EventArgs e)
        {
            guardarMemoria(1, textBoxLimIzquierdo.Text);
        }

        private void textBoxMedia_Enter(object sender, EventArgs e)
        {
            guardarMemoria(2, textBoxMedia.Text);
        }

        private void textBoxLimDerecho_Enter(object sender, EventArgs e)
        {
            guardarMemoria(3, textBoxLimDerecho.Text);
        }
        
        private void guardarMemoria(int numeroTextBox, string text)
        {
            switch (numeroTextBox)
            {
                case 1:
                    memoriaTextBoxes[0] = text;
                    break;
                case 2:
                    memoriaTextBoxes[1] = text;
                    break;
                case 3:
                    memoriaTextBoxes[2] = text;
                    break;
                default:
                    break;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
