using FloriculturaImperial.Camadas.DAO.Util;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
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
        
        public List<eVendas> selVendas(eVendas venda)
        {
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();
            List<eVendas> lista = new List<eVendas>();

            objSqlCom.CommandText = "USP_SEL_VENDAS";
            objSqlCom.CommandType = CommandType.StoredProcedure;

            if (venda.Id == 0)
              objSqlCom.Parameters.AddWithValue("@Id", null);
            else
              objSqlCom.Parameters.AddWithValue("@Id", venda.Id);
            
            objSqlCom.Parameters.AddWithValue("@Produto", venda.Produto);

            if (venda.Preco == 0)
                objSqlCom.Parameters.AddWithValue("@Preco", null);
            else
                objSqlCom.Parameters.AddWithValue("@Preco", venda.Preco);
            
            if (venda.QtdVendidas == 0)
                objSqlCom.Parameters.AddWithValue("@QtdVendidas", null);
            else
                objSqlCom.Parameters.AddWithValue("@QtdVendidas", venda.QtdVendidas);

            if (venda.QtdEstocadas == 0)
                objSqlCom.Parameters.AddWithValue("@QtdEstocada", null);
            else
                objSqlCom.Parameters.AddWithValue("@QtdEstocada", venda.QtdEstocadas);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            dr = objSqlCom.ExecuteReader();

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                       lista.Add(SetarObjetoVendas(venda, dr));
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objSqlCom.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
                objSqlCom = null;
            }
        }

        private eVendas SetarObjetoVendas(eVendas venda, SqlDataReader dr)
        {
            eVendas ItensVendas = new eVendas();

            ItensVendas.Id = Convert.ToInt32(dr["Codigo"]);
            ItensVendas.Produto = dr["Produto"].ToString();
            ItensVendas.Preco = Convert.ToDecimal(dr["Preco"].ToString());
            ItensVendas.QtdVendidas = Convert.ToInt32(dr["QtdVendidas"]);
            ItensVendas.PorcentVendias = dr["PorcentVendas"].ToString();
            ItensVendas.QtdEstocadas = Convert.ToInt32(dr["QtdEstocada"]);
            ItensVendas.PorcentEstdocada = dr["PorcentEstocada"].ToString();

            return ItensVendas;
        }

        public List<eVendas> selProdutosVendidos(int? id, string produto)
        {
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();
            List<eVendas> lista = new List<eVendas>();

            objSqlCom.Parameters.AddWithValue("@Id", id);
            objSqlCom.Parameters.AddWithValue("@Produto", produto);

            objSqlCom.CommandText = "USP_SEL_PRODUTOS_VENDIDOS";
            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            dr = objSqlCom.ExecuteReader();

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                        lista.Add(SetarObjetoProdutosVendidos(dr));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objSqlCom.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
                objSqlCom = null;
            }

        }

        private eVendas SetarObjetoProdutosVendidos(SqlDataReader dr)
        {
            eVendas vend = new eVendas();

            vend.Id = Convert.ToInt32(dr["Codigo"]);
            vend.Produto = dr["Produto"].ToString();
            vend.Preco = Convert.ToDecimal(dr["Preco"]);
            vend.QtdVendidas = Convert.ToInt32(dr["QtdVendidas"]);
            vend.QtdEstocadas = Convert.ToInt32(dr["QtdEstocada"]);
            vend.Data = Convert.ToDateTime(dr["Data"]);

            return vend;
        }

        public List<eVendas> selRelatorioVendas(DateTime? dataAte, DateTime? dataDe, string nomeProd, int? qtdMaior, decimal? preco, string ids)
        {
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();
            List<eVendas> lista = new List<eVendas>();

            objSqlCom.CommandText = "USP_SEL_RELATORIO_VENDAS";
            objSqlCom.CommandType = CommandType.StoredProcedure;

            objSqlCom.Parameters.AddWithValue("@Id", null);
            objSqlCom.Parameters.AddWithValue("@Produtos", nomeProd);
            objSqlCom.Parameters.AddWithValue("@PrecoTotal", preco);
            objSqlCom.Parameters.AddWithValue("@QtdProdutos", qtdMaior);
            objSqlCom.Parameters.AddWithValue("@DataDe", dataDe);
            objSqlCom.Parameters.AddWithValue("@DataAte", dataAte);
            objSqlCom.Parameters.AddWithValue("@listaIds", ids);


            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            dr = objSqlCom.ExecuteReader();

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                        lista.Add(SetarObjetoRelatorio(dr));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objSqlCom.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
                objSqlCom = null;
            }
        }

        private eVendas SetarObjetoRelatorio(SqlDataReader dr)
        {
            eVendas venda = new eVendas();

            venda.Id = int.Parse(dr["Codigo"].ToString());
            venda.ProdutoXml = dr["Produtos"].ToString();
            venda.PrecoTotal = decimal.Parse(dr["PrecoTotal"].ToString());
            venda.QtdVendidas = int.Parse(dr["QtdProdutos"].ToString());
            venda.Data = Convert.ToDateTime(dr["Data"]);

            return venda;
        }

        
    }
}
