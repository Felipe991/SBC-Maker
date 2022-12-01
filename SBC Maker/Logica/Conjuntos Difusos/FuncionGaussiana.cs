using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionGaussiana : FuncionPertenencia
    {
        public Double centro;
        public Double desviacionEstandar;

        public FuncionGaussiana(Double centro,
                                Double desviacionEstandar,
                                string nombre) : base(nombre)
        {
            this.Centro = centro;
            this.DesviacionEstandar = desviacionEstandar;
        }

        public Double Centro { get => centro; set => centro = value; }
        public Double DesviacionEstandar { get => desviacionEstandar; set => desviacionEstandar = value; }

        public override Double[] getValoresX()
        {
            List<Double> valoresX = new List<Double>();
            for (Double i = Centro - (DesviacionEstandar * 7);
                i <= Centro + (DesviacionEstandar * 7);
                i += DesviacionEstandar / 3)
            {
                valoresX.Add(i);
            }
            return valoresX.ToArray();
        }

        public override Double[] getValoresY()
        {
            List<Double> valoresY = new List<Double>();
            for (Double i = Centro - (DesviacionEstandar * 7);
                        i <= Centro + (DesviacionEstandar * 7);
                        i += DesviacionEstandar / 3)
            {
                valoresY.Add(CalcularPertenencia(i));
            }
            return valoresY.ToArray();
        }

        public override Double CalcularPertenencia(Double valor)
        {
            var v1 = (valor - centro);
            var v2 = (v1 * v1) / (2 * (desviacionEstandar * desviacionEstandar));
            var v3 = Math.Exp(-v2);
            return v3;
        }
    }
}
