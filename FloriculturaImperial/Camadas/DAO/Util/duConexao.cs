using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FloriculturaImperial.Camadas.DAO.Util
{
    class duConexao
    {
        private string strCon;
        private string strvle;

        public string Strvle
        {
            get { return strvle; }
            set { strvle = value; }
        }

        public duConexao()
        {
            strCon = ("Data Source=DESKTOP-URPHR1B\\SQLEXPRESS;" +
                "Initial Catalog=Floricultura_Imperial;" + 
                "Integrated security=true");
        }

        public SqlConnection abrirConexao()
        {
            SqlConnection con = new SqlConnection(strCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar ao banco de dados \nDescrição do Erro: \n" + ex.Message);
            }

            return con;
        }
    }
}
