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
            
            this.labelConsecuente.Text = consecuente.Regla.Nombre;
            this.labelAntecedente.Text = relacionAntecedente.Nodo.Regla.Nombre;
            this.labelRespuesta.Text = GetRespuestasNecesarias();
        }

        private string GetRespuestasNecesarias()
        {
            string respNecesarias = "(";
            foreach(string respuestaNecesarioa in relacionAntecedente.RespuestasNecesarias)
            {
                string aditivo = relacionAntecedente.RespuestasNecesarias.Last() == respuestaNecesarioa ? "" : ", ";
                respNecesarias += respuestaNecesarioa + aditivo;
            }
            return respNecesarias+")";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            relacionesEliminadas.Add((relacionAntecedente.Nodo,consecuente,relacionAntecedente));
            this.Dispose();
        }
    }
}
