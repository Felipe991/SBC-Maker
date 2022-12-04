using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;
using static SBC_Maker.Logica.Utiles;
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
        public Nodo nodo;
        public Dictionary<string, (Posicion, Posicion)> flechas = new();
        private List<Nodo> listaAdyacencia;
        private static Size mouseOffset;
        private bool IsPicked = false;

        public NodoUserControl(Nodo nodo, List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            richTextBoxNombreRegla.SelectionAlignment = HorizontalAlignment.Center;
            this.nodo = nodo;
            this.listaAdyacencia = listaadyacencia;
            this.richTextBoxNombreRegla.Text = nodo.Regla.Nombre;
            InitializeBackColor();
            extendEvents();
            RefreshNodePos();
        }

        private void InitializeBackColor()
        {
            switch (nodo.Regla)
            {
                case ReglaConclusion:
                    this.BackColor = Color.Red;
                    break;
                case ReglaInformacion reglaInformacion:
                    if (reglaInformacion.ReglaInicio)
                    {
                        this.BackColor = Color.Green;
                    }
                    else
                    {
                        this.BackColor = Color.Yellow;
                    }
                    break;
            }
        }

        private void extendEvents()
        {
            /*foreach (Control control in this.Controls)
            {
                control.MouseDown += richTextBoxNombreRegla_MouseDown;
                control.MouseMove += richTextBoxNombreRegla_MouseMove;
                control.MouseUp += richTextBoxNombreRegla_MouseMove;
            }*/
        }

        private void RefreshNodePos()
        {
            this.nodo.Posicion.X = this.Left;
            this.nodo.Posicion.Y = this.Top;
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
                AsignarNivelGlobal(listaAdyacencia);
            }
        }

        private void richTextBoxNombreRegla_MouseDown(object sender, MouseEventArgs e)
        {
            IsPicked = true;
            mouseOffset = new Size(e.Location);
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
                RefreshNodePos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MenuRelacion mr = new MenuRelacion(listaAdyacencia,nodo);
            mr.ShowDialog();
            AsignarNivelGlobal(listaAdyacencia);
             */
        }
    }
}
