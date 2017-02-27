using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloriculturaImperial.Forms
{
    public partial class fmExportar : Form
    {
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        DataGridView dgvGrid = null;
        public fmExportar(DataGridView dgvRelatorio)
        {
            InitializeComponent();
            dgvGrid = dgvRelatorio;
        }

        #region Eventos
        private void pbXls_MouseHover(object sender, EventArgs e)
        {
            pbXls.BackColor = Color.Silver;
        }

        private void pbXls_MouseLeave(object sender, EventArgs e)
        {
            pbXls.BackColor = Color.MintCream;
        }

        private void pbPdf_MouseHover(object sender, EventArgs e)
        {
            pbPdf.BackColor = Color.Silver;
        }

        private void pbPdf_MouseLeave(object sender, EventArgs e)
        {
            pbPdf.BackColor = Color.MintCream;
        }

        private void pbXls_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvGrid.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvGrid.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvGrid.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvGrid.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvGrid.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        #endregion
    }
}
