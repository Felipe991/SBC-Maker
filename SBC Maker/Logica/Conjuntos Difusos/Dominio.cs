namespace SBC_Maker.Logica
{
    public class Dominio
    {
        private string nombreUnidad;
        private float rangoSalto;
        private float limiteInferior;
        private float limiteSuperior;

        public Dominio(string nombreUnidad, float rangoSalto, float limiteInferior, float limiteSuperior)
        {
            this.NombreUnidad = nombreUnidad;
            this.RangoSalto = rangoSalto;
            this.LimiteInferior = limiteInferior;
            this.LimiteSuperior = limiteSuperior;
        }

        public string NombreUnidad { get => nombreUnidad; set => nombreUnidad = value; }
        public float RangoSalto { get => rangoSalto; set => rangoSalto = value; }
        public float LimiteInferior { get => limiteInferior; set => limiteInferior = value; }
        public float LimiteSuperior { get => limiteSuperior; set => limiteSuperior = value; }
    }
}