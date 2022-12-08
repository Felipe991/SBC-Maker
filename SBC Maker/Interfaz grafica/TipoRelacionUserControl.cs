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
    public partial class TipoRelacionUserControl : UserControl
    {
        List<Nodo> listaAdyacencia = new List<Nodo>();
        List<(string, (Posicion, Posicion))> flechas;
       Nodo consecuente;
        List<Relacion> relacionesAntecedente;
        public TipoRelacionUserControl(List<Nodo> listaAdyacencia,
                                       Nodo consecuente,
                                       List<Relacion> relacionesAntecedente,
                                       List<(string, (Posicion, Posicion))> flechas)
        {
            InitializeComponent();
            this.flechas = flechas;
            this.listaAdyacencia = listaAdyacencia;
            this.consecuente = consecuente;
            this.relacionesAntecedente = relacionesAntecedente;
            this.label1.Text += relacionesAntecedente[0].NumeroRelacion;
            AddConsecuentesControl();
        }
        
        private void AddConsecuentesControl()
        {
            foreach(Relacion relacionAntecedente in relacionesAntecedente)
            {
                this.flowLayoutPanel1.Controls.Add(new RelacionUserControl(consecuente,relacionAntecedente, listaAdyacencia,flechas));
            }
        }
    }
}
