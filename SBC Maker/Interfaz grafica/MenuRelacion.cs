using SBC_Maker.Logica;
using static SBC_Maker.Logica.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuRelacion : Form
    {
        List<Nodo> listaadyacencia;
        public Nodo antecedente;
        public Nodo consecuente;
        int numeroRelacion = 0;
        Relacion relacionAntecedente = null;

        public MenuRelacion(List<Nodo>listaadyacencia)
        {
            InitializeComponent();
            this.listaadyacencia = listaadyacencia;
            InitializeAntecedentes();
        }

        public MenuRelacion(List<Nodo>listaadyacencia, Nodo consecuente,Relacion relacionAntecedente)
        {
            InitializeComponent();
            this.antecedente = relacionAntecedente.Nodo;
            this.consecuente = consecuente;
            this.listaadyacencia = listaadyacencia;
            this.numeroRelacion = relacionAntecedente.NumeroRelacion;
            this.relacionAntecedente = relacionAntecedente;
            this.textBoxExplicacion.Text = relacionAntecedente.Explicacion;

            comboBoxConsecuente.Enabled = false;
            comboBoxAntecedente.Enabled = false;
            this.groupBoxRespuestaCerrada.Enabled = false;
            this.comboBoxNRelacion.Enabled = false;
            this.checkedListBoxRespuestaDifusa.Enabled = false;
            InitializeAntecedentes();
            InitializeComponentsValues();
            LoadRespuestas();
        }

        private void InitializeComponentsValues()
        {
            this.comboBoxAntecedente.SelectedItem = this.antecedente.Regla.Nombre;
            this.comboBoxConsecuente.SelectedItem = this.consecuente.Regla.Nombre;
            this.comboBoxNRelacion.SelectedItem = this.numeroRelacion;

            this.comboBoxAntecedente.Enabled = false;
            this.comboBoxConsecuente.Enabled = false;
            this.comboBoxNRelacion.Enabled = false;
        }

        private void LoadRespuestas()
        {
            Pregunta pregunta = null;
            switch (this.antecedente.Regla)
            {
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.antecedente.Regla).Pregunta;
                    break;
            }
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    LoadRespuestaCerrada((PreguntaCerrada)pregunta);
                    break;
                case (PreguntaDifusa):
                    LoadRespuestaDifusa((PreguntaDifusa)pregunta);
                    break;
            }
        }
        private void LoadRespuestaCerrada(PreguntaCerrada pregunta)
        {
            this.groupBoxRespuestaCerrada.Controls.Clear();
            this.checkedListBoxRespuestaDifusa.Visible = false;
            this.groupBoxRespuestaCerrada.Visible = true;

            int i = 0;
            foreach (string respuesta in pregunta.Alternativas)
            {
                RadioButton radioButton = new RadioButton()
                {
                    Text = respuesta,
                    AutoSize = true,
                    Location = new Point(10, 10 + 20 * i),
                    Width = (TextRenderer.MeasureText(respuesta, Font)).Width + 20
                };
                if (this.relacionAntecedente.RespuestasNecesarias[0]==radioButton.Text) radioButton.Checked = true;
                this.groupBoxRespuestaCerrada.Controls.Add(radioButton);
                i++;
            }
        }
        private void LoadRespuestaDifusa(PreguntaDifusa pregunta)
        {
            this.checkedListBoxRespuestaDifusa.Items.Clear();
            this.checkedListBoxRespuestaDifusa.Visible = true;
            this.groupBoxRespuestaCerrada.Visible = false;
            
            foreach (FuncionPertenencia funcionPertenencia in pregunta.ConjuntoDifuso.funcionesPertenencia)
            {
                this.checkedListBoxRespuestaDifusa.Items.Add(funcionPertenencia.Nombre);
                if (this.relacionAntecedente.RespuestasNecesarias.Contains(funcionPertenencia.Nombre))
                {
                    int i =  this.checkedListBoxRespuestaDifusa.Items.IndexOf(funcionPertenencia.Nombre);
                    this.checkedListBoxRespuestaDifusa.SetItemChecked(i, true);
                }
            }
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
            if (this.comboBoxConsecuente.Items.Count > 0)
            {
                this.comboBoxConsecuente.Enabled = true;
                this.comboBoxConsecuente.BackColor = Color.White;
                this.comboBoxConsecuente.SelectedIndex = 0;
            }
            else
            {
                this.comboBoxConsecuente.Enabled = false;
                this.comboBoxConsecuente.BackColor = Color.LightGray;
                this.consecuente = null;
                this.checkedListBoxRespuestaDifusa.Visible = false;
                this.groupBoxRespuestaCerrada.Visible = false;
                this.comboBoxNRelacion.Enabled = false;
            }
        }
        private void InitializeConsecuentes()
        {
            this.comboBoxConsecuente.Items.Clear();

            foreach (Nodo nodo in listaadyacencia)
            {
                if (!nodo.Equals(this.antecedente))
                {
                    switch (nodo.Regla)
                    {
                        case (ReglaInformacion):
                            bool isInicio = ((ReglaInformacion)nodo.Regla).ReglaInicio;
                            if (!isInicio) this.comboBoxConsecuente.Items.Add(nodo.Regla.Nombre);
                            break;
                        case (ReglaConclusion):
                            this.comboBoxConsecuente.Items.Add(nodo.Regla.Nombre);
                            break;
                    }
                }
            }
        }
        private void comboBoxConsecuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreRegla = this.comboBoxConsecuente.SelectedItem.ToString();
            this.consecuente = this.listaadyacencia.Find(n => n.Regla.Nombre == nombreRegla);
            IntitializeNRelacion();
            InitializeRespuestas();
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
        private void InitializeRespuestas()
        {
            Pregunta pregunta = null;
            switch (this.antecedente.Regla)
            {
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.antecedente.Regla).Pregunta;
                    break;                   
            }
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    InitializeRespuestaCerrada((PreguntaCerrada)pregunta);
                    break;
                case (PreguntaDifusa):
                    InitializeRespuestaDifusa((PreguntaDifusa)pregunta);
                    break;
            }
        }
        private void InitializeRespuestaCerrada(PreguntaCerrada pregunta)
        {
            this.groupBoxRespuestaCerrada.Controls.Clear();
            this.checkedListBoxRespuestaDifusa.Visible = false;
            this.groupBoxRespuestaCerrada.Visible = true;

            int i = 0;
            foreach (string respuesta in pregunta.Alternativas)
            {
                RadioButton radioButton = new RadioButton()
                {
                    Text = respuesta,
                    AutoSize = true,
                    Location = new Point(10, 10 + 20 * i),
                };
                if (i == 0) radioButton.Checked = true;
                this.groupBoxRespuestaCerrada.Controls.Add(radioButton);
                i++;
            }
        }
        private void InitializeRespuestaDifusa(PreguntaDifusa pregunta)
        {
            this.checkedListBoxRespuestaDifusa.Items.Clear();
            this.checkedListBoxRespuestaDifusa.Visible = true;
            this.groupBoxRespuestaCerrada.Visible = false;

            foreach (FuncionPertenencia funcionPertenencia in pregunta.ConjuntoDifuso.funcionesPertenencia)
            {
                this.checkedListBoxRespuestaDifusa.Items.Add(funcionPertenencia.Nombre);
            }
        }
        private void comboBoxNRelacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numeroRelacion = (int)comboBoxNRelacion.SelectedItem;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(this.relacionAntecedente != null)
            {
                EditRelacion();
                DialogResult = DialogResult.OK;
            }
            else if (VerifyRelacion())
            {
                if (AddRelacion()) DialogResult = DialogResult.OK;
            }
        }
        private bool VerifyRelacion()
        {
            string error = "";
            
            if (this.consecuente == null)
            {
                error = "Seleccione un consecuente";
            }
            else
            {
                error = VerifyLogic();
            }

            if (error == "") return true;
            MessageBox.Show(error);
            return false;
        }
        private string VerifyLogic()
        {
            Relacion relacion = new Relacion(this.antecedente, this.numeroRelacion, this.textBoxExplicacion.Text);
            relacion.RespuestasNecesarias = GetRespuestas();
            string error = "";
            if (!VerifyCycle(this.antecedente, this.consecuente)) error = "No se permiten ciclos";
            else
            {
                if (!VerifyRespuestas()) error = "Seleccione al menos una respuesta";
                else
                {
                    if (this.numeroRelacion > this.consecuente.Antecedentes.Count())
                    {
                        if (!VerifyNewRelacion(this.antecedente, this.consecuente, relacion)) error = "Nueva relación redundante";
                        else if (!VerifyInalcanzableNew(this.antecedente, this.consecuente, relacion)) error = "Regla inalcanzable";
                    }
                    else
                    {
                        if (!VerifyExistentRelacion(this.antecedente, this.consecuente, relacion)) error = "Relacion Redundante";
                        else if (!VerifyInalcanzable(this.antecedente, this.consecuente, relacion)) error = "Regla inalcanzable";
                    }
                }
            }
            
            return error;
        }
        private bool VerifyRespuestas()
        {
            Pregunta pregunta = null;
            switch (this.antecedente.Regla)
            {
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.antecedente.Regla).Pregunta;
                    break;
            }
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    return true;
                case (PreguntaDifusa):
                    int max = checkedListBoxRespuestaDifusa.Items.Count;
                    for (int i = 0; i < max; i++)
                    {
                        if (checkedListBoxRespuestaDifusa.GetItemChecked(i)) return true;
                    }
                    return false;
            }
            return false;
        }
        private bool AddRelacion()
        {
            this.relacionAntecedente = new Relacion(this.antecedente, this.numeroRelacion, this.textBoxExplicacion.Text);
            this.relacionAntecedente = new Relacion(antecedente, this.numeroRelacion, this.textBoxExplicacion.Text);
            relacionAntecedente.RespuestasNecesarias = GetRespuestas();

            if (this.numeroRelacion > this.consecuente.Antecedentes.Count())
            {
                List<Relacion> listaRelacion = new List<Relacion>();
                listaRelacion.Add(relacionAntecedente);
                this.consecuente.Antecedentes.Add(listaRelacion);
            }
            else
            {
                this.consecuente.Antecedentes[this.numeroRelacion - 1].Add(relacionAntecedente);
            }

            if (!this.antecedente.Consecuentes.Contains(this.consecuente)) this.antecedente.Consecuentes.Add(this.consecuente);
            return true;
        }
        private void EditRelacion()
        {
            this.relacionAntecedente.Explicacion = this.textBoxExplicacion.Text;
        }
        /*private bool WasModificated()
        {
            if (this.relacionAntecedente.Nodo.Regla.Nombre != this.comboBoxConsecuente.SelectedItem.ToString()) return true;
            if (this.antecedente.Regla.Nombre != this.comboBoxAntecedente.SelectedItem.ToString()) return true;
            if (this.relacionAntecedente.NumeroRelacion != this.numeroRelacion) return true;
            return false;
        } */
        private List<string> GetRespuestas()
        {
            List<string>  respuestasNecesarias = new List<string>();
            Pregunta pregunta = null;
            switch (this.antecedente.Regla)
            {
                case (ReglaInformacion):
                    pregunta = ((ReglaInformacion)this.antecedente.Regla).Pregunta;
                    break;
            }
            switch (pregunta)
            {
                case (PreguntaCerrada):
                    foreach(RadioButton radioButton in groupBoxRespuestaCerrada.Controls)
                    {
                        if (radioButton.Checked) respuestasNecesarias.Add(radioButton.Text);
                    }
                    break;
                case (PreguntaDifusa):
                    int max = checkedListBoxRespuestaDifusa.Items.Count;
                    for (int i = 0; i < max; i++)
                    {
                        if (checkedListBoxRespuestaDifusa.GetItemChecked(i))
                        {
                            respuestasNecesarias.Add(checkedListBoxRespuestaDifusa.Items[i].ToString());
                        }
                    }
                    break;
            }
            return respuestasNecesarias;
        }

    }
}
