namespace SBC_Maker.Logica
{
    public class Relacion
    {
        private Nodo nodo;
        private List<string>? respuestasNecesarias;
        public Relacion(Nodo nodo, List<string> respuestasNecesarias = null)
        {
            this.Nodo = nodo;
            this.RespuestasNecesarias = respuestasNecesarias;
        }

        public Nodo Nodo { get => nodo; set => nodo = value; }
        public List<string> RespuestasNecesarias { get => respuestasNecesarias; set => respuestasNecesarias = value; }
    }
}