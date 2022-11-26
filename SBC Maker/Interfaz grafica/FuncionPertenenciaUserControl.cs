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
    public partial class FuncionPertenenciaUserControl : UserControl
    {
        public FuncionPertenenciaUserControl()
        {
            InitializeComponent();
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            string opcionSeleccionada = comboBoxFuncionesPertenencia.Text;
            switch (opcionSeleccionada)
            {
                case "Triangular":
                    Console.WriteLine(1+opcionSeleccionada);
                    break;
                case "Gaussiana":
                    Console.WriteLine(2+opcionSeleccionada);
                    break;
                case "Trapezoidal":
                    Console.WriteLine(3+opcionSeleccionada);
                    break;
                default:
                    break;
            }
        }
    }
}
