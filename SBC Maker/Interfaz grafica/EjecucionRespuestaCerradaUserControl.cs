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
                i++;
                groupBoxAlternativas.Controls.Add(new RadioButton() {
                    Text = alternativa,
                    Left = 5,
                    Top = i!=1 ? i*20 : 5,
                    Width = (TextRenderer.MeasureText(alternativa, Font)).Width + 20
                });;
            }
            ((RadioButton)groupBoxAlternativas.Controls[0]).Checked = true;
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
