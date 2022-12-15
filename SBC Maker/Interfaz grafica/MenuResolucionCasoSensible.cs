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
    public partial class MenuResolucionCasoSensible : Form
    {
        public MenuResolucionCasoSensible(List<string> nivelesEnConflicto)
        {
            InitializeComponent();
            Control controlAlternativas = new EjecucionRespuestaCerradaUserControl(nivelesEnConflicto);
            this.panel1.Controls.Add(controlAlternativas);
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string getRespuesta()
        {
            return ((EjecucionRespuestaCerradaUserControl)panel1.Controls[0]).getRespuesta();
        }

        private void MenuResolucionCasoSensible_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
