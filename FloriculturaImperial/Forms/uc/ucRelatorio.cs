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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.VisualBasic;

namespace FloriculturaImperial.Forms.uc
{
    public partial class ucRelatorio : UserControl
    {
        eVendas l = new eVendas();
        List<eVendas> listaRelatorios = new List<eVendas>();
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        private string caminho = string.Empty;
        public ucRelatorio()
        {
            InitializeComponent();
            caminho = Directory.GetCurrentDirectory().ToString().Replace("bin\\Debug","");
            popularGridView(null, null, null, null, null, null);
        }

        public ucRelatorio(string ids)
        {
            InitializeComponent();
            popularGridView(null,null,null,null,null,ids);
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

        private void pbExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvRelatorio.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvRelatorio.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvRelatorio.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvRelatorio.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvRelatorio.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Exportar contate o desenvovedor do sistema \n\nEuler Vital \nEmail: eulervitalps@gmail.com " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void pbExportPdf_Click(object sender, EventArgs e)
        {
            // Criando tabela iTextSharp a partir dos dados DataTable
            PdfPTable pdfTable = new PdfPTable(dgvRelatorio.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            //pdfTable.WidthPercentage = 50;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            pdfTable.Summary = "Relatorio Em PDF";
            int indece = 0;

            // Adicionando linha de cabeçalho
            foreach (DataGridViewColumn coluna in dgvRelatorio.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText));
                cell.BackgroundColor = new BaseColor(Color.Silver);
                pdfTable.AddCell(cell);
                indece++;
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgvRelatorio.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            // Exportar para PDF

            if (!string.IsNullOrEmpty(caminho))
            {
                string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dataAtual = dataAtual.Replace(":", "_");
                dataAtual = dataAtual.Replace(" ", "_");

                if (!Directory.Exists(caminho + @"PDFsRelatorio\"))
                {
                    Directory.CreateDirectory(caminho + @"PDFsRelatorio\");
                }
                using (FileStream stream = new FileStream(caminho + @"PDFsRelatorio\" + "Relatorio" + dataAtual + ".pdf", FileMode.Create))
                {
                    Document PDFDoc = new Document(PageSize.A2, 20F, 20F, 20F, 0f);
                    PdfWriter.GetInstance(PDFDoc, stream);
                    PDFDoc.Open();
                    PDFDoc.Add(pdfTable);
                    PDFDoc.Close();
                    stream.Close();

                    MessageBox.Show("Exportação para PDF Efetuada com Sucesso \n\n Arquivo encontra-se: \n" + caminho + @"PDFsRelatorio\" + "Relatorio" + dataAtual + ".pdf","Exportação PDF",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void pbExportSalvar_Click(object sender, EventArgs e)
        {
            string listaIds = string.Empty;

            if(listaRelatorios.Count > 0)
            {
                string Nome = string.Empty;
                Nome = Interaction.InputBox("Digite um Descrição ou pressione OK para continuar...").ToUpper();

                for(int i = 0; i < listaRelatorios.Count; i++)
                {
                    if(i.Equals(listaRelatorios.Count-1))
                        listaIds += listaRelatorios[i].Id;
                    else
                        listaIds += listaRelatorios[i].Id + ",";
                }

                if (nRelatorio.insRelatoriosSalvos(null, listaIds, null, Nome))
                {
                    MessageBox.Show("Relatório Salvo com sucesso.", "Secesso ao Salvar Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string prod = null, dataDe = null, dataAte = null;
            DateTime? DataDe = null, DataAte = null;
            int? qtd = null;
            decimal? preco = null;
            decimal precoAux = 0;

            if (!string.IsNullOrEmpty(txtPesquisar.Text))
                prod = txtPesquisar.Text;
            if (!mtbDataDe.Text.Equals("  /  /"))
                dataDe = mtbDataDe.Text;
            if (!mtbDataAte.Text.Equals("  /  /"))
                dataAte = mtbDataAte.Text;
            if (nudQtd.Value != 0)
                qtd = int.Parse(nudQtd.Value.ToString());
            if (!string.IsNullOrEmpty(txtPreco.Text))
            {
                if (decimal.TryParse(txtPreco.Text, out precoAux))
                    preco = precoAux;
                else
                    MessageBox.Show("Erro ao converter preço","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try
            {
                if(dataDe != null)
                    DataDe = Convert.ToDateTime(dataDe);
                if(dataAte != null)
                    DataAte = Convert.ToDateTime(dataAte);
            }
            catch
            {
                MessageBox.Show("Data invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            popularGridView(DataDe, DataAte, qtd, preco, prod, null);
                
        }

        private void btnVerSalvos_Click(object sender, EventArgs e)
        {
            fmRelatoriosSalvos c = new fmRelatoriosSalvos();
            c.Visible = true;
        }

        #endregion

        #region Métodos
        private void popularGridView(DateTime? dataDe, DateTime? dataAte, int? qtd, decimal? preco, string nomeProd, string ids)
        {
            dgvRelatorio.Rows.Clear();

            listaRelatorios = nVendas.selRelatorioVendas(dataDe, dataAte, nomeProd, qtd, preco, ids);

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
                }catch
                {
                    continua = false;
                }

            }while(continua);

            return Produtos;
        }


        #endregion

    }
}
