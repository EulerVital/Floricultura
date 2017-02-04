using FloriculturaImperial.Camadas.DAO.Util;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FloriculturaImperial.Camadas.DAO
{
    public class dVendas
    {
        private SqlConnection objSqlConect;
        private SqlCommand objSqlCom;
        duConexao con;
        SqlDataReader dr;

        public bool insVendaProduto(eVendas venda)
        {
            bool gravou = false;
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_INS_VENDAS_PRODUTOS";

            if (venda.Id == 0)
                objSqlCom.Parameters.AddWithValue("@Id", null);
            else
                objSqlCom.Parameters.AddWithValue("@Id", venda.Id);

            objSqlCom.Parameters.AddWithValue("@Produto", venda.Produto);
            objSqlCom.Parameters.AddWithValue("@Preco", venda.Preco);
            objSqlCom.Parameters.AddWithValue("@QtdVendidas", venda.QtdVendidas);
            objSqlCom.Parameters.AddWithValue("@QtdEstocadas", venda.QtdEstocadas);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            try
            {
                if (objSqlCom.ExecuteNonQuery() > 0)
                    gravou = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão \n" + ex.Message);
            }
            finally
            {
                objSqlConect.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
            }

            return gravou;
        }

        public bool insVendaTotal(eVendas venda)
        {
            bool gravou = false;
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_INS_VENDAS_TOTAIS";

            if (venda.Id == 0)
                objSqlCom.Parameters.AddWithValue("@Id", null);
            else
                objSqlCom.Parameters.AddWithValue("@Id", venda.Id);

            objSqlCom.Parameters.AddWithValue("@Produto", venda.ProdutoXml);
            objSqlCom.Parameters.AddWithValue("@PrecoTotal", venda.PrecoTotal);
            objSqlCom.Parameters.AddWithValue("@QtdProdutos", venda.QtdProdutos);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            try
            {
                if (objSqlCom.ExecuteNonQuery() > 0)
                    gravou = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão \n" + ex.Message);
            }
            finally
            {
                objSqlConect.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
            }

            return gravou;
        }
    }
}
