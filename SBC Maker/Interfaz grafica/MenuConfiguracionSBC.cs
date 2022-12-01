using SBC_Maker.Logica.Configuracion;
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
    public partial class MenuConfiguracionSBC : Form
    {
        private ConfiguracionMotor configuracionMotor;
        public MenuConfiguracionSBC(ConfiguracionMotor configuracionMotor)
        {
            InitializeComponent();
            this.ConfiguracionMotor = configuracionMotor;
            CheckList();
            this.numericUpDownLimiteConclusiones.Value = configuracionMotor.ConclusionesNecesarias;
            this.radioButtonSi.Checked = configuracionMotor.Explicacion;
            this.radioButtonNo.Checked = !configuracionMotor.Explicacion;
        }
        private void CheckList()
        {
            for (int i = 0; i < 3; i++)
            {
                checkedListBoxMetodoResolucion.SetItemChecked(i, configuracionMotor.MetodoResolucion[i]);
            }
        }
        private void SetList()
        {
            for (int i = 0; i < 3; i++)
            {
                this.configuracionMotor.SetMetodoResolucion(i, checkedListBoxMetodoResolucion.GetItemChecked(i));
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (VerifycheckList())
            {
                SetList();
                this.configuracionMotor.ConclusionesNecesarias = (int)this.numericUpDownLimiteConclusiones.Value;
                this.configuracionMotor.Explicacion = this.radioButtonSi.Checked;
                DialogResult = DialogResult.OK;
            }
            
        }
        private bool VerifycheckList()
        {
            bool result = false;
            for (int i = 0; i < 3; i++)
            {
                if (checkedListBoxMetodoResolucion.GetItemChecked(i))
                {
                    result = true;
                }
            }
            if (!result)
            {
                MessageBox.Show("Especifique al menos un método de resolución");
            }
            return result;
        }


        private void checkedListBoxMetodoResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkedListBoxMetodoResolucion.CheckedItems.Count == 0)
            {
                this.checkedListBoxMetodoResolucion.SetItemChecked(this.checkedListBoxMetodoResolucion.SelectedIndex, true);
            }
        }
        public ConfiguracionMotor ConfiguracionMotor { get => configuracionMotor; set => configuracionMotor = value; }
        
    }
}
