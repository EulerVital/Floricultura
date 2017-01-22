﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FloriculturaImperial.Camadas.ENT;
using FloriculturaImperial.Camadas.NEG;

namespace FloriculturaImperial
{
    public partial class fmPrincipal : Form
    {
        static string caminho = string.Empty;
        static bool isImg = false;
        static List<ePlantas> listaPlanta = new List<ePlantas>();
        static List<eFotos> listaFoto = new List<eFotos>();
        static List<ePlantas> listaTodasPlantas = new List<ePlantas>();
        static List<eFotos> listaTodasFotos = new List<eFotos>();
        static List<ePlantas> listaPlantaVenda = new List<ePlantas>();

        public fmPrincipal()
        {
            InitializeComponent();
            caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\";
            tbVendasCadQtd.Text = "1";
            tbVendasCadQtd.Focus();

            listaTodasPlantas = nPlantas.selPlantas(null);
            listaTodasFotos = nFotos.selFotos(null);
            checkesVendas();
        }


        #region Vendas

        #region Metodos Vendas
        private void checkesVendas()
        {
            if (rbVendasSimples.Checked)
            {
                if (listaTodasPlantas.Count > 0)
                {
                    foreach (ePlantas planta in listaTodasPlantas)
                    {
                        lsVendasProdutos.Items.Add(planta.Nome);
                    }
                }
            }
            if (rbVendasCestas.Checked)
            {

            }
            if (rbVendasBrinquedos.Checked)
            {

            }
        }

