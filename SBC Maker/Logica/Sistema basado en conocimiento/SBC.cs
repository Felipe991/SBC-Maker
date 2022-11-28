using SBC_Maker.Logica.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class SBC
    {
        private string nombre;
        private VerificadorReglas verificadorReglas;
        private Archiver archiver;
        private BaseDeConocimiento baseConocimientos;
        private ConfiguracionGrafica configuracionGrafica;
        private ConfiguracionMotor configuracionMotor;

        public SBC(string nombre,
                   VerificadorReglas verificadorReglas,
                   Archiver archiver,
                   BaseDeConocimiento grafo,
                   ConfiguracionGrafica configuracionGrafica,
                   ConfiguracionMotor configuracionMotor)
        {
            this.Nombre = nombre;
            this.VerificadorReglas = verificadorReglas;
            this.Archiver = archiver;
            this.Grafo = grafo;
            this.ConfiguracionGrafica = configuracionGrafica;
            this.ConfiguracionMotor = configuracionMotor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public VerificadorReglas VerificadorReglas { get => verificadorReglas; set => verificadorReglas = value; }
        public Archiver Archiver { get => archiver; set => archiver = value; }
        public BaseDeConocimiento Grafo { get => baseConocimientos; set => baseConocimientos = value; }
        public ConfiguracionGrafica ConfiguracionGrafica { get => configuracionGrafica; set => configuracionGrafica = value; }
        public ConfiguracionMotor ConfiguracionMotor { get => configuracionMotor; set => configuracionMotor = value; }
    }
}
