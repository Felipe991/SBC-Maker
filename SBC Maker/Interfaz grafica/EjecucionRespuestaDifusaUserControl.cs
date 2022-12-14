using SBC_Maker.Logica;
using SBC_Maker.Logica.Conjuntos_Difusos;
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
    public partial class EjecucionRespuestaDifusaUserControl : UserControl
    {
        private ConjuntoDifuso conjuntoDifuso;
        public EjecucionRespuestaDifusaUserControl(ConjuntoDifuso conjuntoDifuso)
        {
            InitializeComponent();
            this.conjuntoDifuso = conjuntoDifuso;
            this.trackBarRespuestaDifusa.Minimum = getMin(conjuntoDifuso);
            this.trackBarRespuestaDifusa.Maximum = getMax(conjuntoDifuso);
            //trackbar funciona con enteros, trabajamos con doubles, hay que ver que hacer
            this.labelUnidad.Text = conjuntoDifuso.nombreUnidades;
        }

        private int getMax(ConjuntoDifuso conjuntoDifuso)
        {
            int max = int.MinValue;
            foreach (FuncionPertenencia funcionPertenencia in conjuntoDifuso.funcionesPertenencia)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        if (funcionTriangular.LimiteDerecho > max) max = (int)funcionTriangular.LimiteDerecho;
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        if (funcionTrapezoidal.CentroDer > max) max = (int)funcionTrapezoidal.CentroDer;
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        if (funcionGaussiana.centroG + funcionGaussiana.desviacionEstandar*5 > max) max = (int)(funcionGaussiana.centroG + funcionGaussiana.desviacionEstandar * 5);
                        break;
                }
            }
            return max;
        }
        
        public string getRespuesta()
        {
            string respuesta = "";
            List<Double> valoresPertenencia = getValoresPertenencia(this.conjuntoDifuso);
            //Revisar colisiones (igual valor de pertenencia)
            //En caso de colisiones solucionar con metodo... (ver que pasa con hacia abajo y hacia arriba...)
            //En caso de tener resolucion por caso sensible, abrir dialog para que se decida por alguno
            //mostrando solamente las opciones linguisticas con un groupbutton
            //En caso de no colisiones, devolver nombre funcion pertenencia con mayor pertenencia.
            return respuesta;
        }


        //ARREGLAR PORQUE TRACKBAR SOLO ENTREGA VALORES ENTEROS. HAY QUE HACER UNA CONVERSION
        private List<double> getValoresPertenencia(ConjuntoDifuso conjuntoDifuso)
        {
            List<Double> valoresPertenencia = new();
            foreach (FuncionPertenencia funcionPertenencia in conjuntoDifuso.funcionesPertenencia)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        valoresPertenencia.Add(funcionTriangular.CalcularPertenencia(this.trackBarRespuestaDifusa.Value));
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        valoresPertenencia.Add(funcionTrapezoidal.CalcularPertenencia(this.trackBarRespuestaDifusa.Value));
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        valoresPertenencia.Add(funcionGaussiana.CalcularPertenencia(this.trackBarRespuestaDifusa.Value));
                        break;
                }
            }
            return valoresPertenencia;
        }

        private int getMin(ConjuntoDifuso conjuntoDifuso)
        {
            int min = int.MaxValue;
            foreach (FuncionPertenencia funcionPertenencia in conjuntoDifuso.funcionesPertenencia)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        if (funcionTriangular.LimiteIzquierdo < min) min = (int)funcionTriangular.LimiteIzquierdo;
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        if (funcionTrapezoidal.CentroIzq < min) min = (int)funcionTrapezoidal.CentroIzq;
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        if (funcionGaussiana.centroG - funcionGaussiana.desviacionEstandar * 5 < min) min = (int)(funcionGaussiana.centroG - funcionGaussiana.desviacionEstandar * 5);
                        break;
                }
            }
            return min;
        }
    }
}
