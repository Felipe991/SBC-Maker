using Newtonsoft.Json;
using SBC_Maker.Logica;
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
    public partial class MenuConfeccion : Form
    {
        public MenuConfeccion()
        {
            InitializeComponent();
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
                    var conjuntoDifusoJSON = File.ReadAllText(openFileDialog1.Title);
                    ConjuntoDifuso conjuntoDifuso = JsonConvert.DeserializeObject<ConjuntoDifuso>(conjuntoDifusoJSON);
                    MenuConjuntoDifuso mcd = new MenuConjuntoDifuso(conjuntoDifuso);
                    mcd.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Archivo invalido");
                }
            }
        }

        private void conjuntoDifusoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConjuntoDifuso menuConjuntoDifuso = new MenuConjuntoDifuso();
            menuConjuntoDifuso.ShowDialog();
        }
    }
}
