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
        FuncionPertenencia funcionPertenencia;
        FuncionTriangular funcionTriangular;
        FuncionTrapezoidal funcionTrapezoidal;
        FuncionGaussiana funcionGaussiana;
        ConjuntoDifuso conjuntoAux;
        FormsPlot formsPlotAux;
        ScatterPlot plot;
        public FuncionPertenenciaUserControl(string nombre, ConjuntoDifuso conjuntoDifuso,FormsPlot formsPlot)
        {
            InitializeComponent();
            conjuntoAux = conjuntoDifuso;
            formsPlotAux = formsPlot;
            funcionPertenencia = new FuncionPertenencia(nombre);
            funcionTriangular = new FuncionTriangular(-10,0,10, nombre);
            funcionTrapezoidal = new FuncionTrapezoidal(-10, -5, 5, 10, nombre);
            funcionGaussiana = new FuncionGaussiana(5, 0.5, nombre);
            funcionPertenencia = funcionTriangular;
            conjuntoAux.addFuncionPertenencia(funcionPertenencia);
            textBoxNombreFuncionPertenencia.Text = funcionPertenencia.Nombre;
            iniciarPlot();
        }

        private void iniciarPlot()
        {
            Double[] valoresX = getValoresX();
            Double[] valoresY = getValoresY();
            plot = new ScatterPlot(valoresX, valoresY);
            plot.Color = Color.Red;
            formsPlotAux.Plot.Add(plot);
            //formsPlotAux.Refresh(false,true);
        }

        private double[] getValoresX()
        {
            List<Double> valorsX = new List<Double>();

            switch (funcionPertenencia)
            {
                case FuncionTriangular:
                    valorsX.Add(funcionTriangular.LimiteIzquierdo);
                    valorsX.Add(funcionTriangular.Centro);
                    valorsX.Add(funcionTriangular.LimiteDerecho);
                    break;
                case FuncionTrapezoidal:
                    valorsX.Add(funcionTrapezoidal.LimIzquierdo);
                    valorsX.Add(funcionTrapezoidal.CentroIzq);
                    valorsX.Add(funcionTrapezoidal.CentroDer);
                    valorsX.Add(funcionTrapezoidal.LimDerecho);
                    break;
                case FuncionGaussiana:
                    for (Double i = funcionGaussiana.Centro - (funcionGaussiana.DesviacionEstandar * 7);
                        i <= funcionGaussiana.Centro + (funcionGaussiana.DesviacionEstandar * 7);
                        i += funcionGaussiana.DesviacionEstandar / 3)
                    {
                        valorsX.Add(i);
                    }
                    break;
                default:
                    break;
            }
            return valorsX.ToArray();
        }

        private double[] getValoresY()
        {
            List<Double> valores = new List<Double>();

            switch (funcionPertenencia)
            {
                case FuncionTriangular:
                    valores.Add(funcionTriangular.CalcularPertenencia(funcionTriangular.LimiteIzquierdo));
                    valores.Add(funcionTriangular.CalcularPertenencia(funcionTriangular.Centro));
                    valores.Add(funcionTriangular.CalcularPertenencia(funcionTriangular.LimiteDerecho));
                    break;
                case FuncionTrapezoidal:
                    valores.Add(funcionTrapezoidal.CalcularPertenencia(funcionTrapezoidal.LimIzquierdo));
                    valores.Add(funcionTrapezoidal.CalcularPertenencia(funcionTrapezoidal.CentroIzq));
                    valores.Add(funcionTrapezoidal.CalcularPertenencia(funcionTrapezoidal.CentroDer));
                    valores.Add(funcionTrapezoidal.CalcularPertenencia(funcionTrapezoidal.LimDerecho));
                    break;
                case FuncionGaussiana:
                    for (Double i = funcionGaussiana.Centro - (funcionGaussiana.DesviacionEstandar * 7);
                        i <= funcionGaussiana.Centro + (funcionGaussiana.DesviacionEstandar * 7);
                        i += funcionGaussiana.DesviacionEstandar / 3)
                    {
                        valores.Add(funcionGaussiana.CalcularPertenencia(i));
                    }
                    break;
                default:
                    break;
            }
            return valores.ToArray();
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBoxFuncionesPertenencia.Text;
            switch (opcionSeleccionada)
            {
                case "Triangular":
                    MenuConfigFuncionTriangular mcft = new MenuConfigFuncionTriangular(funcionTriangular,plot);
                    if (mcft.ShowDialog() == DialogResult.OK)
                    {
                        funcionTriangular = mcft.funcTriangular;
                        funcionPertenencia = funcionTriangular;
                        plot = mcft.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                case "Trapezoidal":
                    MenuConfigFuncionTrapezoidal mcftr = new MenuConfigFuncionTrapezoidal(funcionTrapezoidal, plot);
                    if (mcftr.ShowDialog() == DialogResult.OK)
                    {
                        funcionTrapezoidal = mcftr.funcTrapezoidal;
                        funcionPertenencia = funcionTrapezoidal;
                        plot = mcftr.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                case "Gaussiana":
                    MenuConfigFuncionGaussiana mcfg = new MenuConfigFuncionGaussiana(funcionGaussiana, plot);
                    if (mcfg.ShowDialog() == DialogResult.OK)
                    {
                        funcionGaussiana = mcfg.funcGaussiana;
                        funcionPertenencia = funcionGaussiana;
                        plot = mcfg.formsPlot1.Plot.GetPlottables().First() as ScatterPlot;
                    }
                    break;
                default:
                    break;
            }
            //formsPlotAux.Refresh(false,true);
        }

        private void eliminarButton_Click_1(object sender, EventArgs e)
        {
            conjuntoAux.removeFuncionPertenencia(funcionPertenencia);
            //eliminar plot del scottplot
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
                plot.Color = colorDialog1.Color;
                buttonPintar.BackColor = colorDialog1.Color;
            }
        }
    }
}
