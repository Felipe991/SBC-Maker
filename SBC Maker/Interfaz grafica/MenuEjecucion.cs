﻿using SBC_Maker.Logica;
using SBC_Maker.Logica.Sistema_basado_en_conocimiento;
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

        public MenuEjecucion(SBC sbc)
        {
            InitializeComponent();
            this.motor = new MotorDeInferencia(sbc);
            //this.nodoActual = this.motor.ResolucionConflicto();
            //RefreshPanelRespuesta(this.nodoActual.Regla.Pregunta);
        }

        private void RefreshPanelRespuesta(Pregunta pregunta)
        {
            Control controlRespuesta = null;
            this.panelRespuesta.Controls.Clear();
            switch (pregunta)
            {
                case PreguntaCerrada preguntaCerrada:
                    controlRespuesta = new EjecucionRespuestaCerradaUserControl(preguntaCerrada.Alternativas);
                    break;
                case PreguntaDifusa preguntaDifusa:
                    controlRespuesta = new EjecucionRespuestaDifusaUserControl(preguntaDifusa.ConjuntoDifuso);
                    break;
            }
            this.panelRespuesta.Controls.Add(controlRespuesta);
        }

        private void buttonResponder_Click(object sender, EventArgs e)
        {
            Control controlRespuesta = this.panelRespuesta.Controls[0];
            string respuesta = getRespuesta();
            this.nodoActual.Hecho.RespuestaFinal = respuesta;
            this.nodoActual = this.motor.ChainForward(this.nodoActual);

            
            /*if (this.nodoActual != null) RefreshPanelRespuesta(nodoActual.Regla.Pregunta);
            else llamar al sgte menu*/
        }

        private string getRespuesta()
        {
            Control controlRespuesta = this.panelRespuesta.Controls[0];
            string respuesta = "";
            if (controlRespuesta is EjecucionRespuestaCerradaUserControl)
            {
                respuesta = ((EjecucionRespuestaCerradaUserControl)controlRespuesta).getRespuesta();
            }
            else if (controlRespuesta is EjecucionRespuestaDifusaUserControl)
            {
                respuesta = ((EjecucionRespuestaDifusaUserControl)controlRespuesta).getRespuesta();
            }
            return respuesta;
        }

        private void buttonTerminar_Click(object sender, EventArgs e)
        {
            //Mostrar conclusiones y explicaciones alcanzadas
        }
    }
}
