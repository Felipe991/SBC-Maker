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
        public List<(Nodo, Nodo, Relacion)> relacionesEliminadas = new List<(Nodo, Nodo, Relacion)>();
        public MenuEditarRelaciones(Nodo nodo,List<Nodo> listaAdyacencia)
        {
            InitializeComponent();
            nodoActual = nodo;
            this.listaAdyacencia = listaAdyacencia;
            InitializeRelaciones();
        }

        private void InitializeRelaciones()
        {
            foreach(List<Relacion> TipoRelacion in nodoActual.Antecedentes)
            {
                this.flowLayoutPanel1.Controls.Add(new TipoRelacionUserControl(listaAdyacencia, nodoActual,TipoRelacion,relacionesEliminadas));
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
