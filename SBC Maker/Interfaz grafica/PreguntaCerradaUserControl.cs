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
    public partial class PreguntaCerradaUserControl : UserControl
    {
        int contadorRespuesta = 1;
        public PreguntaCerradaUserControl()
        {
            InitializeComponent();
        }

        private void textBoxRespuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addFuncionButton_Click(object sender, EventArgs e)
        {
            RespusestaCerradaUserControl rcuc = new RespusestaCerradaUserControl(flowLayoutPanelRespuesta, this.contadorRespuesta);
            flowLayoutPanelRespuesta.Controls.Add(rcuc);
            contadorRespuesta++;
            
        }
    }
}
