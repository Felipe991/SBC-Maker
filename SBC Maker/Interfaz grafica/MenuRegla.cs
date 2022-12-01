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
    public partial class MenuRegla : Form
    {
        PreguntaCerradaUserControl pduc = new PreguntaCerradaUserControl();
        PreguntaDifusaUserControl pdifuc = new PreguntaDifusaUserControl();
        public MenuRegla()
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pduc);
        }

        private void ConclusionButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = true;
            this.textBoxIndicacion.BackColor = Color.White;
            this.comboBoxTipoPregunta.Enabled = false;
            this.textBoxPregunta.Enabled = false;
            this.panelPregunta.Enabled = false;
        }

        private void InformacionButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.BackColor = Color.Silver;
            this.comboBoxTipoPregunta.Enabled = true;
            this.textBoxPregunta.Enabled = true;
            this.panelPregunta.Enabled = true;
        }

        private void InicioButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.BackColor = Color.Silver;
            this.comboBoxTipoPregunta.Enabled = true;
            this.textBoxPregunta.Enabled = true;
            this.panelPregunta.Enabled = true;
        }

        private void comboBoxTipoPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoPregunta.Text)
            {
                case ("Cerrada"):
                    this.panelPregunta.Controls.Clear();
                    this.panelPregunta.Controls.Add(pduc);
                    break;
                case ("Difusa"):
                    this.panelPregunta.Controls.Clear();
                    this.panelPregunta.Controls.Add(pdifuc);
                    break;
            }
        }
    }
}
