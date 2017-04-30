using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FloriculturaImperial.Camadas.ENT;
using FloriculturaImperial.Camadas.NEG;

namespace FloriculturaImperial.Forms.uc
{
    public partial class ucTabelaProdutos : UserControl
    {
        public ucTabelaProdutos(string produto)
        {
            InitializeComponent();
            dgvProdutosVendidos.Rows.Clear();
            if(!string.IsNullOrEmpty(produto))
                preencherTabela(produto);
        }

        private void preencherTabela(string produto)
        {
            List<eVendas> listaVendidas = new List<eVendas>();

            listaVendidas = nVendas.selProdutosVendidos(null, produto);

            for(int i=0; i< listaVendidas.Count; i++)
            {
                dgvProdutosVendidos.Rows.Add(listaVendidas[i].Id, listaVendidas[i].Produto, "R$ " + string.Format("{0:0.##}", listaVendidas[i].Preco),
                    listaVendidas[i].QtdVendidas, listaVendidas[i].QtdEstocadas,listaVendidas[i].Data.ToString("dd/MM/yyyy"));
            }
        }
    }
}
