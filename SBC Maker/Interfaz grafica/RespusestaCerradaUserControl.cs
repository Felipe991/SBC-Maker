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
    public partial class RespusestaCerradaUserControl : UserControl
    {
        private FlowLayoutPanel panelRespuesta;
        private string memoria;
        private int indice;
        public RespusestaCerradaUserControl(FlowLayoutPanel panelRespuesta, int indice)
        {
            InitializeComponent();
            this.PanelRespuesta = panelRespuesta;
            this.indice = indice;
            this.textBoxRespuesta1.Text = "Respuesta " + this.indice;
            this.memoria = this.textBoxRespuesta1.Text;
        }

        public FlowLayoutPanel PanelRespuesta { get => panelRespuesta; set => panelRespuesta = value; }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            this.panelRespuesta.Controls.Remove(this);
        }

        private void textBoxRespuesta1_Leave(object sender, EventArgs e)
        {
            string respuesta = textBoxRespuesta1.Text;
            if (respuesta == "")
            {
                textBoxRespuesta1.Text = this.memoria;
            }
            else
            {
                this.memoria = respuesta;
            }
        }
    }
}
