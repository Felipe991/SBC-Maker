namespace SBC_Maker.Logica
{
    public class FuncionPertenencia
    {
        public string nombre;
        public Color color;

        public FuncionPertenencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public virtual Double CalcularPertenencia(Double x)
        {
            return 0;
        }
    }
}