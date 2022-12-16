using SBC_Maker.Logica;
using SBC_Maker.Logica.Sistema_basado_en_conocimiento;
using static SBC_Maker.Logica.FormListener;
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
    public partial class MenuEjecucion : Form
    {
        private MotorDeInferencia motor;
        private Nodo nodoActual;
        private bool MOSTRAREXPLICACION;
        private bool fromConfeccion = false;
        private int MAXCONCLUSIONES;

        public MenuEjecucion(SBC sbc)
        {
            InitializeComponent();
            this.motor = new MotorDeInferencia(sbc);
            this.MOSTRAREXPLICACION = sbc.ConfiguracionMotor.Explicacion;
            this.MAXCONCLUSIONES = sbc.ConfiguracionMotor.ConclusionesNecesarias;
            this.Text += " (" + sbc.Nombre + ")";
            this.nodoActual = this.motor.ResolucionConflicto();
            UpdateDatosForm();
        }

        public MenuEjecucion(SBC sbc, bool fromConfeccion)
        {
            InitializeComponent();
            this.fromConfeccion = fromConfeccion;
            this.motor = new MotorDeInferencia(sbc);
            this.MOSTRAREXPLICACION = sbc.ConfiguracionMotor.Explicacion;
            this.MAXCONCLUSIONES = sbc.ConfiguracionMotor.ConclusionesNecesarias;
            this.Text += " (" + sbc.Nombre + ")";
            this.nodoActual = this.motor.ResolucionConflicto();
            UpdateDatosForm();
        }
        private void UpdateDatosForm()
        {
            Pregunta pregunta = getPregunta();
            richTextBox1.Text = pregunta.Enunciado;
            RefreshPanelRespuesta(pregunta);
        }

        private Pregunta getPregunta()
        {
            return ((ReglaInformacion)this.nodoActual.Regla).Pregunta;
        }

        private void RefreshPanelRespuesta(Pregunta pregunta)
        {
            this.panelRespuesta.Controls.Clear();
            switch (pregunta)
            {
                case PreguntaCerrada preguntaCerrada:
                    this.panelRespuesta.Controls.Add(new EjecucionRespuestaCerradaUserControl(preguntaCerrada.Alternativas));
                    break;
                case PreguntaDifusa preguntaDifusa:
                    this.panelRespuesta.Controls.Add(new EjecucionRespuestaDifusaUserControl(preguntaDifusa.ConjuntoDifuso));
                    break;
            }
        }

        private void buttonResponder_Click(object sender, EventArgs e)
        {
            string respuesta = getRespuesta();
            this.nodoActual.Hecho.RespuestaFinal = respuesta;
            this.nodoActual = this.motor.ChainForward(this.nodoActual);

            if (motor.conclusiones.Count() < MAXCONCLUSIONES && this.nodoActual != null) UpdateDatosForm();
            else finishEjecucion();
        }

        private void finishEjecucion()
        {
            if (motor.conclusiones.Count > 0) showResolucion();
            else MessageBox.Show("No hay conclusiones", "Fin ejecución");
            if(!fromConfeccion) instanceNewForm(new MenuPrincipal());
            this.Close();
        }

        private string getRespuesta()
        {
            Control controlRespuesta = this.panelRespuesta.Controls[0];
            if (controlRespuesta is EjecucionRespuestaCerradaUserControl ERCUC) return ERCUC.getRespuesta();
            return ((EjecucionRespuestaDifusaUserControl)controlRespuesta).getRespuesta();
        }

        private void buttonTerminar_Click(object sender, EventArgs e)
        {
            finishEjecucion();
        }

        private void showResolucion()
        {
            var menuResolucion = new MenuResolucion(motor.conclusiones, MOSTRAREXPLICACION);
            menuResolucion.ShowDialog();
            this.Close();
        }
    }
}