        private void preenchadoSelecionados(string nome, bool isValorQtd)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if(lsVendasProdutos.SelectedItems.Count > 0)
                {
                    float PrecoTotal = 0;

                    listaPlanta.Clear();
                    for (int i = 0; i < lsVendasProdutos.SelectedItems.Count; i++)
                    {
                        lsVendasProdutos.SelectedItems[i].ToString();
                        if (listaTodasPlantas.Exists(c => c.Nome == lsVendasProdutos.SelectedItems[i].ToString()))
                            listaPlanta.Add(listaTodasPlantas.Find(c => c.Nome == lsVendasProdutos.SelectedItems[i].ToString()));

                        if (!lsVendasProdutos.Items.Contains(lsVendasProdutos.SelectedItems[i].ToString()))
                            listaPlantaVenda.RemoveAll(c => c.Nome == lsVendasProdutos.SelectedItems[i].ToString());
                        
                    }

                  
                    for (int i = 0; i< listaPlanta.Count; i++)
                    {
                        if (listaPlantaVenda.Exists(c => c.Nome == listaPlanta[i].Nome))
                            PrecoTotal = PrecoTotal + (float.Parse(listaPlanta[i].Preco) * listaPlantaVenda.Find(c=>c.Nome == listaPlanta[i].Nome).QtdVendida);
                    }

                    for (int i = 0; i < listaPlanta.Count; i++)
                    {
                        if (!listaPlantaVenda.Exists(c => c.Nome == listaPlanta[i].Nome))
                            PrecoTotal = PrecoTotal + float.Parse(listaPlanta[i].Preco);
                    }
                    

                    listaPlanta.Clear();
                    if (listaTodasPlantas.Exists(c => c.Nome == lsVendasProdutos.SelectedItems[lsVendasProdutos.SelectedItems.Count-1].ToString()))
                        listaPlanta.Add(listaTodasPlantas.Find(c => c.Nome == lsVendasProdutos.SelectedItems[lsVendasProdutos.SelectedItems.Count - 1].ToString()));

                    tbVendasPreco.Text = listaPlanta[0].Preco;
                    tbVendasCadQtd.Focus();
                    if (isValorQtd)
                    {
                        int qtd = 0;
                        if (string.IsNullOrEmpty(tbVendasCadQtd.Text))
                        {
                            tbVendasPrecoTotal.Text = "R$ " + string.Format("{0:N2}", (PrecoTotal + (float.Parse(listaPlanta[0].Preco) * 1)));
                        }
                        else
                        {
                            if (int.TryParse(tbVendasCadQtd.Text, out qtd))
                            {
                                tbVendasPrecoTotal.Text = "R$ " + string.Format("{0:N2}", (PrecoTotal + (float.Parse(listaPlanta[0].Preco) * qtd)));
                                listaPlantaVenda.Add(new ePlantas { QtdVendida = qtd, Nome = nome });
                            }
                        }
                    }else
                    {
                        tbVendasPrecoTotal.Text = "R$ " + string.Format("{0:N2}", PrecoTotal);
                    }

                    tbVendasCadQtd.Text = "1";
                }else
                {
                    tbVendasCadQtd.Text = "1";
                    tbVendasPreco.Text = "";
                    tbVendasPrecoTotal.Text = "";
                }

            }else
            {
                tbVendasCadQtd.Text = "1";
                tbVendasPreco.Text = "";
                tbVendasPrecoTotal.Text = "";
            }
        }

        #endregion
        private void btnVendas_Click(object sender, EventArgs e)
        {
            pnPlantas.Visible = false;

            pnVendas.Visible = true;
            checkesVendas();
        }

        private void btnTabVendasGeral_Click(object sender, EventArgs e)
        {
            pnCadVendas.Visible = false;

            pnTabGeral.Visible = true;
        }

        private void btnVendasCad_Click(object sender, EventArgs e)
        {
            pnTabGeral.Visible = false;

            pnCadVendas.Visible = true;
        }

        private void btnVendasFinalizar_MouseHover(object sender, EventArgs e)
        {
            btnVendasFinalizar.ForeColor = Color.Green;
            btnVendasFinalizar.BackColor = Color.White;
        }

        private void btnVendasFinalizar_MouseLeave(object sender, EventArgs e)
        {
            btnVendasFinalizar.ForeColor = Color.White;
            btnVendasFinalizar.BackColor = Color.Green;
        }

        private void lsVendasProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsVendasProdutos.SelectedItems.Count > 0)
           preenchadoSelecionados(lsVendasProdutos.SelectedItems[lsVendasProdutos.SelectedItems.Count-1].ToString(),false);
        }

        private void tbVendasCadQtd_TextChanged(object sender, EventArgs e)
        {
            if (listaPlanta.Count > 0)
                preenchadoSelecionados(listaPlanta[listaPlanta.Count - 1].Nome,true);
        }

        #endregion

        #region Plantas
        private void btnPlantas_Click(object sender, EventArgs e)
        {
            pnVendas.Visible = false;

            pnPlantas.Visible = true;
            preencherLista(null);
        }

        private void btnPlantaCad_Click(object sender, EventArgs e)
        {
            pnPlantasEditar.Visible = false;

            pnPlantasCad.Visible = true;
            btnPlantaInsImg.Visible = true;
            btnPlantaLimpaImg.Visible = true;
            pbPlantaImg.Load(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg");
            tbPlantasCadNome.Focus();
        }

        private void btnPlantaEditar_Click(object sender, EventArgs e)
        {
            pnPlantasCad.Visible = false;

            pnPlantasEditar.Visible = true;
            btnPlantaInsImg.Visible = true;
            btnPlantaLimpaImg.Visible = true;
            selecionarPlantas(lsPlanta.SelectedItem.ToString());
            tbPlantaEdtNome.Focus();
        }

        private void btnPlantaInsImg_Click(object sender, EventArgs e)
        {
            if (ofdImg.ShowDialog() == DialogResult.OK && ofdImg.CheckFileExists == true)
            {
                pbPlantaImg.Load(ofdImg.FileName);
                FloriculturaImperial.Properties.Resources rs = new Properties.Resources();
                if (!Directory.Exists(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\"))
                {
                    Directory.CreateDirectory(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\").Create();
                    caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\" + ofdImg.SafeFileName;
                    isImg = true;
                }
                else
                {
                    caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\" + ofdImg.SafeFileName;
                    isImg = true;
                }
            }
        }

        private void btnPlantaLimpaImg_Click(object sender, EventArgs e)
        {
            if (ofdImg.FileName != null)
            {
                ofdImg.FileName = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg";
                caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\";
                pbPlantaImg.Load(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg");
                isImg = false;
            }
        }

        private void btnPlantaCadFinalizar_Click(object sender, EventArgs e)
        {
            float Preco = 0;
            int qtd = 0;
            int idPlanta = 0;

            if (!string.IsNullOrEmpty(tbPlantasCadNome.Text) && float.TryParse(tbPlantaCadPreco.Text, out Preco) == true
                && int.TryParse(tbPlantaCadQtd.Text, out qtd) == true && (rbPlantaEdtNao.Checked || rbPlantaEdtSim.Checked))
            {
                ePlantas planta = new ePlantas();

                planta.Nome = tbPlantasCadNome.Text;
                planta.Preco = Preco.ToString();
                planta.Qtd = qtd;
                if (rbPlantaCadNao.Checked)
                    planta.Especial = false;
                else if (rbPlantaCadSim.Checked)
                    planta.Especial = true;
                planta.Status = true;

                idPlanta = nPlantas.insPlantas(planta);

                eFotos foto = new eFotos();
                string fileName = string.Empty;
                if (isImg)
                {
                    fileName = Path.GetFileName(pbPlantaImg.ImageLocation);
                    if (!File.Exists(caminho + fileName))
                        File.Copy(ofdImg.FileName, caminho);

                    foto.Caminho = caminho;
                }
                else
                {
                    foto.Caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg";
                }
                foto.Status = true;
                foto.IdPlanta = idPlanta;

                if (nFotos.insFotos(foto))
                {
                    MessageBox.Show("Cadastro efetuado com Sucesso", "Cadastro sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaTodasPlantas = nPlantas.selPlantas(null);
                    listaTodasFotos = nFotos.selFotos(null);
                    limparTudo(true);
                    preencherLista(tbPlantasCadNome.Text);
                }
                else
                    MessageBox.Show("Falha ao cadastrar", "Falha no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
                MessageBox.Show("Há campos invalido", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPlantaCadLimpa_Click(object sender, EventArgs e)
        {
            limparTudo(true);
        }

        private void btnPlantaCons_Click(object sender, EventArgs e)
        {
            pnPlantasCad.Visible = false;
            pnPlantasEditar.Visible = false;
            btnPlantaInsImg.Visible = false;
            btnPlantaLimpaImg.Visible = false;

            if (lsPlanta.Items.Count > 0)
                selecionarPlantas(lsPlanta.SelectedItem.ToString());
        }

        private void lsPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionarPlantas(lsPlanta.SelectedItem.ToString());
        }

        private void btnPlantaEdtFinalizar_Click(object sender, EventArgs e)
        {
            float Preco = 0;
            int qtd = 0;


            if (listaTodasPlantas != null && listaTodasFotos != null)
            {
                listaPlanta = listaTodasPlantas.Where(c => c.Nome == lsPlanta.SelectedItem.ToString()).ToList();
                listaFoto = listaTodasFotos.Where(c => c.IdPlanta == listaPlanta[0].Id).ToList();
            }
            else
            {
                listaTodasPlantas = nPlantas.selPlantas(null);
                listaTodasFotos = nFotos.selFotos(null);

                listaPlanta = listaTodasPlantas.Where(c => c.Nome == lsPlanta.SelectedItem.ToString()).ToList();
                listaFoto = listaTodasFotos.Where(c => c.IdPlanta == listaPlanta[0].Id).ToList();
            }


            if (!string.IsNullOrEmpty(tbPlantaEdtNome.Text) && float.TryParse(tbPlantaEdtPreco.Text, out Preco) == true
                && int.TryParse(tbPlantaEdtQtd.Text, out qtd) == true && (rbPlantaEdtNao.Checked || rbPlantaEdtSim.Checked))
            {
                ePlantas planta = new ePlantas();

                planta.Id = listaPlanta[0].Id;
                planta.Nome = tbPlantaEdtNome.Text;
                planta.Preco = Preco.ToString();
                planta.Qtd = qtd;
                planta.Status = true;
                if (rbPlantaEdtNao.Checked == true)
                    planta.Especial = false;
                else if (rbPlantaEdtSim.Checked == true)
                    planta.Especial = true;

                nPlantas.insPlantas(planta);
                eFotos foto = new eFotos();
                string fileName = string.Empty;
                try
                {
                    fileName = Path.GetFileName(pbPlantaImg.ImageLocation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pegar arquivo imagem \n\n", ex.Message);
                }

                caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\";

                if (!File.Exists(caminho + fileName))
                    File.Copy(pbPlantaImg.ImageLocation, caminho + fileName);

                foto.Caminho = caminho + fileName;

                foto.IdPlanta = planta.Id;
                foto.Id = listaFoto[0].Id;
                foto.Status = true;
                if (nFotos.insFotos(foto))
                {
                    MessageBox.Show("Edição efetuada com Sucesso", "Edição sucedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaTodasPlantas = nPlantas.selPlantas(null);
                    listaTodasFotos = nFotos.selFotos(null);
                    limparTudo(true);
                    preencherLista(tbPlantaEdtNome.Text);
                }
                else
                    MessageBox.Show("Falha ao Editar", "Falha na Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Há campos invalido", "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPlantaDeletar_Click(object sender, EventArgs e)
        {
            limparTudo(true);
            limparTudo(false);

            if (lsPlanta.Items.Count > 0)
            {
                if (listaTodasPlantas.Exists(c => c.Nome == lsPlanta.SelectedItem.ToString()))
                {
                    listaPlanta = listaTodasPlantas.Where(c => c.Nome == lsPlanta.SelectedItem.ToString()).ToList();

                    if (listaPlanta.Count != 1)
                    {
                        MessageBox.Show("Não é possível excluir porque a duas Plantas com o mesmo nome\n Por favor contate o desenvovedor \n\t (11) 94419-9555");
                    }else
                    {
                        if (listaTodasFotos.Exists(c => c.IdPlanta == listaPlanta[0].Id))
                        {
                            listaFoto = listaTodasFotos.Where(c => c.IdPlanta == listaPlanta[0].Id).ToList();

                            if (listaFoto.Count != 1)
                            {
                                MessageBox.Show("Não é possível excluir porque a duas Plantas com o mesmo nome\n Por favor contate o desenvovedor \n\t (11) 94419-9555");
                            }
                            else
                            {
                                if (nPlantas.delPlantas(listaPlanta[0].Id, listaFoto[0].Id))
                                {
                                    MessageBox.Show("Dado Excluido com sucesso");
                                    limparTudo(true);
                                    limparTudo(false);
                                    listaTodasFotos = null;
                                    listaTodasPlantas = null;
                                    preencherLista(null);
                                }
                            }
                        }else
                        {
                            listaTodasFotos = nFotos.selFotos(null);
                            MessageBox.Show("Por favor, tente excluir novamente.");
                        }
                    }
                }
                else
                {
                    listaTodasPlantas = nPlantas.selPlantas(null);
                    MessageBox.Show("Por favor, tente excluir novamente.");
                }
            }
        }

        #region Metodos Planta
        private void selecionarPlantas(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (listaTodasPlantas != null)
                    listaPlanta = listaTodasPlantas.Where(c => c.Nome == nome).ToList();
                else
                    listaPlanta = nPlantas.selPlantas(nome);

                if (listaPlanta.Count.Equals(1))
                {
                    tbPlantaEdtNome.Text = listaPlanta[0].Nome;
                    tbPlantaEdtPreco.Text = listaPlanta[0].Preco;
                    tbPlantaEdtQtd.Text = listaPlanta[0].Qtd.ToString();
                    if (listaPlanta[0].Especial)
                    {
                        rbPlantaEdtSim.Checked = true;
                        rbPlantaEdtNao.Checked = false;
                    }
                    else
                    {
                        rbPlantaEdtNao.Checked = true;
                        rbPlantaEdtSim.Checked = false;
                    }

                    List<eFotos> listaFotos = new List<eFotos>();
                    if (listaTodasFotos != null)
                        listaFotos = listaTodasFotos.Where(c => c.IdPlanta == listaPlanta[0].Id).ToList();
                    else
                        listaFotos = nFotos.selFotos(listaPlanta[0].Id);
                    if (listaFotos.Count == 1)
                    {
                        caminho = listaFotos[0].Caminho;
                        pbPlantaImg.Load(caminho);
                    }

                    lsPlanta.SelectedItem = listaPlanta[0].Nome;
                }
            }
            else
            {
                if (lsPlanta.Items.Count > 0)
                    lsPlanta.SelectedIndex = 0;
            }
        }

        private void preencherLista(string nomeSeleciona)
        {
            lsPlanta.Items.Clear();
            if (listaTodasPlantas != null && listaTodasFotos != null)
            {

                foreach (ePlantas planta in listaTodasPlantas)
                {
                    lsPlanta.Items.Add(planta.Nome);
                }
            }
            else
            {
                listaTodasPlantas = nPlantas.selPlantas(null);
                listaTodasFotos = nFotos.selFotos(null);
                foreach (ePlantas planta in listaTodasPlantas)
                {
                    lsPlanta.Items.Add(planta.Nome);
                }
            }

            if (lsPlanta.Items.Count > 0)
            {
                lsPlanta.SelectedIndex = 0;
                if (string.IsNullOrEmpty(nomeSeleciona))
                    selecionarPlantas(lsPlanta.SelectedItem.ToString());
                else
                    selecionarPlantas(nomeSeleciona);
            }
        }

        private void limparTudo(bool Cad)
        {
            if (Cad)
            {
                if (pbPlantaImg.ImageLocation != null)
                {
                    ofdImg.FileName = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg";
                    caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\";
                    pbPlantaImg.Load(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg");
                    isImg = false;
                }

                tbPlantasCadNome.Clear();
                tbPlantaCadPreco.Clear();
                tbPlantaCadQtd.Clear();
                tbPlantasCadNome.Focus();
            }
            else
            {
                if (pbPlantaImg.ImageLocation != null)
                {
                    ofdImg.FileName = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg";
                    caminho = @"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\";
                    pbPlantaImg.Load(@"E:\Projetos\AnotacoesDeCasa\Aplicação\FloriculturaImperial\FloriculturaImperial\ImgApp\img_nao_disponivel.jpg");
                    isImg = false;
                }

                tbPlantaEdtNome.Clear();
                tbPlantaEdtPreco.Clear();
                tbPlantaEdtQtd.Clear();
                tbPlantaEdtNome.Focus();
            }
        }


        #endregion

        #endregion

    }
}
