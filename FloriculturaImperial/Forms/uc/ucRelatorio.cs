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
using System.Xml;

namespace FloriculturaImperial.Forms.uc
{
    public partial class ucRelatorio : UserControl
    {
        List<eVendas> lista = null;

        public ucRelatorio()
        {
            InitializeComponent();
            popularGridRelatorio(null, null, null, null, null);
        }

        private void popularGridRelatorio(DateTime? dataAte, DateTime? dataDe, string nomeProd, int? qtdMaior, decimal? preco)
        {
            lista = new List<eVendas>();

            lista = nVendas.selRelatorioVendas(dataAte, dataDe, nomeProd, qtdMaior, preco);
            dgvRelatorio.Rows.Clear();

            for(int i = 0; i < lista.Count; i++)
            {
                dgvRelatorio.Rows.Add(lista[i].Id, retornaProdutosXml(lista[i].ProdutoXml), "R$ " + string.Format("{0:0.##}", lista[i].PrecoTotal), lista[i].QtdVendidas, lista[i].Data.ToString("dd/MM/yyyy"));
            }
        }

        private string retornaProdutosXml(string Prod)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Prod);
            string Produtos = string.Empty;
            int i = 1;

            XmlNodeList elementos = null;

            do
            {

                elementos = xmlDoc.SelectNodes("Produtos/NomeProduto" + i);
                if(elementos.Count != 0)
                    Produtos += elementos[0].InnerText + " / ";
                i++;
            } while (elementos.Count > 0);

            return Produtos;
        }

        private void btnFiltrar_MouseHover(object sender, EventArgs e)
        {
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.ForeColor = Color.Green;
        }

        private void btnFiltrar_MouseLeave(object sender, EventArgs e)
        {
            btnFiltrar.BackColor = Color.Green;
            btnFiltrar.ForeColor = Color.White;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            decimal? preco = null;
            int? qtd = null;
            DateTime? dataDe = null;
            DateTime? dataAte = null;

            try
            {
                if (!string.IsNullOrEmpty(nudQtd.Value.ToString()))
                     qtd =  Convert.ToInt32(nudQtd.Value);
                if(!string.IsNullOrEmpty(txtPreco.Text))
                    preco = Convert.ToDecimal(txtPreco.Text);
                if (!mtbDataDe.Text.Equals("  /  /"))
                {
                    dataDe =  Convert.ToDateTime(mtbDataDe.Text);
                    if (!mtbDataAte.Text.Equals("  /  /"))
                        dataAte = Convert.ToDateTime(mtbDataAte.Text);
                    else
                        dataAte = DateTime.Now;
                       
                }
                else
                {
                    dataDe = null;
                    dataAte = null;
                }

                popularGridRelatorio(dataAte, dataDe, null, qtd, preco);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de Conversão de dados, por favor digite o valor correto nos filtros..");
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            fmExportar frm = new fmExportar(dgvRelatorio);
            frm.Show();
        }
    }
}
