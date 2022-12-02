using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class PreguntaCerrada : Pregunta
    {
        private List<string> alternativas;
        public PreguntaCerrada(List<string> alternativas, string enunciado) : base(enunciado)
        {
            this.Alternativas = alternativas;
        }

        public List<string> Alternativas { get => alternativas; set => alternativas = value; }

        public void addAlternativa(string alternativa)
        {
            this.Alternativas.Add(alternativa);
        }

        public void removeAlternativa(string alternativa)
        {
            this.Alternativas.Remove(alternativa);
        }
    }
}
