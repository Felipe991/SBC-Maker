using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    internal class FuncionTriangular : FuncionPertenencia
    {
        private Double limiteIzquierdo;
        private Double centro;
        private Double limiteDerecho;

        public FuncionTriangular(Double limiteIzquierdo, Double centro, Double limiteDerecho, string nombre) : base (nombre)
        {
            this.limiteIzquierdo = limiteIzquierdo;
            this.centro = centro;
            this.limiteDerecho = limiteDerecho;
        }

        public Double LimiteIzquierdo { get => limiteIzquierdo; set => limiteIzquierdo = value; }
        public Double Centro { get => centro; set => centro = value; }
        public Double LimiteDerecho { get => limiteDerecho; set => limiteDerecho = value; }

        public override Double CalcularPertenencia(Double x)
        {
            if (x <= limiteIzquierdo || x >= limiteDerecho) { return 0; }
            if (x>limiteIzquierdo && x<=centro) { return (x-limiteIzquierdo)/(centro-limiteIzquierdo); }
            if (x >= centro && x < limiteDerecho) { return (limiteDerecho - x) / (limiteDerecho - centro); }
            return 0;
        }
        
    }
}
