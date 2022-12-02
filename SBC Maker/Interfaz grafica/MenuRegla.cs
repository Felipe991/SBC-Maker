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
        private List<Nodo> listaAdyacencia;
        
        public MenuRegla(Regla regla, List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pduc);
            this.regla = regla;
            this.listaAdyacencia = listaadyacencia;
        }
        public MenuRegla(List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pduc);
            this.listaAdyacencia = listaadyacencia;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerifyRegla())
            {
                GuardarRegla();
                DialogResult = DialogResult.OK;
            }
        }
        private bool VerifyRegla()
        {
            string error="";
            bool flag = true;
            if (IsUnique(this.textBoxNombre.Text, listaAdyacencia))
            {
                error = "Ya existe una regla con este nombre";
                flag = false;
            }
            if (this.textBoxNombre.Text == "")
            {
                error = "El nombre de la regla no puede estar vacío";
                flag = false;
            }
            if (this.ConclusionButton.Checked && this.textBoxIndicacion.Text == "")
            {
                error = "La indicación de la conclusión no puede estar vacía";
                flag = false;
            }
            if (!this.ConclusionButton.Checked ) 
            {
                if (this.textBoxPregunta.Text == "")
                {
                    error = "La pregunta no puede estar vacía";
                    flag = false;
                }
                if(this.comboBoxTipoPregunta.Text == "Cerrada")
                {
                    if (GetAlternativas().Count < 2)
                    {
                        error = "Se necesitan al menos 2 respuestas";
                        flag = false;
                    }
                }
                else
                {
                    Object pduc = this.panelPregunta.Controls[0];
                    ConjuntoDifuso conjuntoDifuso = ((PreguntaDifusaUserControl)pduc).conjuntoDifuso;
                    if (conjuntoDifuso == null) 
                    {
                        error = "El conjunto difuso no puede estar vacío";
                        flag = false;
                    }
                }
            }
            if (flag) return true;
            MessageBox.Show(error);
            return false;
        }
        
        private void GuardarRegla()
        {
            if (this.regla is null)
            {
                AddNewRegla();
            }
            else
            {
                EditRegla();
            }
        }
        private void AddNewRegla()
        {
            this.regla = makeRegla();
            Nodo nodo = new Nodo(this.regla, new Hecho(), 0);
            listaAdyacencia.Add(nodo);
        }
        private void EditRegla()
        {
            if (this.regla.Nombre == this.textBoxNombre.Text ||
               (this.regla.Nombre != this.textBoxNombre.Text && IsUnique(this.textBoxNombre.Text, this.listaAdyacencia)))
            {
                if (WasModificated())
                {
                    if (MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (DeleteNodo(this.regla, this.listaAdyacencia)) AddNewRegla();
                        DialogResult = DialogResult.OK;
                    }
                }
                else this.regla = makeRegla();
            }
        }

        private bool WasModificated()
        {
            Pregunta pregunta;
            switch (this.regla)
            {
                case (ReglaInicio):
                    pregunta = ((ReglaInicio)this.regla).Pregunta;
                    
                    if (!this.InicioButton.Checked) return true;
                    if (!this.comboBoxTipoPregunta.Text.Equals(pregunta.GetType().ToString())) return true;
                    if (!VerifyRespuestas(pregunta)) return true;
                    break;
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.regla).Pregunta;
                    
                    if (!this.InformacionButton.Checked) return true;
                    if (!this.comboBoxTipoPregunta.Text.Equals(pregunta.GetType().ToString())) return true;
                    if (!VerifyRespuestas(pregunta)) return true;
                    break;
                case (ReglaConclusion):
                    if (!this.ConclusionButton.Checked) return true;
                    break;
            }
                
            return false;
        }
        private bool VerifyRespuestas(Pregunta pregunta)
        {
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    IEnumerable<string> diferencias = GetAlternativas().Intersect(((PreguntaCerrada)pregunta).Alternativas);
                    if (diferencias != null) return false;
                    break;
                case (PreguntaDifusa):
                    Object pduc = this.panelPregunta.Controls[0];
                    ConjuntoDifuso conjuntoDifuso = ((PreguntaDifusaUserControl)pduc).conjuntoDifuso;
                    
                    if (((PreguntaDifusa)pregunta).ConjuntoDifuso != conjuntoDifuso) return false;
                    break;
            }
            return true;
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

            foreach ( PreguntaCerradaUserControl control in this.panelPregunta.Controls)
            {
                foreach (RespusestaCerradaUserControl rcuc in control.flowLayoutPanelRespuesta.Controls)
                {
                    alternativas.Add(rcuc.textBoxRespuesta1.Text);
                }
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
