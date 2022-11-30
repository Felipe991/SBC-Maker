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

        public Double LimIzquierdo { get => limIzquierdo; set => limIzquierdo = value; }
        public Double CentroIzq { get => centroIzq; set => centroIzq = value; }
        public Double CentroDer { get => centroDer; set => centroDer = value; }
        public Double LimDerecho { get => limDerecho; set => limDerecho = value; }

        public override Double CalcularPertenencia(Double x)
        {
            if (x <= limIzquierdo || x >= limDerecho) { return 0; }
            if (x >= centroIzq && x <= centroDer) { return 1; }
            if (x >= limIzquierdo && x <= centroIzq) { return (x - limIzquierdo) / (centroIzq - limIzquierdo); }
            else { return (limDerecho - x) / (limDerecho - centroDer); }
        }
    }
}
