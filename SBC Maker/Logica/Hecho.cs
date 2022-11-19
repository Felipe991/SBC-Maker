namespace SBC_Maker.Logica
{
    public class Hecho
    {
        private string respuestaFinal;
        private float? valorCrisp;

        public Hecho(string respuestaFinal, float valorCrisp)
        {
            this.respuestaFinal = respuestaFinal;
            this.valorCrisp = valorCrisp;
        }

        public Hecho()
        {
            this.respuestaFinal = "";
            this.valorCrisp = new float();
        }

        public string RespuestaFinal { get => respuestaFinal; set => respuestaFinal = value; }
        public float? ValorCrisp { get => valorCrisp; set => valorCrisp = value; }
    }
}