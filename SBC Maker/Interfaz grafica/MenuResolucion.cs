using SBC_Maker.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class MenuResolucion : Form
    {
        public MenuResolucion(List<Nodo> conclusiones, bool showExplicacion)
        {
            foreach(Nodo conclusion in conclusiones)
            {
                flowLayoutPanelConclusiones.Controls.Add(new ConclusionUserControl(conclusion, showExplicacion));
            }
        }
    }
}
