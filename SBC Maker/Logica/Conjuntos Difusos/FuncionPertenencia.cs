namespace SBC_Maker.Logica
{
    [Serializable]
    public abstract class FuncionPertenencia
    {
        public string nombre;
        public Color color;

        public FuncionPertenencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public FuncionPertenencia()
        {
            this.nombre = "";
            this.color = new Color();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        
        public abstract Double CalcularPertenencia(Double x);

        public abstract Double[] getValoresX();
        
        public abstract Double[] getValoresY();
    }
}