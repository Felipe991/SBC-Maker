using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionTrapezoidal : FuncionPertenencia
    {
        private float limIzquierdo;
        private float centroIzq;
        private float centroDer;
        private float limDerecho;

        public FuncionTrapezoidal(float a, float b, float c, float d, string nombre) : base(nombre)
        {
            this.limIzquierdo = a;
            this.centroIzq = b;
            this.centroDer = c;
            this.limDerecho = d;
        }

        public float LimIzquierdo { get => limIzquierdo; set => limIzquierdo = value; }
        public float CentroIzq { get => centroIzq; set => centroIzq = value; }
        public float CentroDer { get => centroDer; set => centroDer = value; }
        public float LimDerecho { get => limDerecho; set => limDerecho = value; }

        public override float CalcularPertenencia(float x)
        {
            if (x <= limIzquierdo || x >= limDerecho) { return 0; }
            if (x >= centroIzq && x <= centroDer) { return 1; }
            if (x >= limIzquierdo && x <= centroIzq) { return (x - limIzquierdo) / (centroIzq - limIzquierdo); }
            else { return (limDerecho - x) / (limDerecho - centroDer); }
        }
    }
}
