﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SBC_Maker.Logica;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class PreguntaDifusaUserControl : UserControl
    {
        public PreguntaDifusaUserControl()
        {
            InitializeComponent();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var conjuntoDifusoJSON = File.ReadAllText(openFileDialog1.Title);
                    ConjuntoDifuso conjuntoDifuso = JsonConvert.DeserializeObject<ConjuntoDifuso>(conjuntoDifusoJSON);
                    textBoxRuta.Text = openFileDialog1.Title;
                }
                catch
                {
                    MessageBox.Show("Archivo invalido");
                }
            }
        }
    }
}
