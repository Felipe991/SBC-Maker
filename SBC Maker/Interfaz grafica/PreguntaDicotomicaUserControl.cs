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
    public partial class PreguntaDicotomicaUserControl : UserControl
    {
        string memoria1;
        string memoria2;
        public PreguntaDicotomicaUserControl()
        {
            InitializeComponent();
            memoria1 = textBoxRespuesta1.Text;
            memoria2 = textBoxRespuesta2.Text;
        }

        private void textBoxRespuesta1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRespuesta1_Leave(object sender, EventArgs e)
        {
            if (textBoxRespuesta1.Text == "" || textBoxRespuesta1.Text == textBoxRespuesta2.Text)
            {
                textBoxRespuesta1.Text = memoria1;
            }
            else
            {
                memoria1 = textBoxRespuesta1.Text;
            }
        }

        private void textBoxRespuesta2_Leave(object sender, EventArgs e)
        {
            if (textBoxRespuesta2.Text == "" || textBoxRespuesta1.Text == textBoxRespuesta2.Text)
            {
                textBoxRespuesta2.Text = memoria2;
            }
            else
            {
                memoria2 = textBoxRespuesta2.Text;
            }
        }
    }
}
