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
    public partial class EjecucionRespuestaCerradaUserControl : UserControl
    {
        public EjecucionRespuestaCerradaUserControl(List<string> alternativas)
        {
            InitializeComponent();
            addAlternativas(alternativas);
        }
        
        private void addAlternativas(List<string> alternativas)
        {
            int i = 0;
            foreach(string alternativa in alternativas)
            {
                groupBoxAlternativas.Controls.Add(new RadioButton() {
                    Text = alternativa,
                    Left = i % 3 == 0 ? groupBoxAlternativas.Controls[0].Left : Left,
                    Top = i%3 == 0 ? (i / 3) * 20 : Top
                    });
            }
        }

        public string getRespuesta()
        {
            foreach (RadioButton radioButton in groupBoxAlternativas.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return null;
        }
    }
}
