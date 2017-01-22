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
    class dFotos
    {
        private SqlConnection objSqlConect;
        private SqlCommand objSqlCom;
        duConexao con;
        IDataReader dr;

        public bool insFotos(eFotos foto)
        {
            bool gravou = false;
            objSqlConect = new SqlConnection();
            objSqlCom = new SqlCommand();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_INS_FOTO_PLANTA";
            if (foto.Id == 0)
                objSqlCom.Parameters.AddWithValue("@Id", null);
            else
                objSqlCom.Parameters.AddWithValue("@Id", foto.Id);
            objSqlCom.Parameters.AddWithValue("@Caminho", foto.Caminho);
            objSqlCom.Parameters.AddWithValue("@Status", foto.Status);
            objSqlCom.Parameters.AddWithValue("@IdPlanta", foto.IdPlanta);

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

        public eFotos SetarObjeto(IDataReader dr)
        {
            eFotos foto = new eFotos();

            foto.Id = Convert.ToInt32(dr["Id"]);
            foto.Caminho = dr["Caminho"].ToString();
            foto.Status = Convert.ToBoolean(dr["Status"]);
            foto.IdPlanta = Convert.ToInt32(dr["IdPlanta"]);

            return foto;
        }
        public List<eFotos> selFotos(int? idPlanta)
        {
            List<eFotos> lista = new List<eFotos>();

            objSqlConect = new SqlConnection();
            objSqlCom = new SqlCommand();
            con = new duConexao();

            objSqlCom.CommandType = CommandType.StoredProcedure;
            objSqlCom.CommandText = "USP_SEL_FOTO_PLANTA";

            objSqlCom.Parameters.AddWithValue("@IdPlanta", idPlanta);

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
    }
}
