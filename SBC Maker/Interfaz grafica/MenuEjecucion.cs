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

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuEjecucion : Form
    {
        private SBC sbc;
        public MenuEjecucion(SBC sbc)
        {
            InitializeComponent();
            //Recibo el sbc
            //Busco reglas aplicables
                //Si no existen exit
            //Reviso si tengo conclusiones y las agrego
                //Si no se ha llegado llegado al limite de conclusiones exit
            //Soluciono conflictos entre reglas aplicables
            //Pregunto por la regla aplicable
            //Agrego el hecho a la respectiva regla
        }
    }
}
