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
        private int indice = 0;
        public RespusestaCerradaUserControl(FlowLayoutPanel panelRespuesta)
        {
            InitializeComponent();
            this.PanelRespuesta = panelRespuesta;
            this.indice = this.PanelRespuesta.Controls.Count + 1;
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
            if (respuesta == "" || !isUnique(respuesta))
            {
                textBoxRespuesta1.Text = this.memoria;
            }
            else
            {
                this.memoria = respuesta;
            }
        }
        private bool isUnique(string respuesta)
        {
            foreach (RespusestaCerradaUserControl rcuc in this.panelRespuesta.Controls)
            {
                if (rcuc.textBoxRespuesta1.Text == respuesta && this.indice != rcuc.indice)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
