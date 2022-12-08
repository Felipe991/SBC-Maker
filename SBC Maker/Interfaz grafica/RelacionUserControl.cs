using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;


namespace SBC_Maker.Interfaz_grafica
{
    public partial class RelacionUserControl : UserControl
    {
        Nodo consecuente;
        Relacion relacionAntecedente;
        List<Nodo> listaAdyacencia;
        List<(string, (Posicion, Posicion))> flechas;

        //Eliminar relacion, ver la wea de las flechas, despues aplicar la misma wea al borrar un nodo.
        public RelacionUserControl(Nodo consecuente,
                                   Relacion relacionAntecedente,
                                   List<Nodo> listaAdyacencia,
                                   List<(string, (Posicion, Posicion))> flechas)
        {
            InitializeComponent();
            this.consecuente = consecuente;
            this.relacionAntecedente = relacionAntecedente;
            this.listaAdyacencia = listaAdyacencia;
            this.flechas = flechas;
            
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

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            MenuRelacion menuRelacion = new MenuRelacion(listaAdyacencia,consecuente,relacionAntecedente);
            menuRelacion.ShowDialog();
        }

        private void ConsecuenteUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
