using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FloriculturaImperial.Camadas.ENT
{
    public class eVendas
    {
        public int Id { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoTotal { get; set; }
        public string Produto { get; set; }
        public string ProdutoXml { get; set; }
        public int QtdEstocadas { get; set; }
        public int QtdVendidas { get; set; }
        public int QtdProdutos { get; set; }
        public DateTime Data { get; set; }

        public string PorcentVendias { get; set; }
        public string PorcentEstdocada { get; set; }
    }
}
