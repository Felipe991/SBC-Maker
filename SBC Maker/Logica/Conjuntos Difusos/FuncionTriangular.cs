using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionTriangular : FuncionPertenencia
    {
        public Double limiteIzquierdo;
        public Double centro;
        public Double limiteDerecho;

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
            if (x == centro) return 1;
            if (x <= limiteIzquierdo || x >= limiteDerecho) return 0;
            if (x>limiteIzquierdo && x<=centro) return (x-limiteIzquierdo)/(centro-limiteIzquierdo);
            if (x >= centro && x < limiteDerecho) return (limiteDerecho - x) / (limiteDerecho - centro);
            return 0;
        }

        public override Double[] getValoresX()
        {
            List<Double> valoresX = new List<Double>();
            valoresX.Add(LimiteIzquierdo);
            valoresX.Add(Centro);
            valoresX.Add(LimiteDerecho);
            return valoresX.ToArray();
        }

        public override Double[] getValoresY()
        {
            List<Double> valoresY = new List<Double>();
            valoresY.Add(isRectoIzq() ? 0 : CalcularPertenencia(LimiteIzquierdo));
            valoresY.Add(CalcularPertenencia(Centro));
            valoresY.Add(isRectoDer() ? 0 : CalcularPertenencia(LimiteDerecho));
            return valoresY.ToArray();
        }

        public bool isRecto()
        {
            return isRectoDer() | isRectoIzq();
        }

        public bool isRectoIzq()
        {
            return limiteIzquierdo == centro;
        }

        public bool isRectoDer()
        {
            return limiteDerecho == centro;
        }
    }
}
