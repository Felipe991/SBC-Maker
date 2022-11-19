using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    internal class FuncionTriangular : FuncionPertenencia
    {
        private float limiteIzquierdo;
        private float centro;
        private float limiteDerecho;

        public FuncionTriangular(float limiteIzquierdo, float centro, float limiteDerecho, string nombre) : base (nombre)
        {
            this.limiteIzquierdo = limiteIzquierdo;
            this.centro = centro;
            this.limiteDerecho = limiteDerecho;
        }

        public float LimiteIzquierdo { get => limiteIzquierdo; set => limiteIzquierdo = value; }
        public float Centro { get => centro; set => centro = value; }
        public float LimiteDerecho { get => limiteDerecho; set => limiteDerecho = value; }

        public override float CalcularPertenencia(float x)
        {
            if (x <= limiteIzquierdo || x >= limiteDerecho) { return 0; }
            if (x <= centro) { return (limiteDerecho - x) / (limiteDerecho - centro); }
            else { return (x - limiteIzquierdo) / (centro - limiteIzquierdo); }
        }
        
    }
}
