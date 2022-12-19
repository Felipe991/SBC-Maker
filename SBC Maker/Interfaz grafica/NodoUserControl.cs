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
        public List<(string, (Posicion, Posicion))> flechas = new();
        private List<Nodo> listaAdyacencia;
        private static Size mouseOffset;
        private bool IsPicked = false;
        private Panel panelPadre;

        public NodoUserControl(Nodo nodo, List<Nodo> listaadyacencia, Panel panelPadre)
        {
            InitializeComponent();
            this.panelPadre = panelPadre;
            richTextBoxNombreRegla.SelectionAlignment = HorizontalAlignment.Center;
            this.nodo = nodo;
            this.listaAdyacencia = listaadyacencia;
            this.richTextBoxNombreRegla.Text = nodo.Regla.Nombre;
            setBackColor();
            extendEvents();
        }

        private void setBackColor()
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
            foreach (Control control in this.Controls)
            {
                control.MouseDown += NodoUserControl_MouseDown;
                control.MouseMove += NodoUserControl_MouseMove;
                control.MouseUp += NodoUserControl_MouseUp;
            }
        }

        private void RefreshNodePos()
        {
            this.nodo.Posicion.X = this.Left;
            this.nodo.Posicion.Y = this.Top;
        }

        private void richTextBoxNombreRegla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditReglaMenu();
        }

        private void NodoUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            IsPicked = false;
        }

        private void NodoUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPicked)
            {
                Point point = e.Location - mouseOffset;
                if (!OutOfBounds(point))
                {
                    this.Left += point.X;
                    this.Top += point.Y;
                    RefreshNodePos();
                }
            }
        }

        private bool OutOfBounds(Point point)
        {
            return ((this.Left + point.X) < 0 || (this.Top + point.Y) < 0);
        }

        private void NodoUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            IsPicked = true;
            mouseOffset = new Size(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void editarReglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReglaMenu();
        }

        private void EditReglaMenu()
        {
            MenuRegla menuRegla = new MenuRegla(this.nodo, this.listaAdyacencia);
            menuRegla.ShowDialog();
            if (menuRegla.DialogResult == DialogResult.OK)
            {
                if (menuRegla.modificado) DeleteAllArrows(this.nodo);
                this.nodo = menuRegla.nodo;
                this.listaAdyacencia = menuRegla.listaAdyacencia;
                this.richTextBoxNombreRegla.Text = menuRegla.nodo.Regla.Nombre;
                setBackColor();
                this.panelPadre.Refresh();
            }
        }

        private void editarRelacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEditarRelaciones menuEditarRelaciones = new MenuEditarRelaciones(this.nodo, listaAdyacencia);
            menuEditarRelaciones.ShowDialog();
            if(menuEditarRelaciones.DialogResult == DialogResult.OK)
            {
                DeleteRelaciones(menuEditarRelaciones.relacionesEliminadas);
            }
        }

        private void DeleteRelaciones(List<(Nodo, Nodo, Relacion)> relacionesEliminadas)
        {
            foreach ((Nodo, Nodo, Relacion) relacion in relacionesEliminadas)
            {
                string idFlecha = relacion.Item1.Regla.Nombre + relacion.Item2.Regla.Nombre;
                DeleteFlecha(idFlecha);
                DeleteRelacion(relacion.Item1, relacion.Item2, relacion.Item3);
                panelPadre.Refresh();
            }
        }

        private void DeleteFlecha(string idFlecha)
        {
            flechas.Remove(flechas.Find(x => x.Item1 == idFlecha));
        }

        private void eliminarReglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllArrows(this.nodo);
            DeleteNodo(this.nodo, this.listaAdyacencia);
            AsignarNivelGlobal(listaAdyacencia);
            this.panelPadre.Refresh();
            this.Dispose();
        }

        private void DeleteAllArrows(Nodo nodo)
        {
            List<string> idsRelaciones = getIdsRelaciones(this.nodo);
            foreach (string idRelacion in idsRelaciones)
            {
                DeleteFlecha(idRelacion);
            }
        }

        private List<string> getIdsRelaciones(Nodo nodo)
        {
            List<string> idsRelaciones = new();
            idsRelaciones.AddRange(getIdsRelacionesAntecedentes(nodo));
            idsRelaciones.AddRange(getIdsRelacionesConsecuentes(nodo));
            idsRelaciones.AddRange(getIdsRelacionesColaterales(nodo));
            return idsRelaciones;
        }

        private List<string> getIdsRelacionesColaterales(Nodo nodo)
        {
            List<string> idsRelaciones = new();
            foreach (Nodo consecuente in nodo.Consecuentes)
            {
                foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
                {
                    Relacion relacion = antecedentes.Find(x => x.Nodo.Equals(nodo));
                    if (relacion == null) continue;
                    foreach(Relacion antecedente in antecedentes)
                    {
                        if (antecedente.Nodo.Equals(nodo)) continue;
                        idsRelaciones.Add(antecedente.Nodo.Regla.Nombre + consecuente.Regla.Nombre);
                    }
                }
            }
            return idsRelaciones;
        }

        private List<string> getIdsRelacionesConsecuentes(Nodo nodoAntecedente)
        {
            List<string> idsRelacionesConsecuentes = new();
            foreach(Nodo consecuente in nodoAntecedente.Consecuentes)
            {
                idsRelacionesConsecuentes.Add(nodoAntecedente.Regla.Nombre+consecuente.Regla.Nombre);
            }
            return idsRelacionesConsecuentes;
        }

        private List<string> getIdsRelacionesAntecedentes(Nodo nodoConsecuente)
        {
            List<string> idsRelacionesAntecedentes = new();
            foreach(List<Relacion> relacionesAntecedentes in nodoConsecuente.Antecedentes)
            {
                foreach(Relacion relacionAntecedente in relacionesAntecedentes)
                {
                    idsRelacionesAntecedentes.Add(relacionAntecedente.Nodo.Regla.Nombre+nodoConsecuente.Regla.Nombre);
                }
            }
            return idsRelacionesAntecedentes;
        }
    }
}
