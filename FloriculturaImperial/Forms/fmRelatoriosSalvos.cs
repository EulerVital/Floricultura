using FloriculturaImperial.Camadas.ENT;
using FloriculturaImperial.Camadas.NEG;
using FloriculturaImperial.Forms.uc;
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
    public partial class fmRelatoriosSalvos : Form
    {
        List<eRelatorio> lista = new List<eRelatorio>(); 
        public fmRelatoriosSalvos()
        {
            InitializeComponent();

            if(lista.Count <= 0)
            {
                lista = nRelatorio.selRelatoriosSalvos(null, null, false);

                if (rbtData.Checked)
                {
                    foreach(var item in lista)
                    {
                        ltbRelatorios.Items.Add(item.Data.Date);
                    }
                }
                    
                else if(rbtNome.Checked)
                {
                    foreach (var item in lista)
                    {
                        ltbRelatorios.Items.Add(item.Descricao);
                    }
                }
            }
        }

        private void rbtData_CheckedChanged(object sender, EventArgs e)
        {
            if(lista.Count > 0)
            {
                ltbRelatorios.Items.Clear();

                foreach (var item in lista)
                {
                    ltbRelatorios.Items.Add(item.Data.Date);
                }
            }
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                ltbRelatorios.Items.Clear();

                foreach (var item in lista)
                {
                    ltbRelatorios.Items.Add(item.Descricao);
                }
            }
        }

        private void ltbRelatorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ids = string.Empty;

            if (rbtData.Checked)
            {

                if (ltbRelatorios.SelectedItems.Count > 0)
                {
                    if (lista.Exists(c => c.Data.Date == Convert.ToDateTime(ltbRelatorios.SelectedItem)))
                    {
                        ids = lista.First(c => c.Data.Date == Convert.ToDateTime(ltbRelatorios.SelectedItem)).ListaIds;

                        ucRelatorio ucRela = new ucRelatorio(ids);
                    }
                }
            }else if (rbtNome.Checked)
            {
                if (ltbRelatorios.SelectedItems.Count > 0)
                {
                    if (lista.Exists(c => c.Descricao == ltbRelatorios.SelectedItem.ToString()))
                    {
                        ids = lista.First(c => c.Descricao == ltbRelatorios.SelectedItem.ToString()).ListaIds;

                        ucRelatorio ucRela = new ucRelatorio(ids);
                    }
                }
            }
        }
    }
}
