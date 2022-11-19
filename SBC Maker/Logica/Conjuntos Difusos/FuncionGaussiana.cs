using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica.Conjuntos_Difusos
{
    public class FuncionGaussiana : FuncionPertenencia
    {
        private float media;
        private float desviacionEstandar;

        public FuncionGaussiana(float media, float desviacionEstandar, string nombre) : base(nombre)
        {
            this.Media = media;
            this.DesviacionEstandar = desviacionEstandar;
        }

        public float Media { get => media; set => media = value; }
        public float DesviacionEstandar { get => desviacionEstandar; set => desviacionEstandar = value; }

        public override float CalcularPertenencia(float valor)
        {
            return (float)(Math.Exp(-Math.Pow(valor - Media, 2) / (2 * Math.Pow(DesviacionEstandar, 2))));
        }
    }
}
