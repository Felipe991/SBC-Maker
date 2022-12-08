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
    public partial class ConsecuenteUserControl : UserControl
    {
        Nodo antecedente;
        Relacion relacionAntecedente;
        List<Nodo> listaAdyacencia;
        int numeroRelacion;
        public ConsecuenteUserControl(Nodo antecedente, Relacion relacionAntecedente, List<Nodo> listaAdyacencia, int numeroRelacion)
        {
            InitializeComponent();
            this.antecedente = antecedente;
            this.relacionAntecedente = relacionAntecedente;
            this.listaAdyacencia = listaAdyacencia;
            this.numeroRelacion = numeroRelacion;
            
            this.labelAntecedente.Text = antecedente.Regla.Nombre;
            this.labelConsecuente.Text = relacionAntecedente.Nodo.Regla.Nombre;
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            //Las relaciones a mostrar son Antecedente -> Consecuente o al revés??
            //MenuRelacion menuRelacion = new MenuRelacion(listaAdyacencia,, relacionAntecedente);
        }
    }
}
