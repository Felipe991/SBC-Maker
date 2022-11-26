using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionGaussiana : FuncionPertenencia
    {
        private Double media;
        private Double desviacionEstandar;

        public FuncionGaussiana(Double media, Double desviacionEstandar, string nombre) : base(nombre)
        {
            this.Media = media;
            this.DesviacionEstandar = desviacionEstandar;
        }

        public Double Media { get => media; set => media = value; }
        public Double DesviacionEstandar { get => desviacionEstandar; set => desviacionEstandar = value; }

        public override Double CalcularPertenencia(Double valor)
        {
            return (Double)(Math.Exp(-Math.Pow(valor - Media, 2) / (2 * Math.Pow(DesviacionEstandar, 2))));
        }
    }
}
