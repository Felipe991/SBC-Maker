using SBC_Maker.Interfaz_grafica;
using SBC_Maker.Logica;
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

namespace SBC_Maker
{
    public partial class MenuConjuntoDifuso : Form
    {
        private ConjuntoDifuso conjuntoDifuso;
        public MenuConjuntoDifuso()
        {
            InitializeComponent();
            IniciarGrafico();
            conjuntoDifuso = new ConjuntoDifuso(textBoxNombre.Text,1);
        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label("Unidades");
            formsPlot1.Plot.YAxis.Label("Pertenencia");
            formsPlot1.Plot.SetAxisLimits(-10, 10, 0, 1.2);
            formsPlot1.Plot.Title(textBoxNombre.Text);
            formsPlot1.Refresh();
        }

        private void MenuConjuntoDifuso_Load(object sender, EventArgs e)
        {

        }

        private void addFuncionButton_Click(object sender, EventArgs e)
        {
            int numeroFuncion = flowLayoutPanelFuncionesPertenencia.Controls.Count + 1;
            FuncionPertenencia funcionPertenencia = new FuncionPertenencia("Funcion N°" + numeroFuncion);
            ScatterPlot plot = null;
            conjuntoDifuso.addFuncionPertenencia(funcionPertenencia);
            flowLayoutPanelFuncionesPertenencia.Controls.Add(new FuncionPertenenciaUserControl(funcionPertenencia,plot));
            formsPlot1.Plot.Add(plot);
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            formsPlot1.Plot.Title(textBoxNombre.Text);
            formsPlot1.Refresh();
        }

        private void textBoxNombreUnidad_Leave(object sender, EventArgs e)
        {
            formsPlot1.Plot.XAxis.Label(textBoxNombreUnidad.Text);
            formsPlot1.Refresh();
        }

        private void comboBoxMetodosResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            conjuntoDifuso.MetodoResolucion = comboBoxMetodosResolucion.SelectedIndex;
        }
    }
}
