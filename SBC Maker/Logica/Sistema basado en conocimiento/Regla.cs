namespace SBC_Maker.Logica
{
    public class Regla
    {
        private string nombre;
        
        public Regla(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}