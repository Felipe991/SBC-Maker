namespace SBC_Maker.Logica
{
    public class ConjuntoDifuso
    {
        public string nombre;
        public string nombreUnidades;
        public int metodoResolucion;
        public List<FuncionPertenencia> funcionesPertenencia;

        public ConjuntoDifuso(string nombre, string nombreUnidades, int metodoResolucion)
        {
            this.Nombre = nombre;
            this.NombreUnidades = nombreUnidades;
            this.MetodoResolucion = metodoResolucion;
            this.funcionesPertenencia = new List<FuncionPertenencia>();
        }

        public ConjuntoDifuso()
        {
            this.Nombre = "";
            this.NombreUnidades = "";
            this.MetodoResolucion = new int();
            this.funcionesPertenencia = new List<FuncionPertenencia>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int MetodoResolucion { get => metodoResolucion; set => metodoResolucion = value; }
        public string NombreUnidades { get => nombreUnidades; set => nombreUnidades = value; }

        public void addFuncionPertenencia(FuncionPertenencia funcionPertenencia)
        {
            this.funcionesPertenencia.Add(funcionPertenencia);
        }

        public void removeFuncionPertenencia(FuncionPertenencia funcionPertenencia)
        {
            this.funcionesPertenencia.Remove(funcionPertenencia);
        }
    }
}