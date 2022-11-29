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
        private List<String> memoria;
        public MenuConjuntoDifuso()
        {
            InitializeComponent();
            IniciarGrafico();
            conjuntoDifuso = new ConjuntoDifuso(textBoxNombre.Text,
                                                textBoxNombreUnidad.Text,
                                                comboBoxMetodosResolucion.SelectedIndex);
            IniciarMemoria();
        }

        private void IniciarMemoria()
        {
            memoria = new List<String>();
            memoria.Add(textBoxNombre.Text);
            memoria.Add(textBoxNombreUnidad.Text);
        }

        private void IniciarGrafico()
        {
            formsPlot1.Plot.XAxis.Label(textBoxNombreUnidad.Text);
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
            string nombreFuncion = "Funcion N°" + numeroFuncion;
            flowLayoutPanelFuncionesPertenencia.Controls.Add(new FuncionPertenenciaUserControl(nombreFuncion,conjuntoDifuso, formsPlot1));
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (!textBoxNombre.Text.Equals(""))
            {
                formsPlot1.Plot.Title(textBoxNombre.Text);
                formsPlot1.Refresh();
                memoria[0] = textBoxNombre.Text;
                return;
            }
            textBoxNombre.Text = memoria[0];
            MessageBox.Show("Nombre invalido");
        }

        private void textBoxNombreUnidad_Leave(object sender, EventArgs e)
        {
            if (!textBoxNombreUnidad.Text.Equals(""))
            {
                formsPlot1.Plot.XAxis.Label(textBoxNombreUnidad.Text);
                formsPlot1.Refresh();
                conjuntoDifuso.NombreUnidades = textBoxNombreUnidad.Text;
                memoria[1] = textBoxNombreUnidad.Text;
                return;
            }
            textBoxNombreUnidad.Text = memoria[1];
            MessageBox.Show("Unidad invalida");
        }

        private void comboBoxMetodosResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            conjuntoDifuso.MetodoResolucion = comboBoxMetodosResolucion.SelectedIndex;
        }
        
        private void flowLayoutPanelFuncionesPertenencia_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanelFuncionesPertenencia.Controls.Count != 1)
            {
                FixPlots();
            }
        }

        private void FixPlots()
        { 
            Double puntoMax = formsPlot1.Plot.GetAxisLimits().XMax;
            Double puntoMin = formsPlot1.Plot.GetAxisLimits().XMin;
            foreach (FuncionPertenenciaUserControl control in flowLayoutPanelFuncionesPertenencia.Controls)
            {
                FuncionPertenencia funcAux = control.funcionPertenencia;
                Double[] puntosX = (new Double[] { puntoMin }).Concat(control.plot.Xs).ToArray();
                puntosX = puntosX.Concat(new Double[] { puntoMax }).ToArray();
                Double[] puntosY = (new Double[] { funcAux.CalcularPertenencia(puntoMin) }).Concat(control.plot.Ys).ToArray();
                puntosY = puntosY.Concat((new Double[] { funcAux.CalcularPertenencia(puntoMax) })).ToArray();
                control.plot.Update(puntosX, puntosY);
            }
            formsPlot1.Refresh();
        }

        private void flowLayoutPanelFuncionesPertenencia_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanelFuncionesPertenencia.Controls.Count != 0)
            {
                FixPlots();
            }
        }
    }
}
