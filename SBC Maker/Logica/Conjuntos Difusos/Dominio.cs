namespace SBC_Maker.Logica
{
    public class Dominio
    {
        private string nombreUnidad;
        private Double rangoSalto;
        private Double limiteInferior;
        private Double limiteSuperior;

        public Dominio(string nombreUnidad, Double rangoSalto, Double limiteInferior, Double limiteSuperior)
        {
            this.NombreUnidad = nombreUnidad;
            this.RangoSalto = rangoSalto;
            this.LimiteInferior = limiteInferior;
            this.LimiteSuperior = limiteSuperior;
        }

        public string NombreUnidad { get => nombreUnidad; set => nombreUnidad = value; }
        public Double RangoSalto { get => rangoSalto; set => rangoSalto = value; }
        public Double LimiteInferior { get => limiteInferior; set => limiteInferior = value; }
        public Double LimiteSuperior { get => limiteSuperior; set => limiteSuperior = value; }
    }
}