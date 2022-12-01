using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionTrapezoidal : FuncionPertenencia
    {
        public Double limIzquierdo;
        public Double centroIzq;
        public Double centroDer;
        public Double limDerecho;

        public FuncionTrapezoidal(Double limiteIzquierdo, Double centroIzq, Double centroDer, Double limDerecho, string nombre) : base(nombre)
        {
            this.limIzquierdo = limiteIzquierdo;
            this.centroIzq = centroIzq;
            this.centroDer = centroDer;
            this.limDerecho = limDerecho;
        }

        public FuncionTrapezoidal()
        {
            limIzquierdo = new double();
            centroIzq = new double();
            centroDer = new double();
            limDerecho = new double();
        }

        public Double LimIzquierdo { get => limIzquierdo; set => limIzquierdo = value; }
        public Double CentroIzq { get => centroIzq; set => centroIzq = value; }
        public Double CentroDer { get => centroDer; set => centroDer = value; }
        public Double LimDerecho { get => limDerecho; set => limDerecho = value; }

        public override Double CalcularPertenencia(Double x)
        {
            if (x >= centroIzq && x <= centroDer) { return 1; }
            if (x < limIzquierdo || x > limDerecho) { return 0; }
            if (x >= limIzquierdo && x <= centroIzq) { return (x - limIzquierdo) / (centroIzq - limIzquierdo); }
            else { return (limDerecho - x) / (limDerecho - centroDer); }
        }

        public override Double[] getValoresX()
        {
            List<Double> valoresX = new List<Double>();
            valoresX.Add(LimIzquierdo);
            valoresX.Add(CentroIzq);
            valoresX.Add(CentroDer);
            valoresX.Add(LimDerecho);
            return valoresX.ToArray();
        }

        public override Double[] getValoresY()
        {
            List<Double> valoresY = new List<Double>();
            valoresY.Add(isRectoIzq() ? 0 : CalcularPertenencia(LimIzquierdo));
            valoresY.Add(CalcularPertenencia(CentroIzq));
            valoresY.Add(CalcularPertenencia(CentroDer));
            valoresY.Add(isRectoDer() ? 0 : CalcularPertenencia(LimDerecho));
            return valoresY.ToArray();
        }

        public bool isRecto()
        {
            return isRectoIzq() || isRectoDer();
        }

        public bool isRectoIzq()
        {
            return limIzquierdo == centroIzq;
        }

        public bool isRectoDer()
        {
            return limDerecho == centroDer;
        }
    }
}
