namespace SBC_Maker.Logica
{
    [Serializable]
    public class Hecho
    {
        private string respuestaFinal;
        private Double? valorCrisp;

        public Hecho(string respuestaFinal, Double valorCrisp)
        {
            this.respuestaFinal = respuestaFinal;
            this.valorCrisp = valorCrisp;
        }

        public Hecho()
        {
            this.respuestaFinal = "";
            this.valorCrisp = new Double();
        }

        public string RespuestaFinal { get => respuestaFinal; set => respuestaFinal = value; }
        public Double? ValorCrisp { get => valorCrisp; set => valorCrisp = value; }
    }
}