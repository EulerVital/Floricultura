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
    public partial class ucMontarCesta : UserControl
    {

        List<ePlantas> listaPlantasDisponiveis = new List<ePlantas>();
        List<ePlantas> listaPlantasExisteNaCesta = new List<ePlantas>();
        public ucMontarCesta()
        {
            InitializeComponent();
            popularListaPlantas();
        }

        #region Metodos

        private void popularListaPlantas() //Lista as plantas de acordo com o filtro passado.
        {
            listaPlantasDisponiveis = nPlantas.selPlantas(null);
            lstPlantas.Items.Clear();

            if (rdbTodos.Checked)
            {
                foreach(var planta in listaPlantasDisponiveis)
                    lstPlantas.Items.Add(planta.Nome);

                lblDescricaoTipo.Text = "Retorna todas as plantas Disponiveis no sistema";

            }else if (rdbSimples.Checked)
            {
                var listaSimples = listaPlantasDisponiveis.Where(c => c.Especial == false).ToList();
                foreach (var planta in listaSimples)
                    lstPlantas.Items.Add(planta.Nome);

                lblDescricaoTipo.Text = "Retorna apenas as plantas Simples disponíveis no sistema";
            }
            else if (rdbEspeciais.Checked)
            {
                var listaEspecial = listaPlantasDisponiveis.Where(c => c.Especial == true).ToList();
                foreach (var planta in listaEspecial)
                    lstPlantas.Items.Add(planta.Nome);

                lblDescricaoTipo.Text = "Retorna apenas as plantas Especiais disponíveis no sistema";
            }
        }

        private bool colocarNaCesta()// O Usuário seleciona as plantas disponiveis e automaticamente é acrecentada na cesta. 
        {
            List<ePlantas> listaSelecionados = new List<ePlantas>();
            ePlantas planta = new ePlantas();
            bool retorno = false;

            //1º Passo
            //Adicionado os selecionados na lista

            if (lstPlantas.SelectedItems.Count > 0)
            {
                for(int i = 0; i < lstPlantas.SelectedItems.Count; i++)
                {
                    if (listaPlantasDisponiveis.Count > 0)
                    {
                        try
                        {
                            listaSelecionados.Add(listaPlantasDisponiveis.Where(c => c.Nome == lstPlantas.SelectedItems[i].ToString()).FirstOrDefault());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Contate o Administrador Erro na Control ucMontarCestas: /n/n  " + ex.Message);
                        }
                    }
                }
            }

            //2º Passo
            //Adicionanado na lista.

            foreach(var plan in listaSelecionados)
                listaPlantasExisteNaCesta.Add(plan);

            //3º Passo
            //Adicionando na cestas.

            lstCestaPlantas.Items.Clear();

            foreach(var plan in listaPlantasExisteNaCesta.Distinct())
            {
                int count = 0;

                if(listaPlantasExisteNaCesta.Count(c=>c.Nome == plan.Nome) > 1)
                {
                    count = listaPlantasExisteNaCesta.Count(c => c.Nome == plan.Nome);

                    if(!lstCestaPlantas.Items.Contains(plan.Nome + " " + count + "X"))
                        lstCestaPlantas.Items.Add(plan.Nome + " " + count + "X");
                }else
                {
                    lstCestaPlantas.Items.Add(plan.Nome);
                }
                
            }

            //4º Passo
            //Verifica se houve alguma planta adicionado na cesta e calculando o total

            if (lstCestaPlantas.Items.Count > 0)
            {
                retorno = true;

                float precoDaCesta = 0;

                for(int i = 0; i < listaPlantasExisteNaCesta.Count; i++)
                {
                    try
                    {
                        precoDaCesta += float.Parse(listaPlantasExisteNaCesta[i].Preco);
                    }
                    catch{ }
                }

                txtPreco.Text = "R$ " + string.Format("{0:N2}", precoDaCesta);
            }
                

            return retorno;
        }

        private void removeDaCesta()// O Usuário seleciona as plantas da cesta e remove
        {
            if(lstCestaPlantas.Items.Count > 0 && listaPlantasExisteNaCesta.Count > 0)
            {
                for(int i = 0; i < lstCestaPlantas.SelectedItems.Count; i++)
                {

                }
            }
        }

        #endregion

        #region Eventos
        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            popularListaPlantas();
        }

        private void rdbSimples_CheckedChanged(object sender, EventArgs e)
        {
            popularListaPlantas();
        }

        private void rdbEspeciais_CheckedChanged(object sender, EventArgs e)
        {
            popularListaPlantas();
        }

        private void lstPlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnBotoes.Visible = true;
        }

        private void btnIncluirNaCesta_Click(object sender, EventArgs e)
        {
            if (colocarNaCesta())
            {
                btnSalvar.Visible = true;
                btnRemover.Visible = true;
                for(int i = 0; i < lstPlantas.Items.Count; i++)
                {
                    lstPlantas.SetSelected(i, false);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            removeDaCesta();
        }

        #endregion
    }
}
