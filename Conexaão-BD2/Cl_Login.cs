using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexaão_BD2
{
    public class Cl_Login
    {
        cl_Conexao c = new cl_Conexao();

        public bool Login(string l, string s)
        {
            try
            {
                string sql = "select login, senha from tbLogin where login like '%"+l+"%' and senha like '"+s+"';";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();

                if(!objDados.HasRows)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                throw (e);
            }
            finally
            {
                c.desconectar();
            }
        }
    }
}
