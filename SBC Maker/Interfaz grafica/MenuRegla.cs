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
        PreguntaCerradaUserControl pcuc = new PreguntaCerradaUserControl();
        PreguntaDifusaUserControl pdifuc = new PreguntaDifusaUserControl();
        Regla regla = null;
        public Nodo nodo;
        public List<Nodo> listaAdyacencia;

        public MenuRegla(List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pcuc);
            this.listaAdyacencia = listaadyacencia;
        }
        public MenuRegla(Nodo nodo, List<Nodo> listaadyacencia)
        {
            InitializeComponent();
            this.panelPregunta.Controls.Add(pcuc);
            this.nodo = nodo;
            this.regla = nodo.Regla;
            this.listaAdyacencia = listaadyacencia;
            LoadRegla();
        }
        private void LoadRegla()
        {
            this.textBoxNombre.Text = regla.Nombre;
            this.textBoxExplicacion.Text = regla.Explicacion;
            Pregunta pregunta;
            switch (this.regla)
            {
                case (ReglaInicio):
                    pregunta = ((ReglaInicio)this.regla).Pregunta;
                    
                    this.InicioButton.Checked = true;
                    this.comboBoxTipoPregunta.Text = "Inicio";
                    LoadRespuestas(pregunta);
                    break;
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.regla).Pregunta;
                    
                    this.InformacionButton.Checked = true;
                    this.comboBoxTipoPregunta.Text = "Informacion";
                    LoadRespuestas(pregunta);
                    break;
                case (ReglaConclusion):
                    this.ConclusionButton.Checked = true;
                    this.textBoxIndicacion.Text = ((ReglaConclusion)this.regla).Indicacion;
                    break;
            }
        }
        private void LoadRespuestas(Pregunta pregunta)
        {
            this.textBoxPregunta.Text = pregunta.Enunciado;
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    this.comboBoxTipoPregunta.SelectedIndex = 0;
                    List<string> respuestas = ((PreguntaCerrada)pregunta).Alternativas;
                    int indice = 1;
                    
                    foreach (string respuesta in respuestas)
                    {
                        RespusestaCerradaUserControl rcuc = new RespusestaCerradaUserControl(this.pcuc.flowLayoutPanelRespuesta, indice);
                        rcuc.textBoxRespuesta1.Text = respuesta;
                        this.pcuc.flowLayoutPanelRespuesta.Controls.Add(rcuc);
                        indice++;
                    }
                    break;
                case (PreguntaDifusa):
                    this.comboBoxTipoPregunta.SelectedIndex = 1;
                    pdifuc.conjuntoDifuso = ((PreguntaDifusa)pregunta).ConjuntoDifuso;
                    pdifuc.textBoxRuta.Text = pdifuc.conjuntoDifuso.Nombre;
                    break;
            }
        }
        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerifyRegla())
            {
                if (GuardarRegla()) DialogResult = DialogResult.OK;
            }
        }
        private bool VerifyRegla()
        {
            string error="";
            bool flag = true;
            if(this.regla == null)
            {
                if (!IsUnique(this.textBoxNombre.Text, listaAdyacencia))
                {
                    error = "Ya existe una regla con este nombre";
                    flag = false;
                }
            }
            else
            {
                if (this.regla.Nombre != this.textBoxNombre.Text)
                {
                    if (!IsUnique(this.textBoxNombre.Text, listaAdyacencia))
                    {
                        error = "Ya existe una regla con este nombre";
                        flag = false;
                    }
                }
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
                    if (!VerifyRespuestas())
                    {
                        error = "Las respuestas no pueden ser iguales";
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
        private bool VerifyRespuestas()
        {
            for (int i = 0; i < this.pcuc.flowLayoutPanelRespuesta.Controls.Count; i++)
            {
                for (int j = i + 1; j < this.pcuc.flowLayoutPanelRespuesta.Controls.Count; j++)
                {
                    if (((RespusestaCerradaUserControl)this.pcuc.flowLayoutPanelRespuesta.Controls[i]).textBoxRespuesta1.Text
                        == ((RespusestaCerradaUserControl)this.pcuc.flowLayoutPanelRespuesta.Controls[j]).textBoxRespuesta1.Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        private bool GuardarRegla()
        {
            if (this.regla is null)
            {
                return AddNewNodo();
            }
            else
            {
                return EditRegla();
            }
        }
        private bool AddNewNodo()
        {
            this.regla = makeRegla();
            this.nodo = new Nodo(this.regla, new Hecho(), 0);
            listaAdyacencia.Add(this.nodo);
            return true;
        }
        private bool EditRegla()
        {
            if (WasModificated())
            {
                if (MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (DeleteNodo(this.nodo, this.listaAdyacencia)) AddNewNodo();
                }
                else
                {
                    return false;
                }
            }
            else this.nodo.Regla = makeRegla();
            return true;
        }
        private bool WasModificated()
        {
            Pregunta pregunta;
            switch (this.regla)
            {
                case (ReglaInicio):
                    pregunta = ((ReglaInicio)this.regla).Pregunta;
                    
                    if (!this.InicioButton.Checked) return true;
                    if (!SameRespuestas(pregunta)) return true;
                    break;
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.regla).Pregunta;
                    
                    if (!this.InformacionButton.Checked) return true;
                    if (!SameRespuestas(pregunta)) return true;
                    break;
                case (ReglaConclusion):
                    if (!this.ConclusionButton.Checked) return true;
                    break;
            }
                
            return false;
        }
        private bool SameRespuestas(Pregunta pregunta)
        {
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    if (!this.comboBoxTipoPregunta.Text.Equals("Cerrada")) return false;
                    bool sonIguales = GetAlternativas().SequenceEqual(((PreguntaCerrada)pregunta).Alternativas);
                    if (!sonIguales) return false;
                    
                    break;
                case (PreguntaDifusa):
                    if (!this.comboBoxTipoPregunta.Text.Equals("Difusa")) return false;
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
                    this.panelPregunta.Controls.Add(pcuc);
                    break;
                case ("Difusa"):
                    this.panelPregunta.Controls.Clear();
                    this.panelPregunta.Controls.Add(pdifuc);
                    break;
            }
        }

    }
}
