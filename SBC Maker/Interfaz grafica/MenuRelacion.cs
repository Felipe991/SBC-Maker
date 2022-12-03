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
    public partial class MenuRelacion : Form
    {
        List<Nodo> listaadyacencia;
        Nodo antecedente;
        Nodo consecuente;
        
        public MenuRelacion(List<Nodo>listaadyacencia)
        {
            InitializeComponent();
            this.listaadyacencia = listaadyacencia;
            InitializeAntecedentes();
        }
        private void InitializeAntecedentes(){
            foreach (Nodo nodo in listaadyacencia)
            {
                if(nodo.Regla.GetType() != typeof(ReglaConclusion))
                {
                    this.comboBoxAntecedente.Items.Add(nodo.Regla.Nombre);
                }
            }
            if (this.comboBoxAntecedente.Items.Count > 0)
            {
                this.comboBoxAntecedente.SelectedIndex = 0;
                this.comboBoxAntecedente.Enabled = true;
                this.comboBoxAntecedente.BackColor = Color.White;
            }
        }
        private void comboBoxAntecedente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRegla = this.comboBoxAntecedente.SelectedItem.ToString();
            this.antecedente = this.listaadyacencia.Find(n => n.Regla.Nombre == nombreRegla);
            InitializeConsecuentes();
        }
        private void InitializeConsecuentes()
        {
            this.comboBoxConsecuente.Items.Clear();

            foreach (Nodo nodo in listaadyacencia)
            {
                if (!nodo.Equals(this.antecedente) && nodo.Regla.GetType() != typeof(ReglaInicio))
                {
                    this.comboBoxConsecuente.Items.Add(nodo.Regla.Nombre);
                }
            }
            if (this.comboBoxConsecuente.Items.Count > 0)
            {
                this.comboBoxConsecuente.Enabled = true;
                this.comboBoxConsecuente.BackColor = Color.White;
                this.comboBoxConsecuente.SelectedIndex = 0;
            }
        }
        private void comboBoxConsecuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRegla = this.comboBoxConsecuente.SelectedItem.ToString();
            this.consecuente = this.listaadyacencia.Find(n => n.Regla.Nombre == nombreRegla);
            IntitializeNRelacion();
            //Instanciar Respuestas y hacer visible la wea
        }
        private void InitializeRespuestas()
        {
            //Pregunta pregunta = this.antecedente.Regla.Pregunta;
        }
        
        private void IntitializeNRelacion()
        {
            this.comboBoxNRelacion.Items.Clear();
            int indiceMaximo = this.consecuente.Antecedentes.Count() + 1;
            for (int i = 0; i < indiceMaximo; i++)
            {
                this.comboBoxNRelacion.Items.Add(i + 1);
            }
            this.comboBoxNRelacion.Enabled = true;
            this.comboBoxNRelacion.BackColor = Color.White;
            this.comboBoxNRelacion.SelectedIndex = 0;
        }

        private void comboBoxNRelacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
