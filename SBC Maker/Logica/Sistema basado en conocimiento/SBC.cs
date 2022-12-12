using SBC_Maker.Logica.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    [Serializable]
    public class SBC
    {
        private string nombre = "SBC";
        private List<Nodo> baseConocimiento;
        private ConfiguracionMotor configuracionMotor = new ConfiguracionMotor();

        public SBC()
        {
            this.baseConocimiento = new List<Nodo>();
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public ConfiguracionMotor ConfiguracionMotor { get => configuracionMotor; set => configuracionMotor = value; }
        public List<Nodo> BaseConocimiento { get => baseConocimiento; set => baseConocimiento = value; }
    }
}
