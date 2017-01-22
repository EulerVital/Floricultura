using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.ENT
{
    class eFotos
    {
        public int Id { get; set; }
        public string Caminho { get; set; }
        public bool Status { get; set; }
        public int IdPlanta { get; set; }
    }
}
