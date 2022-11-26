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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBoxFuncionesPertenencia.Text;
            switch (opcionSeleccionada)
            {
                case "Triangular":
                    break;
                case "Gaussiana":
                    break;
                case "Trapezoidal":
                    break;
                default:
                    break;
            }
        }
    }
}
