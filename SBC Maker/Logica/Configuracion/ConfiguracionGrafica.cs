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
        public void addPosicion(int x, int y, Nodo nodo)
        {
            this.posiciones.Add(new Posicion(x, y, nodo));
        }
        
        public void deletePosicion(Nodo nodo)
        { 
          for(int i = 0; i < posiciones.Count; i++)
            {
                if (posiciones[i].Nodo.Equals(nodo))
                {
                    posiciones.RemoveAt(i);
                    break;
                }
            }
        }

        public void modifyPos(int x, int y, Nodo nodo)
        {
            for (int i = 0; i < posiciones.Count; i++)
            {
                if (posiciones[i].Nodo.Equals(nodo))
                {
                    posiciones[i].X = x;
                    posiciones[i].Y = y;
                    posiciones[i].Nodo = nodo;
                }
            }
        }
    }
}