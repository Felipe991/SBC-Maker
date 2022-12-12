namespace SBC_Maker.Logica.Configuracion
{
    [Serializable]
    public class ConfiguracionMotor
    {
        private int limiteConclusiones = 1;
        private bool[] metodoResolucion = new bool[3];
        private bool explicacion = true;

        public ConfiguracionMotor()
        {
            MetodoResolucion[0] = true;
            MetodoResolucion[1] = false;
            MetodoResolucion[2] = false;
        }

        public int ConclusionesNecesarias { get => limiteConclusiones; set => limiteConclusiones = value; }
        public bool Explicacion { get => explicacion; set => explicacion = value; }
        public bool[] MetodoResolucion { get => metodoResolucion; set => metodoResolucion = value; }

        public void SetMetodoResolucion(int numMetodo, bool estado)
        {
            MetodoResolucion[numMetodo] = estado;
        }
    }
}