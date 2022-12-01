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
using static SBC_Maker.Logica.Utiles;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuRegla : Form
    {
        PreguntaCerradaUserControl pduc = new PreguntaCerradaUserControl();
        PreguntaDifusaUserControl pdifuc = new PreguntaDifusaUserControl();
        Regla regla = null;
        List<Nodo> listaAdyacencia;

        public MenuRegla(Regla regla, List<Nodo> listaadyacencia )
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pduc);
            this.regla = regla;
            this.listaAdyacencia = listaadyacencia;
        }
        public MenuRegla()
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pduc);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerifyRegla())
            {
                Regla NuevaRegla = makeRegla();
                GuardarRegla();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Uno o más campos vacíos necesarios");
            }
            
        }
        private bool VerifyRegla()
        {
            if (this.textBoxNombre.Text == "")
            {
                return false;
            }
            if (this.ConclusionButton.Checked)
            {
                if (this.textBoxIndicacion.Text == "")
                {
                    return false;
                }
            }
            else
            {
                if (this.textBoxPregunta.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
        
        private void GuardarRegla()
        {
            if (IsNewRule())
            {
                //ask if IsUnique
                //Igualo la regla a la nueva regla
            }
            else
            {
                if (this.regla.Nombre == this.textBoxNombre.Text)
                {
                    //Guarda la regla
                }
                else
                {
                    //if (IsUnique(this.regla))
                }
            }
        }

        private bool IsNewRule()
        {
            return (this.regla is null);
        }

        private Regla makeRegla()
        {
            string nombre = this.textBoxNombre.Text;
            string explicacion = this.textBoxExplicacion.Text;
            Regla regla;

            if (this.InicioButton.Checked)
            {
                regla = makeReglaInicio(nombre, explicacion);
            }
            else if (this.InformacionButton.Checked)
            {
                regla = makeReglaInformacion(nombre, explicacion);
            }
            else
            {
                regla = makeReglaConlusion(nombre, explicacion);
            }
            return regla;
        }
        private ReglaInicio makeReglaInicio(string nombre, string explicacion)
        {
            string enunciado = this.textBoxPregunta.Text;
            Pregunta pregunta;
            if (comboBoxTipoPregunta.Text == "Cerrada")
            {
                List<string> alternativas = GetAlternativas();
                pregunta = new PreguntaCerrada(alternativas, enunciado);
                
            }
            else
            {
                Object pduc = this.panelPregunta.Controls[0];
                ConjuntoDifuso conjuntoDifuso = ((PreguntaDifusaUserControl)pduc).conjuntoDifuso;
                pregunta = new PreguntaDifusa(conjuntoDifuso,enunciado);
            }
            return new ReglaInicio(nombre, explicacion, pregunta);
        }
        private ReglaInformacion makeReglaInformacion(string nombre, string explicacion)
        {
            string enunciado = this.textBoxPregunta.Text;
            Pregunta pregunta;
            if (comboBoxTipoPregunta.Text == "Cerrada")
            {
                List<string> alternativas = GetAlternativas();
                pregunta = new PreguntaCerrada(alternativas, enunciado);

            }
            else
            {
                Object pduc = this.panelPregunta.Controls[0];
                ConjuntoDifuso conjuntoDifuso = ((PreguntaDifusaUserControl)pduc).conjuntoDifuso;
                pregunta = new PreguntaDifusa(conjuntoDifuso, enunciado);
            }
            return new ReglaInformacion(nombre, explicacion, pregunta);
        }
        private List<string> GetAlternativas()
        {
            List<string> alternativas = new List<string>();
            foreach(RespusestaCerradaUserControl control in this.panelPregunta.Controls)
            {
                alternativas.Add(control.textBoxRespuesta1.Text);
            }
            return alternativas;
        }

        private ReglaConclusion makeReglaConlusion(string nombre, string explicacion)
        {
            string indicacion = this.textBoxIndicacion.Text;
            return new ReglaConclusion(nombre, explicacion, indicacion);
        }

        private void ConclusionButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = true;
            this.textBoxIndicacion.BackColor = Color.White;
            this.comboBoxTipoPregunta.Enabled = false;
            this.textBoxPregunta.Enabled = false;
            this.panelPregunta.Enabled = false;
        }

        private void InformacionButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.BackColor = Color.Silver;
            this.comboBoxTipoPregunta.Enabled = true;
            this.textBoxPregunta.Enabled = true;
            this.panelPregunta.Enabled = true;
        }

        private void InicioButton_Click(object sender, EventArgs e)
        {
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.BackColor = Color.Silver;
            this.comboBoxTipoPregunta.Enabled = true;
            this.textBoxPregunta.Enabled = true;
            this.panelPregunta.Enabled = true;
        }

        private void comboBoxTipoPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoPregunta.Text)
            {
                case ("Cerrada"):
                    this.panelPregunta.Controls.Clear();
                    this.panelPregunta.Controls.Add(pduc);
                    break;
                case ("Difusa"):
                    this.panelPregunta.Controls.Clear();
                    this.panelPregunta.Controls.Add(pdifuc);
                    break;
            }
        }

    }
}
