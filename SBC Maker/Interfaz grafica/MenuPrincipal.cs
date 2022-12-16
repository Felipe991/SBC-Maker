using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SBC_Maker.Logica.Utiles;
using static SBC_Maker.Logica.FormListener;
using SBC_Maker.Logica;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConfeccion_Click(object sender, EventArgs e)
        {
            instanceNewForm(new MenuConfeccion());
            this.Close();
        }

        private void buttonEjecucion_Click(object sender, EventArgs e)
        {
            SBC sbc = loadSBC();
            if (sbc != null)
            {
                if (!VerifyStructure(sbc.BaseConocimiento)) MessageBox.Show("Base de conocimiento invalida", "Error");
                else iniciarEjecucion(sbc);
            }
        }

        private void iniciarEjecucion(SBC sbc)
        {
            instanceNewForm(new MenuEjecucion(sbc));
            this.Close();
        }

        private SBC loadSBC()
        {
            SBC sbc = new SBC();
            try
            {
                openFileDialogSBC.Filter = "SBC Sistema Basado en Conocimiento (*.sbc)|*.sbc|All files (*.*)|*.*";
                if (openFileDialogSBC.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = File.Open(openFileDialogSBC.FileName, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    sbc = (SBC)bformatter.Deserialize(stream);
                    stream.Close();
                    sbc.Nombre = openFileDialogSBC.FileName.Split('\\').Last().Split('.').First();
                }
            }
            catch
            {
                MessageBox.Show("Archivo inválido");
                return null;
            }
            return sbc;
        }
    }
}
