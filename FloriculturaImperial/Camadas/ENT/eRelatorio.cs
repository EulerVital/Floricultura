using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.ENT
{
    public class eRelatorio : eVendas
    {
        public string ListaIds { get; set; }
        public bool Excluido { get; set; }

        public string Descricao { get; set; }
    }
}
