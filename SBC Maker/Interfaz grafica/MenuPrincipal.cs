﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SBC_Maker.Logica.Utiles;
using static SBC_Maker.Logica.FormListener;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonConfeccion_Click(object sender, EventArgs e)
        {
            MenuConfeccion menuConfeccion = new MenuConfeccion();
            menuConfeccion.FormClosed += delForm;
            addForm();
            menuConfeccion.Show();
            this.Close();
        }

        private void buttonEjecucion_Click(object sender, EventArgs e)
        {
            //Cargar el archivo SBC
            //VerifyStructure(sbc.listaadyacencia)
            /*MenuEjecucion menuEjecucio = new MenuEjecucion(sbc);
             * menuEjecucio.FormClosed += delForm;
             * addForm();
            menuConfeccion.Show();
            this.Dispose();*/
        }
    }
}
