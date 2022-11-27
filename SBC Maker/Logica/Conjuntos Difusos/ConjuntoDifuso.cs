namespace SBC_Maker.Logica
{
    public class ConjuntoDifuso
    {
        private string nombre;
        private int metodoResolucion;
        private List<FuncionPertenencia> funcionesPertenencia;

        public ConjuntoDifuso(string nombre, int metodoResolucion)
        {
            this.Nombre = nombre;
            this.MetodoResolucion = metodoResolucion;
            this.funcionesPertenencia = new List<FuncionPertenencia>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int MetodoResolucion { get => metodoResolucion; set => metodoResolucion = value; }
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