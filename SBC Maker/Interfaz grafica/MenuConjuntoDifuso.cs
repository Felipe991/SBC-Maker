using Newtonsoft.Json;
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            setDirectory();
            IniciarMemoria();
        }

        public MenuConjuntoDifuso(ConjuntoDifuso conjuntoDifuso)
        {
            InitializeComponent();
            setDirectory();
            this.conjuntoDifuso = conjuntoDifuso;
            textBoxNombre.Text = conjuntoDifuso.nombre;
            textBoxNombreUnidad.Text = conjuntoDifuso.NombreUnidades;
            comboBoxMetodosResolucion.SelectedIndex = conjuntoDifuso.MetodoResolucion;
            foreach (FuncionPertenencia funcion in conjuntoDifuso.funcionesPertenencia)
            {
                flowLayoutPanelFuncionesPertenencia.Controls.Add(new FuncionPertenenciaUserControl(funcion, conjuntoDifuso, formsPlot1));
            }
            IniciarGrafico();
            IniciarMemoria();
            this.Text += " (" + conjuntoDifuso.nombre + ")";
        }

        private void setDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "Conjuntos Difusos");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            saveFileDialog1.InitialDirectory = path;
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
                conjuntoDifuso.Nombre = textBoxNombre.Text;
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerificarFuncionesPertenencia())
            {
                GuardarFunciones();
                archivarConjunto();
            }
        }

        private void GuardarFunciones()
        {
            conjuntoDifuso.funcionesPertenencia.Clear();
            foreach (FuncionPertenenciaUserControl control in flowLayoutPanelFuncionesPertenencia.Controls)
            {
                conjuntoDifuso.funcionesPertenencia.Add(control.funcionPertenencia);
            }
        }

        private void archivarConjunto()
        {
            saveFileDialog1.FileName = this.conjuntoDifuso.nombre;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Conjuntos Difusos";
            saveFileDialog1.Filter = "CDF Conjunto Difuso (*.cdf)|*.cdf|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialog1.FileName).Close();
                Stream stream = File.Open(saveFileDialog1.FileName, FileMode.Create);
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, conjuntoDifuso);
                stream.Close();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Archivo guardado");
            }
            
        }

        private bool VerificarFuncionesPertenencia()
        {
            if (flowLayoutPanelFuncionesPertenencia.Controls.Count == 0)
            {
                MessageBox.Show("No hay funciones de pertenencia");
                return false;
            }
            else
            {
                List<string> nombres = new List<string>();
                foreach (FuncionPertenenciaUserControl control in flowLayoutPanelFuncionesPertenencia.Controls)
                {
                    if (nombres.Contains(control.funcionPertenencia.Nombre))
                    {
                        MessageBox.Show("Hay funciones de pertenencia con el mismo nombre");
                        return false;
                    }
                    nombres.Add(control.funcionPertenencia.Nombre);
                }
            }
            return true;
        }
    }
}
