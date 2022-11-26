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
    public partial class MenuConfigFuncionTriangular : Form
    {
        private FuncionTriangular funcTriangular;
        public MenuConfigFuncionTriangular(string nombreFuncion)
        {
            InitializeComponent();
            funcTriangular = new FuncionTriangular(int.Parse(textBoxLimIzquierdo.Text),
                                                   int.Parse(textBoxMedia.Text),
                                                   int.Parse(textBoxLimDerecho.Text),
                                                   nombreFuncion);

            IniciarGrafico();
        }

        private void MenuConfigFuncionTriangular_Load(object sender, EventArgs e)
        {

        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label("Unidades");
            formsPlot1.Plot.YAxis.Label("Pertenencia");
            formsPlot1.Plot.SetAxisLimits(-10, 10, 0, 1.2);
            formsPlot1.Plot.Title(funcTriangular.Nombre);
            Double[] valoresX = getValoresX();
            Double[] valoresY = getValoresY();
            var plot = new ScottPlot.Plottable.ScatterPlot(valoresX, valoresY);
            formsPlot1.plt.Add(plot);
            formsPlot1.Refresh();
        }

        private double[] getValoresX()
        {
            List<Double> valorsX = new List<Double>();

            for (int i = (int)funcTriangular.LimiteIzquierdo; i <= funcTriangular.LimiteDerecho; i++)
            {
                valorsX.Add(i);
            }
            return valorsX.ToArray();
        }

        private double[] getValoresY()
        {
            List<Double> valores = new List<Double>();
            
            for (int i = (int)funcTriangular.LimiteIzquierdo; i <= (int)funcTriangular.LimiteDerecho; i++)
            {
                valores.Add(funcTriangular.CalcularPertenencia((double)i));
                System.Diagnostics.Debug.WriteLine(funcTriangular.CalcularPertenencia((double)i));
            }

            return valores.ToArray();
        }

        private void labelDesviacionEstandar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
