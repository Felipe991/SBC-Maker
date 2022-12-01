namespace SBC_Maker.Logica
{
    public abstract class FuncionPertenencia
    {
        public string nombre;
        public Color color;

        public FuncionPertenencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        
        public abstract Double CalcularPertenencia(Double x);

        public abstract Double[] getValoresX();
        
        public abstract Double[] getValoresY();
    }
}