namespace SBC_Maker.Logica.Configuracion
{
    public class ConfiguracionGrafica
    {
        private int zoom;
        private List<Posicion> posiciones;

        public ConfiguracionGrafica(int zoom, List<Posicion> posiciones)
        {
            Zoom = 100;
            posiciones = new List<Posicion>();
        }

        public int Zoom { get => zoom; set => zoom = value; }
        public void addPosicion(int x, int y, string nombreRegla)
        {
            this.posiciones.Add(new Posicion(x, y, nombreRegla));
        }
        
        public void deletePosicion(string nombreRegla)
        { 
          for(int i = 0; i < posiciones.Count; i++)
            {
                if (posiciones[i].NombreRegla.Equals(nombreRegla))
                {
                    posiciones.RemoveAt(i);
                    break;
                }
            }
        }

        public void modifyPos(int x, int y, string nombreRegla)
        {
            for (int i = 0; i < posiciones.Count; i++)
            {
                if (posiciones[i].NombreRegla.Equals(nombreRegla))
                {
                    posiciones[i].X = x;
                    posiciones[i].Y = y;
                    posiciones[i].NombreRegla = nombreRegla;
                }
            }
        }
    }
}