namespace SBC_Maker.Logica
{
    public class Relacion
    {
        private Nodo nodo;
        public List<string>? respuestasNecesarias = new List<string>();
        private string explicacion;
        public Relacion(Nodo nodo,string explicacion = "")
        {
            this.Nodo = nodo;
            this.explicacion = explicacion;
        }

        public Nodo Nodo { get => nodo; set => nodo = value; }
        public List<string> RespuestasNecesarias { get => respuestasNecesarias; set => respuestasNecesarias = value; }
    }
}