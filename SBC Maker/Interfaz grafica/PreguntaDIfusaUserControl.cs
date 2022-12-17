using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SBC_Maker.Logica;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class PreguntaDifusaUserControl : UserControl
    {
        public ConjuntoDifuso conjuntoDifuso = null;
        public PreguntaDifusaUserControl()
        {
            InitializeComponent();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Conjuntos Difusos";
            openFileDialog1.Filter = "CDF Conjunto Difuso (*.cdf)|*.cdf|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    ConjuntoDifuso conjuntoDifuso = (ConjuntoDifuso)bformatter.Deserialize(stream);
                    stream.Close();
                    this.conjuntoDifuso = conjuntoDifuso;
                    textBoxRuta.Text = conjuntoDifuso.Nombre;
                }
                catch
                {
                    MessageBox.Show("Archivo invalido");
                }
            }
        }

        private void PreguntaDifusaUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
