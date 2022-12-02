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
            IniciarMemoria();
        }

        public MenuConjuntoDifuso(ConjuntoDifuso conjuntoDifuso)
        {
            InitializeComponent();
            this.conjuntoDifuso = conjuntoDifuso;
            textBoxNombre.Text = conjuntoDifuso.nombre;
            textBoxNombreUnidad.Text = conjuntoDifuso.NombreUnidades;
            comboBoxMetodosResolucion.SelectedIndex = conjuntoDifuso.MetodoResolucion;
            foreach (FuncionPertenencia funcion in conjuntoDifuso.funcionesPertenencia)
            {
                flowLayoutPanelFuncionesPertenencia.Controls.Add(new FuncionPertenenciaUserControl(funcion.nombre, conjuntoDifuso, formsPlot1));
            }
            IniciarGrafico();
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerificarFuncionesPertenencia())
            {
                archivarConjunto();
            }
        }

        private void archivarConjunto()
        {
            saveFileDialog1.FileName = this.conjuntoDifuso.nombre;
            saveFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                /*var serializerOptiones = new JsonSerializerOptions();
                serializerOptiones.Converters.Add(new FuncionPertenenciaJsonConverter());
                var conjuntoDifusoJSON = System.Text.Json.JsonSerializer.Serialize(conjuntoDifuso, serializerOptiones);*/
                
                /*var conjuntoDifusoJSON = JsonConvert.SerializeObject(conjuntoDifuso, Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, conjuntoDifusoJSON);*/
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
