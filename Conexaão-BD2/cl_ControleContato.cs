using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Conexaão_BD2
{
    public class cl_ControleContato
    {
        cl_Conexao c = new cl_Conexao();

        public string cadastrar(cl_Contato cont)
        {
            try
            {
                string sql = "INSERT INTO tbContato (nome, telefone, celular, email) VALUES ('"+cont.Nome+"', '"+cont.Telefone+"', '"+cont.Celular+"', '"+cont.Email+"')";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                //abrindo a conexao
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Cadastro realizado com sucesso");
            }
            catch(MySqlException e)
            {
                return(e.ToString());
            }

        }

        public string alterar(cl_Contato cont)
        {
            try
            {
                string sql = "UPDATE tbContato set nome = '" + cont.Nome + "', email = '" + cont.Email + "', celular = '" + cont.Celular + "', telefone = '" + cont.Telefone + "' WHERE codContato = '" + cont.Codcontato + "'";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                //abrindo a conexão
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Dados alterados com sucesso");
            }
            catch(Exception e) 
            {
                return (e.ToString());
            }
            
        }

        public cl_Contato buscar(int codigo)
        {
            cl_Contato cont = new cl_Contato();

            try
            {
                string sql = "select codContato, nome, telefone, celular, email from tbContato where codContato = " + codigo+ ";";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    cont.Codcontato = Convert.ToInt32(objDados["codContato"]);
                    cont.Nome = objDados["nome"].ToString();
                    cont.Telefone = objDados["telefone"].ToString();
                    cont.Celular = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();

                    objDados.Close();
                    return cont;
                }
            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally
            {
                c.desconectar();
            }

        }

        public DataTable PreencherTodos()
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as Telefone, celular as Celular, email as Email from tbcontato;";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaCodigo(int codigo)
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as Telefone, celular as Celular, email as Email from tbcontato where codContato = "+codigo+";";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;

        }

        public DataTable pesquisaNome(string nomecontato)
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where nome like '%" +nomecontato+"%';";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaEmail(string email)
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where email like '%" + email + "%';";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaTelefone(string telefone)
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where telefone like '%" + telefone + "%';";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public DataTable pesquisaCelular(string celular)
        {
            string sql = "select codContato as 'Código', nome as 'Nome', telefone as 'Telefone', celular as 'Celular', email as 'Email' from tbcontato where celular like '%" + celular + "%';";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public string Backup(string caminho)
        {
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            string CaminhoBackup = caminho + "\\backupContatos " + dataAtual + ".sql";

            try
            {
                MySqlCommand cmd = new MySqlCommand(CaminhoBackup, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ExportToFile(CaminhoBackup);
                c.desconectar();
                return ("Backup do banco de dados realizado com sucesso");
            }
            catch (Exception e)
            {
                return (e.ToString());
            }
        }

        public string Restore(string Caminho)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Caminho, c.con);
                MySqlBackup mb = new MySqlBackup(cmd);
                c.conectar();
                mb.ImportFromFile(Caminho);
                c.desconectar();
                return ("Banco de dados restaurado com sucesso!");
            }
            catch (MySqlException e)
            {
                return(e.ToString());
            }
        }
    }
}
