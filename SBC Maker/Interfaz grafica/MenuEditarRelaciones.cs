using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;
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
    public partial class MenuEditarRelaciones : Form
    {
        Nodo nodoActual;
        List<Nodo> listaAdyacencia;
        List<(string, (Posicion, Posicion))> flechas;
        public MenuEditarRelaciones(Nodo nodo,List<Nodo> listaAdyacencia,List<(string, (Posicion, Posicion))> flechas)
        {
            InitializeComponent();
            nodoActual = nodo;
            this.listaAdyacencia = listaAdyacencia;
            this.flechas = flechas;
            InitializeRelaciones();
        }

        private void InitializeRelaciones()
        {
            foreach(List<Relacion> TipoRelacion in nodoActual.Antecedentes)
            {
                this.flowLayoutPanel1.Controls.Add(new RelacionUserControl(nodoActual,TipoRelacion,listaAdyacencia));
            }
        }
    }
}
