using FloriculturaImperial.Camadas.DAO.Util;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloriculturaImperial.Camadas.DAO
{
    public class dRelatorio
    {
        private SqlConnection objSqlConect;
        private SqlCommand objSqlCom;
        duConexao con;
        SqlDataReader dr;

        public bool insRelatoriosSalvos(int? id, string listaIds, bool? Excluido)
        {
            bool gravou = false;
            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_INS_RELATORIOS_SALVOS";

            objSqlCom.Parameters.AddWithValue("@Id", id);
            objSqlCom.Parameters.AddWithValue("@listaIds", listaIds);
            objSqlCom.Parameters.AddWithValue("@Excluido", Excluido);

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

        public List<eRelatorio> selRelatoriosSalvos(int? id, string listaIds, bool? Excluido)
        {
            List<eRelatorio> lista = new List<eRelatorio>();

            objSqlCom = new SqlCommand();
            objSqlConect = new SqlConnection();
            con = new duConexao();

            objSqlCom.CommandText = "USP_SEL_VENDAS";
            objSqlCom.CommandType = CommandType.StoredProcedure;

            objSqlCom.Parameters.AddWithValue("@Id", id);
            objSqlCom.Parameters.AddWithValue("@listaIds", listaIds);
            objSqlCom.Parameters.AddWithValue("@Excluido", Excluido);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            dr = objSqlCom.ExecuteReader();

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                        lista.Add(SetarObjeto(dr));
                }
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

            return lista;
        }

        private eRelatorio SetarObjeto(SqlDataReader dr)
        {
            eRelatorio relatorio = new eRelatorio();

            relatorio.Id = Convert.ToInt32(dr["Id"]);
            relatorio.ListaIds = dr["listaIds"].ToString();
            relatorio.Excluido = Convert.ToBoolean(dr["Excluido"]);
            relatorio.Data = Convert.ToDateTime(dr["DataCriacao"]);

            return relatorio;
        }
    }
}
