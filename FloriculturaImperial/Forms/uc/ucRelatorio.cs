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
        List<eVendas> listaRelatorios = new List<eVendas>();
        public ucRelatorio()
        {
            InitializeComponent();
            popularGridView(null, null, null, null, null);
        }

        #region Eventos

        private void pbExportExcel_MouseHover(object sender, EventArgs e)
        {
            pbExportExcel.BackColor = Color.Gray;
            pbExportExcel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbExportExcel_MouseLeave(object sender, EventArgs e)
        {
            pbExportExcel.BackColor = Color.White;
            pbExportExcel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbExportPdf_MouseHover(object sender, EventArgs e)
        {
            pbExportPdf.BackColor = Color.Gray;
            pbExportPdf.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbExportPdf_MouseLeave(object sender, EventArgs e)
        {
            pbExportPdf.BackColor = Color.White;
            pbExportPdf.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbExportSalvar_MouseHover(object sender, EventArgs e)
        {
            pbExportSalvar.BackColor = Color.Gray;
            pbExportSalvar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbExportSalvar_MouseLeave(object sender, EventArgs e)
        {
            pbExportSalvar.BackColor = Color.White;
            pbExportSalvar.BorderStyle = BorderStyle.FixedSingle;
        }

        #endregion

        #region Métodos
        private void popularGridView(DateTime? dataDe, DateTime? dataAte, int? qtd, decimal? preco, string nomeProd)
        {
            listaRelatorios = nVendas.selRelatorioVendas(dataDe, dataAte, nomeProd, qtd, preco);

            if(listaRelatorios.Count > 0)
            {
                for(int i = 0; i < listaRelatorios.Count; i++)
                {
                    dgvRelatorio.Rows.Add(listaRelatorios[i].Id, retornaProdutos(listaRelatorios[i].ProdutoXml), "R$ " + string.Format("{0:0.##}", listaRelatorios[i].PrecoTotal), listaRelatorios[i].QtdVendidas,
                        listaRelatorios[i].Data.ToString("dd/MM/yyyy"));
                }
            }
        }

        public string retornaProdutos(string xmlProd)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlProd);
            int i = 1;
            XmlElement xmlElement = null;
            string Produtos = string.Empty;
            bool continua = true;

            do
            {
                try
                {
                    xmlElement = xmlDoc.SelectSingleNode("Produtos/NomeProduto" + i) as XmlElement;
                    if (!string.IsNullOrEmpty(xmlElement.InnerText))
                        Produtos += xmlElement.InnerText + " / ";
                    i++;
                }catch(Exception ex)
                {
                    continua = false;
                }

            }while(continua);

            return Produtos;
        }

        #endregion
    }
}
