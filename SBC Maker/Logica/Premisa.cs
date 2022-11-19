using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    public class Premisa : Relacion
    {
        private string respuestaNecesaria;

        public Premisa(string respuestaNecesaria, Nodo nodo) : base(nodo)
        {
            this.respuestaNecesaria = respuestaNecesaria;
        }

        public string RespuestaNecesaria { get => respuestaNecesaria; set => respuestaNecesaria = value; }
    }
}
