using SBC_Maker.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class NodoUserControl : UserControl
    {
        Nodo nodo;
        private List<Nodo> listaAdyacencia;
        private static Size mouseOffset;
        private bool IsPicked = false;
        public NodoUserControl(Nodo nodo, List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            richTextBoxNombreRegla.SelectionAlignment = HorizontalAlignment.Center;
            this.nodo = nodo;
            
            this.nodo.Posicion.X = this.Left;
            this.nodo.Posicion.Y = this.Top;
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

        private void richTextBoxNombreRegla_MouseDown(object sender, MouseEventArgs e)
        {
            IsPicked = true;
        }

        private void richTextBoxNombreRegla_MouseUp(object sender, MouseEventArgs e)
        {
            IsPicked = false;
        }

        private void richTextBoxNombreRegla_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPicked)
            {
                Point point = e.Location - mouseOffset;
                this.Left += point.X;
                this.Top += point.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuRelacion mr = new MenuRelacion(listaAdyacencia,nodo);
            mr.ShowDialog();
        }
    }
}
