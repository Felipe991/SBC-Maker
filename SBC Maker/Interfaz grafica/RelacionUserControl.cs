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
using SBC_Maker.Logica;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class RelacionUserControl : UserControl
    {
        Nodo consecuente;
        Relacion relacionAntecedente;
        List<Nodo> listaAdyacencia;
        List<(string, (Posicion, Posicion))> flechas;
        public RelacionUserControl(Nodo consecuente,
                                   Relacion relacionAntecedente,
                                   List<Nodo> listaAdyacencia,
                                   List<(string, (Posicion, Posicion))> flechas)
        {
            InitializeComponent();
            this.consecuente = consecuente;
            this.relacionAntecedente = relacionAntecedente;
            this.listaAdyacencia = listaAdyacencia;
            this.flechas = flechas;
            
            this.labelConsecuente.Text = consecuente.Regla.Nombre;
            this.labelAntecedente.Text = relacionAntecedente.Nodo.Regla.Nombre;
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            MenuRelacion menuRelacion = new MenuRelacion(listaAdyacencia,consecuente,relacionAntecedente);
            menuRelacion.ShowDialog();
        }

        private void ConsecuenteUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
