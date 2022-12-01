using SBC_Maker.Logica;
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
    public partial class FuncionPertenenciaUserControl : UserControl
    {
        public FuncionPertenencia funcionPertenencia;
        FuncionTriangular funcionTriangular;
        FuncionTrapezoidal funcionTrapezoidal;
        FuncionGaussiana funcionGaussiana;
        public ConjuntoDifuso conjuntoAux;
        public FormsPlot formsPlotAux;
        public ScatterPlot plot;
        public FuncionPertenenciaUserControl(string nombre, ConjuntoDifuso conjuntoDifuso,FormsPlot formsPlot)
        {
            InitializeComponent();
            conjuntoAux = conjuntoDifuso;
            formsPlotAux = formsPlot;
            funcionTriangular = new FuncionTriangular(-10,0,10, nombre);
            funcionTrapezoidal = new FuncionTrapezoidal(-10, -5, 5, 10, nombre);
            funcionGaussiana = new FuncionGaussiana(0, 2, nombre);
            funcionPertenencia = funcionTriangular;
            conjuntoAux.addFuncionPertenencia(funcionPertenencia);
            textBoxNombreFuncionPertenencia.Text = funcionPertenencia.Nombre;
            iniciarPlot();
        }

        public FuncionPertenenciaUserControl(FuncionPertenencia funcionPertenencia, ConjuntoDifuso conjuntoDifuso, FormsPlot formsPlot)
        {
            InitializeComponent();
            conjuntoAux = conjuntoDifuso;
            formsPlotAux = formsPlot;
            this.funcionPertenencia = funcionPertenencia;
            funcionTriangular = new FuncionTriangular(-10, 0, 10, funcionPertenencia.Nombre);
            funcionTrapezoidal = new FuncionTrapezoidal(-10, -5, 5, 10, funcionPertenencia.Nombre);
            funcionGaussiana = new FuncionGaussiana(0, 2, funcionPertenencia.Nombre);
            textBoxNombreFuncionPertenencia.Text = funcionPertenencia.Nombre;
            buttonPintar.BackColor = funcionPertenencia.color;
            ReconstuirFuncion(this.funcionPertenencia);
            iniciarPlot(funcionPertenencia.color);
        }

        private void ReconstuirFuncion(FuncionPertenencia funcionPertenencia)
        {
            switch (funcionPertenencia)
            {
                case FuncionTriangular:
                    funcionTriangular = (FuncionTriangular)funcionPertenencia;
                    comboBoxFuncionesPertenencia.SelectedIndex = 0;
                    break;
                case FuncionTrapezoidal:
                    funcionTrapezoidal = (FuncionTrapezoidal)funcionPertenencia;
                    comboBoxFuncionesPertenencia.SelectedIndex = 1;
                    break;
                case FuncionGaussiana:
                    funcionGaussiana = (FuncionGaussiana)funcionPertenencia;
                    comboBoxFuncionesPertenencia.SelectedIndex = 2;
                    break;
                default:
                    break;
            }
        }

        private void iniciarPlot()
        {
            Double[] valoresX = funcionPertenencia.getValoresX();
            Double[] valoresY = funcionPertenencia.getValoresY();
            plot = new ScatterPlot(valoresX, valoresY);
            plot.Color = Color.Red;
            funcionPertenencia.color = Color.Red;
            formsPlotAux.Plot.Add(plot);
            formsPlotAux.Plot.AxisAuto();
            formsPlotAux.Refresh(false,true);
        }

        private void iniciarPlot(Color color)
        {
            Double[] valoresX = funcionPertenencia.getValoresX();
            Double[] valoresY = funcionPertenencia.getValoresY();
            plot = new ScatterPlot(valoresX, valoresY);
            plot.Color = Color.Red;
            funcionPertenencia.color = color;
            formsPlotAux.Plot.Add(plot);
            formsPlotAux.Plot.AxisAuto();
            formsPlotAux.Refresh(false, true);
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            ScatterPlot plotAux = null;
            string opcionSeleccionada = comboBoxFuncionesPertenencia.Text;
            
            switch (opcionSeleccionada)
            {
                case "Triangular":
                    MenuConfigFuncionTriangular mcft = new MenuConfigFuncionTriangular(getCopiaFuncTriangular(funcionTriangular),plot);
                    if (mcft.ShowDialog() == DialogResult.OK)
                    {
                        funcionTriangular = mcft.funcTriangular;
                        funcionPertenencia = funcionTriangular;
                        plotAux = mcft.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                case "Trapezoidal":
                    MenuConfigFuncionTrapezoidal mcftr = new MenuConfigFuncionTrapezoidal(getCopiaFuncTrapezoidal(funcionTrapezoidal), plot);
                    if (mcftr.ShowDialog() == DialogResult.OK)
                    {
                        funcionTrapezoidal = mcftr.funcTrapezoidal;
                        funcionPertenencia = funcionTrapezoidal;
                        plotAux = mcftr.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                case "Gaussiana":
                    MenuConfigFuncionGaussiana mcfg = new MenuConfigFuncionGaussiana(getCopiaFuncGaussiana(funcionGaussiana), plot);
                    if (mcfg.ShowDialog() == DialogResult.OK)
                    {
                        funcionGaussiana = mcfg.funcGaussiana;
                        funcionPertenencia = funcionGaussiana;
                        plotAux = mcfg.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                default:
                    break;
            }
            if (plotAux == null) return;
            formsPlotAux.Plot.Remove(plot);
            formsPlotAux.Plot.Add(plotAux);
            formsPlotAux.Plot.AxisAuto();
            plot = plotAux;
            formsPlotAux.Refresh();
        }

        private FuncionTriangular getCopiaFuncTriangular(FuncionTriangular funcionTriangular)
        {
            return new FuncionTriangular(
                         funcionTriangular.LimiteIzquierdo,
                         funcionTriangular.Centro,
                         funcionTriangular.LimiteDerecho,
                         funcionTriangular.Nombre);
        }
        private FuncionTrapezoidal getCopiaFuncTrapezoidal(FuncionTrapezoidal funcionTrapezoidal)
        {
            return new FuncionTrapezoidal(
                         funcionTrapezoidal.LimIzquierdo,
                         funcionTrapezoidal.CentroIzq,
                         funcionTrapezoidal.CentroDer,
                         funcionTrapezoidal.LimDerecho,
                         funcionTrapezoidal.Nombre);
        }

        private FuncionGaussiana getCopiaFuncGaussiana(FuncionGaussiana funcionGaussiana)
        {
            return new FuncionGaussiana(
                         funcionGaussiana.CentroG,
                         funcionGaussiana.DesviacionEstandar,
                         funcionGaussiana.Nombre);
        }

        private void eliminarButton_Click_1(object sender, EventArgs e)
        {
            conjuntoAux.removeFuncionPertenencia(funcionPertenencia);
            formsPlotAux.Plot.Remove(plot);
            formsPlotAux.Refresh();
            this.Dispose();
        }

        private void textBoxNombreFuncionPertenencia_Leave(object sender, EventArgs e)
        {
            funcionPertenencia.Nombre = textBoxNombreFuncionPertenencia.Text;
            funcionTriangular.Nombre = textBoxNombreFuncionPertenencia.Text;
            funcionTrapezoidal.Nombre = textBoxNombreFuncionPertenencia.Text;
            funcionGaussiana.Nombre = textBoxNombreFuncionPertenencia.Text;
        }

        private void buttonPintar_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonPintar.BackColor = colorDialog1.Color;
                ScatterPlot plotAux = plot;
                plotAux.Color = colorDialog1.Color;
                formsPlotAux.Plot.Remove(plot);
                formsPlotAux.Plot.Add(plotAux);
                formsPlotAux.Refresh();
                plot = plotAux;
                funcionPertenencia.color = colorDialog1.Color;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxFuncionesPertenencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFuncionesPertenencia.Text)
            {
                case "Triangular":
                    funcionPertenencia = funcionTriangular;
                    break;
                case "Trapezoidal":
                    funcionPertenencia = funcionTrapezoidal;
                    break;
                case "Gaussiana":
                    funcionPertenencia = funcionGaussiana;
                    break;
                default:
                    break;
            }
            ReconstuirPlot();
        }

        private void ReconstuirPlot()
        {
            Double[] valoresX = funcionPertenencia.getValoresX();
            Double[] valoresY = funcionPertenencia.getValoresY();
            ScatterPlot plotAux = new ScatterPlot(valoresX, valoresY);
            plotAux.Color = plot.Color;
            formsPlotAux.Plot.Remove(plot);
            formsPlotAux.Plot.Add(plotAux);
            formsPlotAux.Plot.AxisAuto();
            formsPlotAux.Refresh(false, true);
            plot = plotAux;
        }

    }
}
