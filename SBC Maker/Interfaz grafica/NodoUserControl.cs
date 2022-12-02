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
    public partial class NodoUserControl : UserControl
    {
        Nodo nodo;
        private List<Nodo> listaAdyacencia;
        public NodoUserControl(Nodo nodo, List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            this.nodo = nodo;
            this.listaAdyacencia = listaadyacencia;
            this.richTextBoxNombreRegla.Text = nodo.Regla.Nombre;
        }

        private void richTextBoxNombreRegla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MenuRegla menuRegla = new MenuRegla(this.nodo, this.listaAdyacencia);
            menuRegla.ShowDialog();
            if (menuRegla.DialogResult == DialogResult.OK)
            {
                this.nodo = menuRegla.nodo;
                this.listaAdyacencia = menuRegla.listaAdyacencia;
                this.richTextBoxNombreRegla.Text = menuRegla.nodo.Regla.Nombre;
            }
        }
    }
}
