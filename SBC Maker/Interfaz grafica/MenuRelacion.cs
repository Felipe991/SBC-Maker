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

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuRelacion : Form
    {
        List<Nodo> listaadyacencia;
        public Nodo antecedente;
        public Nodo consecuente;
        int numeroRelacion = 0;

        public MenuRelacion(List<Nodo>listaadyacencia)
        {
            InitializeComponent();
            this.listaadyacencia = listaadyacencia;
            InitializeAntecedentes();
        }

        public MenuRelacion(List<Nodo>listaadyacencia,Nodo nodoAntecedente)
        {
            InitializeComponent();
            antecedente = nodoAntecedente;
            this.listaadyacencia = listaadyacencia;
            comboBoxAntecedente.Enabled = false;
            InitializeConsecuentes();
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
            if (VerifyRelacion())
            {
                GuardarRelacion();
                DialogResult = DialogResult.OK;
            }
        }
        private bool VerifyRelacion()
        {
            string error="";
            bool flag = true;

            if (this.consecuente == null)
            {
                MessageBox.Show("Seleccione un consecuente");
                return false;
            }
            if (!VerifyCycle(this.antecedente,this.consecuente))
            {
                error = "No se permiten ciclos";
                flag = false;
            }  
            if (!VerifyRespuestas())
            {
                error = "Seleccione al menos una respuesta";
                flag = false;
            }
            if (this.numeroRelacion > this.consecuente.Antecedentes.Count())
            {
                if (!VerifyRedundancy(this.antecedente, this.consecuente))
                {
                    error = "Relacion Redundante";
                    flag = false;
                }
            }
            else
            {
                if (!VerifyRedundancy(this.antecedente, this.consecuente, this.numeroRelacion))
                {
                    error = "Relacion Redundante";
                    flag = false;
                }
            }

            if (flag) return true;
            MessageBox.Show(error);
            return false;
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
        private void GuardarRelacion()
        {
            AsignarNivel(this.antecedente,this.consecuente);
            List<string> respuestsNecesarias = GetRespuestas();
            Relacion relacion = new Relacion(antecedente,this.textBoxExplicacion.Text);
            relacion.RespuestasNecesarias = GetRespuestas();

            if (this.numeroRelacion > this.consecuente.Antecedentes.Count())
            {
                List<Relacion> listaRelacion = new List<Relacion>();
                listaRelacion.Add(relacion);
                this.consecuente.Antecedentes.Add(listaRelacion);
            }
            else
            {
                this.consecuente.Antecedentes[this.numeroRelacion - 1].Add(relacion);
            }
            if (!this.antecedente.Consecuentes.Contains(relacion)) this.antecedente.Consecuentes.Add(relacion);
        }
        
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
                            respuestasNecesarias.Add(checkedListBoxRespuestaDifusa.GetItemText(i));
                        }
                    }
                    break;
            }
            return respuestasNecesarias;
        }

    }
}
