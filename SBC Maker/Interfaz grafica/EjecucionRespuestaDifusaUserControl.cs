using SBC_Maker.Logica;
using SBC_Maker.Logica.Conjuntos_Difusos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int factorDecimal = 0;
        public EjecucionRespuestaDifusaUserControl(ConjuntoDifuso conjuntoDifuso)
        {
            InitializeComponent();
            this.conjuntoDifuso = conjuntoDifuso;
            Double min = getMin(conjuntoDifuso.funcionesPertenencia);
            Double max = getMax(conjuntoDifuso.funcionesPertenencia);
            factorDecimal = getFactorDecimal(min) > getFactorDecimal(max) ? getFactorDecimal(min):getFactorDecimal(max);
            Debug.Print("Valor minimo de la barra:" + (int)min * factorDecimal);
            Debug.Print("Valor maximo de la barra:" + (int)max * factorDecimal);
            trackBarRespuestaDifusa.Minimum = (int)min * factorDecimal;
            trackBarRespuestaDifusa.Maximum = (int)max * factorDecimal;
            trackBarRespuestaDifusa.Value = getMiddleValue();
            refreshUnidades();
        }
        
        private double getTrackBarValueAsDouble()
        {
            return (double)trackBarRespuestaDifusa.Value/(double)factorDecimal;
        }

        private void refreshUnidades()
        {
            this.labelUnidad.Text = conjuntoDifuso.nombreUnidades + getTrackBarValueAsDouble();
        }

        private int getMiddleValue()
        {
            return (trackBarRespuestaDifusa.Maximum + trackBarRespuestaDifusa.Minimum)/2;
        }

        private Double getMax(List<FuncionPertenencia> funcionPertenencias)
        {
            Double max = Double.MinValue;
            foreach (FuncionPertenencia funcionPertenencia in funcionPertenencias)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        if (funcionTriangular.LimiteDerecho > max) max = funcionTriangular.LimiteDerecho;
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        if (funcionTrapezoidal.CentroDer > max) max = funcionTrapezoidal.CentroDer;
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        if (funcionGaussiana.centroG + funcionGaussiana.desviacionEstandar*5 > max) max = (funcionGaussiana.centroG + funcionGaussiana.desviacionEstandar * 5);
                        break;
                }
            }
            Debug.WriteLine("Valor maximo de las funciones=" + max);
            return max;
        }

        private Double getMin(List<FuncionPertenencia> funcionPertenencias)
        {
            Double min = Double.MaxValue;
            foreach (FuncionPertenencia funcionPertenencia in funcionPertenencias)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        if (funcionTriangular.LimiteIzquierdo < min) min = funcionTriangular.LimiteIzquierdo;
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        if (funcionTrapezoidal.CentroIzq < min) min = funcionTrapezoidal.CentroIzq;
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        if (funcionGaussiana.centroG - funcionGaussiana.desviacionEstandar * 5 < min) min = (funcionGaussiana.centroG - funcionGaussiana.desviacionEstandar * 5);
                        break;
                }
            }
            Debug.WriteLine("Valor minimo de las funciones="+min);
            return min;
        }
        
        private int getFactorDecimal(double valorDouble)
        {
            string[] partesDecimal = valorDouble.ToString().Split('.');
            int cantidadDecimales = 0;
            if (partesDecimal.Length != 1) cantidadDecimales = partesDecimal[1].Length;
            Debug.Print("Factor decimal de: "+valorDouble+" = "+ (int)Math.Pow(10, cantidadDecimales));
            return (int)Math.Pow(10, cantidadDecimales);
        }

        public string getRespuesta()
        {
            string respuesta = "";
            List<Double> valoresPertenencia = getValoresPertenencia(this.conjuntoDifuso);
            Double mayorPertenencia = getMayor(valoresPertenencia);
            if (mayorPertenencia == 0) return "";
            
            List<FuncionPertenencia> funcionesMayorPertenencia = getFuncionesMayorPertenencia(this.conjuntoDifuso.funcionesPertenencia,valoresPertenencia,mayorPertenencia);
            respuesta = funcionesMayorPertenencia.Count > 1 ? solveConflicts(funcionesMayorPertenencia) : funcionesMayorPertenencia[0].nombre;
            return respuesta;
        }

        private string solveConflicts(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            switch (conjuntoDifuso.MetodoResolucion)
            {
                case 0:
                    List<FuncionPertenencia> aux = solveHaciaArriba(funcionesMayorPertenencia);
                    if (aux.Count == 1) return aux[0].nombre;
                    funcionesMayorPertenencia = aux;
                    break;
                case 1:
                    List<FuncionPertenencia> aux2 = solveHaciaAbajo(funcionesMayorPertenencia);
                    if (aux2.Count == 1) return aux2[0].nombre;
                    funcionesMayorPertenencia = aux2;
                    break;
            }
            return solveCasoSensible(funcionesMayorPertenencia);
        }

        private List<FuncionPertenencia> solveHaciaAbajo(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            List<FuncionPertenencia> funcionesMenorCentro = new();
            List<double> centros = getCentros(funcionesMayorPertenencia);
            double menorCentro = getMenor(centros);

            for (int i = 0; i < funcionesMayorPertenencia.Count; i++)
            {
                if (centros[i] == menorCentro) funcionesMenorCentro.Add(funcionesMayorPertenencia[i]);
            }
            return funcionesMenorCentro;
        }

        private double getMenor(List<double> centros)
        {
            Double menorValor = Double.MaxValue;
            foreach (Double valorPertenencia in centros)
            {
                menorValor = menorValor > valorPertenencia ? valorPertenencia : menorValor;
            }
            return menorValor;
        }

        private List<FuncionPertenencia> solveHaciaArriba(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            List<FuncionPertenencia> funcionesMayorCentro = new();
            List<double> centros = getCentros(funcionesMayorPertenencia);
            double mayorCentro = getMayor(centros);

            for (int i = 0; i < funcionesMayorPertenencia.Count; i++)
            {
                if (centros[i] == mayorCentro) funcionesMayorCentro.Add(funcionesMayorPertenencia[i]);
            }
            return funcionesMayorCentro;
        }

        private List<double> getCentros(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            List<double> centros = new();
            foreach (FuncionPertenencia funcionPertenencia in funcionesMayorPertenencia)
            {
                centros.Add(getCentroFuncPertenencia(funcionPertenencia));
            }
            return centros;
        }

        private double getCentroFuncPertenencia(FuncionPertenencia funcionPertenencia)
        {
            double centro = 0;
            switch (funcionPertenencia)
            {
                case FuncionTriangular funcionTriangular:
                    centro = funcionTriangular.centro;
                    break;
                case FuncionTrapezoidal funcionTrapezoidal:
                    centro = (funcionTrapezoidal.limDerecho + funcionTrapezoidal.limIzquierdo) / 2;
                    break;
                case FuncionGaussiana funcionGaussiana:
                    centro = funcionGaussiana.centroG;
                    break;
            }
            return centro;
        }

        private string solveCasoSensible(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            var menuResolucion = new MenuResolucionCasoSensible(getEtiquetas(funcionesMayorPertenencia));
            if (menuResolucion.ShowDialog() == DialogResult.OK) return menuResolucion.getRespuesta();
            return null;
        }

        private List<string> getEtiquetas(List<FuncionPertenencia> funcionesMayorPertenencia)
        {
            List<string> etiquetasFunciones = new();
            foreach (FuncionPertenencia funcionPertenencia in funcionesMayorPertenencia)
            {
                etiquetasFunciones.Add(funcionPertenencia.nombre);
            }
            return etiquetasFunciones;
        }

        private List<FuncionPertenencia> getFuncionesMayorPertenencia(List<FuncionPertenencia> funcionesPertenencia, List<double> valoresPertenencia, double mayorPertenencia)
        {
            List<FuncionPertenencia> funcionesMayorPertenencia= new();
            foreach (Double valorPertenencia in valoresPertenencia)
            {
                if (valorPertenencia == mayorPertenencia)
                {
                    funcionesMayorPertenencia.Add(funcionesPertenencia[valoresPertenencia.IndexOf(valorPertenencia)]);
                }
            }
            return funcionesMayorPertenencia;
        }

        private double getMayor(List<double> valores)
        {
            Double mayorValor = Double.MinValue;
            foreach(Double valorPertenencia in valores)
            {
                mayorValor = mayorValor < valorPertenencia ? valorPertenencia : mayorValor;
            }
            return mayorValor;
        }

        private List<double> getValoresPertenencia(ConjuntoDifuso conjuntoDifuso)
        {
            List<Double> valoresPertenencia = new();
            foreach (FuncionPertenencia funcionPertenencia in conjuntoDifuso.funcionesPertenencia)
            {
                switch (funcionPertenencia)
                {
                    case FuncionTriangular funcionTriangular:
                        valoresPertenencia.Add(funcionTriangular.CalcularPertenencia(getTrackBarValueAsDouble()));
                        break;
                    case FuncionTrapezoidal funcionTrapezoidal:
                        valoresPertenencia.Add(funcionTrapezoidal.CalcularPertenencia(getTrackBarValueAsDouble()));
                        break;
                    case FuncionGaussiana funcionGaussiana:
                        valoresPertenencia.Add(funcionGaussiana.CalcularPertenencia(getTrackBarValueAsDouble()));
                        break;
                }
            }
            return valoresPertenencia;
        }

        private void trackBarRespuestaDifusa_Scroll(object sender, EventArgs e)
        {
            refreshUnidades();
        }
    }
}
