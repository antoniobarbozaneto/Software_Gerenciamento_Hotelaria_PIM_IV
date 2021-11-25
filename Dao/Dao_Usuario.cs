using Npgsql;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Dao
{
    class Dao_Usuario
    {
        NpgsqlConnection conexao;
        public Dao_Usuario()
        {
            //string conexao BD AZURE
            //conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(Usuario Usuario)
        {
            string comandoSql = "INSERT INTO tbl_Usuario (Usuario, Senha) VALUES (@USUARIO, @SENHA)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
            comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado com sucesso!!!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Usuario Usuario)
        {
            string comandoSql = "UPDATE tbl_Usuario SET Usuario = @USUARIO, Senha = @SENHA WHERE Id_Usuario = @ID_USUARIO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);
            comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
            comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!!!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Usuario Usuario)
        {
            string comandoSql = "DELETE FROM tbl_Usuario WHERE Id_Usuario = @ID_USUARIO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário deletado com sucesso!!!", "Exclusão de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        //Carrega Lista Usuarios
        public List<Usuario> CarregarLista_Usuario()
        {
            string comandoSql = "SELECT * FROM tbl_Usuario";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Usuario> ListaUsuario = new List<Usuario>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaUsuario.Add(new Usuario()
                    {
                        Id = Convert.ToInt32(rd["ID_Usuario"]),
                        User = Convert.ToString(rd["USUARIO"]),
                        Senha = Convert.ToString(rd["SENHA"]),
                    }); ;

                }
                if (ListaUsuario.Count() > 0)
                {
                    return ListaUsuario;
                }
                else
                {
                    return null;
                }

            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        //
        public List<Usuario> BuscarLista_Usuario(Usuario Usuario)
        {
            string comandoSql = "SELECT * FROM tbl_Usuario WHERE  Id_Usuario = " + Usuario.Id + " OR Usuario LIKE '%" + Usuario.User + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<Usuario> ListaUsuario = new List<Usuario>();
            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaUsuario.Add(new Usuario()
                    {
                        Id = Convert.ToInt32(rd["ID_USUARIO"]),
                        User = Convert.ToString(rd["USUARIO"]),
                        Senha = Convert.ToString(rd["SENHA"]),
                    }); ;

                }
                if (ListaUsuario.Count() > 0)
                {
                    return ListaUsuario;
                }
                else
                {
                    return null;
                }

            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        //
        public bool Logar(Usuario Usuario)
        {
            bool resp;

            string comandoSql = "SELECT * FROM tbl_Usuario WHERE Usuario = @USUARIO AND SENHA = @SENHA";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
            comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                if (rd.HasRows)
                {
                    return resp = true;
                }
                else
                {
                    return resp = false;
                }
            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
                return resp = false;
            }
            finally
            {
                conexao.Close();
            }
        }
        public int Buscar_Id_User(Usuario Usuario)
        {
            int Id_Usuario = 0;
            string comandoSql = "SELECT id_Usuario FROM tbl_Usuario WHERE Usuario = @USUARIO";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@USUARIO", Usuario.User);

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Id_Usuario = rd.GetInt32(0);
                }
            }
            catch (NpgsqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
            return Id_Usuario;
        }
    }
}
