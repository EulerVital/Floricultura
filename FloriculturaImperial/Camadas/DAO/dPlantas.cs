using FloriculturaImperial.Camadas.DAO.Util;
using FloriculturaImperial.Camadas.ENT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FloriculturaImperial.Camadas.DAO
{
    class dPlantas
    {
        private SqlConnection objSqlConect;
        private SqlCommand objSqlCom;
        duConexao con;
        IDataReader dr;

        public int insPlantas(ePlantas planta)
        {
            int idRetorno = 0;
            objSqlConect = new SqlConnection();
            objSqlCom = new SqlCommand();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_INS_PLANTAS";

            if(planta.Id == 0)
                objSqlCom.Parameters.AddWithValue("@Id", null);
            else
                objSqlCom.Parameters.AddWithValue("@Id", planta.Id);

            objSqlCom.Parameters.AddWithValue("@Nome", planta.Nome);
            objSqlCom.Parameters.AddWithValue("@Preco", float.Parse(planta.Preco));
            objSqlCom.Parameters.AddWithValue("@Qtd", planta.Qtd);
            objSqlCom.Parameters.AddWithValue("@Especial", planta.Especial);
            objSqlCom.Parameters.AddWithValue("@Status", planta.Status);
            objSqlCom.Parameters.Add("@Id_Retorno", SqlDbType.Int).Direction = ParameterDirection.Output;

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            try
            {
                objSqlCom.ExecuteNonQuery();
                idRetorno = int.Parse(objSqlCom.Parameters["@Id_Retorno"].Value.ToString());
            }
            catch (Exception ex)
            {
                if(!idRetorno.Equals(0))
                    MessageBox.Show("Erro de Conexão \n" + ex.Message);
            }
            finally
            {
                objSqlConect.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
            }

            return idRetorno;
        }

        public ePlantas SetarObjeto(IDataReader dr)
        {
            ePlantas planta = new ePlantas();

            planta.Id = Convert.ToInt32(dr["Id"]);
            planta.Nome = dr["Nome"].ToString();
            planta.Preco = dr["Preco"].ToString();
            planta.Qtd = Convert.ToInt32(dr["Qtd"]);
            planta.NomeEspecial = dr["EspecialNome"].ToString();
            planta.Especial = Convert.ToBoolean(dr["Especial"]);
            planta.Status = Convert.ToBoolean(dr["Status"]);

            return planta;
        }

        public List<ePlantas> selPlantas(string nome)
        {
            List<ePlantas> lista = new List<ePlantas>();

            objSqlConect = new SqlConnection();
            objSqlCom = new SqlCommand();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_SEL_PLANTAS";

            objSqlCom.Parameters.AddWithValue("@Nome", nome);
            objSqlCom.Parameters.AddWithValue("@Id", null);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            dr = objSqlCom.ExecuteReader();

            try
            {
                while (dr.Read())
                    lista.Add(SetarObjeto(dr));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Conexão \n" + ex.Message);
            }
            finally
            {
                dr.Close();
                objSqlConect.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
            }

            return lista;
        }

        public bool delPlanta(int? idPlanta, int? idFoto)
        {
            bool deletou = false;

            objSqlConect = new SqlConnection();
            objSqlCom = new SqlCommand();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_DEL_PLANTA_FOTO";

            objSqlCom.Parameters.AddWithValue("@idPlanta", idPlanta);
            objSqlCom.Parameters.AddWithValue("@idFoto", idFoto);

            objSqlConect = con.abrirConexao();
            objSqlCom.Connection = objSqlConect;

            try
            {
                if (objSqlCom.ExecuteNonQuery() > 0)
                    deletou = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlConect.Dispose();
                objSqlConect.Close();
                objSqlConect = null;
            }

            return deletou;
        }
    }
}
