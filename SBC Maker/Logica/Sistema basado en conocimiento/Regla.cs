namespace SBC_Maker.Logica
{
    public class Regla
    {
        private string nombre;
        private string? explicacion;
        
        public Regla(string nombre, string? explicacion)
        {
            this.Nombre = nombre;
            this.Explicacion = explicacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string? Explicacion { get => explicacion; set => explicacion = value; }
    }
}