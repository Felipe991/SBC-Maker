using Newtonsoft.Json;
using SBC_Maker.Interfaz_grafica;
using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;
using static SBC_Maker.Logica.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;

namespace SBC_Maker
{
    public partial class MenuConfeccion : Form
    {
        private SBC sbc;
        public MenuConfeccion(string nombre)
        {
            InitializeComponent();
            this.sbc = new SBC(nombre, new ConfiguracionMotor());
        }
        public MenuConfeccion(SBC sbc)
        {
            InitializeComponent();
            this.sbc = sbc;
        }

        private void MenuConfeccion_Load(object sender, EventArgs e)
        {

        }

        private void conjuntoDifusoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    ConjuntoDifuso conjuntoDifuso = (ConjuntoDifuso)bformatter.Deserialize(stream);
                    stream.Close();
                    MenuConjuntoDifuso mcd = new MenuConjuntoDifuso(conjuntoDifuso);
                    mcd.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Archivo inválido");
                }
            }
        }

        private void conjuntoDifusoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConjuntoDifuso menuConjuntoDifuso = new MenuConjuntoDifuso();
            menuConjuntoDifuso.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfiguracionSBC menuConfiguracionSBC = new MenuConfiguracionSBC(sbc.ConfiguracionMotor);
            menuConfiguracionSBC.ShowDialog();
        }

        private void toolStripButtonAgregarRegla_Click(object sender, EventArgs e)
        {
            MenuRegla menuRegla = new MenuRegla(sbc.BaseConocimiento);
            menuRegla.ShowDialog();
            if (menuRegla.DialogResult == DialogResult.OK)
            {
                this.panelLienzo.Controls.Add(new NodoUserControl(menuRegla.nodo, sbc.BaseConocimiento));
            }
        }
    }
}
