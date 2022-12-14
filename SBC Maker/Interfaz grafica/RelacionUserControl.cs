using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;
using static SBC_Maker.Logica.Utiles;


namespace SBC_Maker.Interfaz_grafica
{
    public partial class RelacionUserControl : UserControl
    {
        Nodo consecuente;
        Relacion relacionAntecedente;
        List<Nodo> listaAdyacencia;
        List<(Nodo, Nodo, Relacion)> relacionesEliminadas;

        public RelacionUserControl(Nodo consecuente,
                                   Relacion relacionAntecedente,
                                   List<Nodo> listaAdyacencia,
                                   List<(Nodo, Nodo, Relacion)> relacionesEliminadas)
        {
            InitializeComponent();
            this.consecuente = consecuente;
            this.relacionAntecedente = relacionAntecedente;
            this.listaAdyacencia = listaAdyacencia;
            this.relacionesEliminadas = relacionesEliminadas;
            
            this.richTextBoxConsecuente.Text = consecuente.Regla.Nombre;
            this.richTextBoxAntecedente.Text = relacionAntecedente.Nodo.Regla.Nombre+Environment.NewLine;
            this.richTextBoxAntecedente.Text+= GetRespuestasNecesarias();
        }

        private string GetRespuestasNecesarias()
        {
            string respNecesarias = "(";
            foreach(string respuestaNecesaria in relacionAntecedente.RespuestasNecesarias)
            {
                string aditivo = relacionAntecedente.RespuestasNecesarias.Last() == respuestaNecesaria ? "" : ", ";
                respNecesarias += respuestaNecesaria + aditivo;
            }
            return respNecesarias+")";
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            var menuRelacion = new MenuRelacion(this.listaAdyacencia,consecuente,relacionAntecedente);
            if (menuRelacion.ShowDialog() == DialogResult.OK)
                this.relacionAntecedente.Explicacion = menuRelacion.textBoxExplicacion.Text; 
        }
        
    }
}
