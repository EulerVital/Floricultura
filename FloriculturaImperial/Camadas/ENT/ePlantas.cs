using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloriculturaImperial.Camadas.ENT
{
    class ePlantas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int Qtd { get; set; }
        public bool Especial { get; set; }
        public string NomeEspecial { get; set; }
        public bool Status { get; set; }
        public int QtdVendida { get; set; }

    }
}
