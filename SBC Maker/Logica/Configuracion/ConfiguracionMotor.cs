namespace SBC_Maker.Logica.Configuracion
{
    public class ConfiguracionMotor
    {
        private int conclusionesNecesarias = 1;
        private bool[] metodoResolucion = new bool[3];
        private bool explicacion = true;

        public ConfiguracionMotor()
        {
            metodoResolucion[0] = true;
            metodoResolucion[1] = false;
            metodoResolucion[2] = false;
        }

        public int ConclusionesNecesarias { get => conclusionesNecesarias; set => conclusionesNecesarias = value; }
        public bool Explicacion { get => explicacion; set => explicacion = value; }

        public void activarMetodoResolucion(int numMetodo)
        {
            metodoResolucion[numMetodo] = true;
        }
        public void desactivarMetodoResolucion(int numMetodo)
        {
            metodoResolucion[numMetodo] = false;
        }
    }
}