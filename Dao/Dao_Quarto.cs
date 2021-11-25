using Npgsql;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Dao
{
    class Dao_Quarto
    {
        NpgsqlConnection conexao;

        public Dao_Quarto()
        {
            //string conexao BD AZURE
            //conexao = new NpgsqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(Quarto Quarto)
        {
            string comandoSql = "INSERT INTO tbl_Quarto (Numero, Andar, Status, Tipo_Quarto, Situacao, Autor) VALUES (@NUMERO, @ANDAR, @STATUS, @TIPO_QUARTO, @SITUACAO, @AUTOR)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUMERO", Quarto.Numero);
            comando.Parameters.AddWithValue("@ANDAR", Quarto.Andar);
            comando.Parameters.AddWithValue("@STATUS", Quarto.Status);
            comando.Parameters.AddWithValue("@TIPO_QUARTO", Quarto.Tipo);
            comando.Parameters.AddWithValue("@SITUACAO", Quarto.Situacao);
            comando.Parameters.AddWithValue("@AUTOR", Quarto.Id_UserLogado);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Quarto Cadastrado com sucesso!!!", "Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update(Quarto Quarto)
        {
            string comandoSql = "UPDATE tbl_Quarto SET Numero = @NUMERO, Andar = @ANDAR, Status = @STATUS, Situacao = @SITUACAO, Tipo_Quarto = @TIPO_QUARTO, Autor = @Autor WHERE Numero = @NUMERO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUMERO", Quarto.Numero);
            comando.Parameters.AddWithValue("@ANDAR", Quarto.Andar);
            comando.Parameters.AddWithValue("STATUS", Quarto.Status);
            comando.Parameters.AddWithValue("TIPO_QUARTO", Quarto.Tipo);
            comando.Parameters.AddWithValue("@SITUACAO", Quarto.Situacao);
            comando.Parameters.AddWithValue("@AUTOR", Quarto.Id_UserLogado);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!!!", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete(Quarto Quarto)
        {
            string comandoSql = "DELETE FROM tbl_Quarto WHERE Numero = @NUMERO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUMERO", Quarto.Numero);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Quarto deletado com sucesso!!!");
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

        public List<Quarto> CarregarLista_Quarto()
        {
            string comandoSql = "SELECT * FROM tbl_Quarto";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Quarto> ListaQuarto = new List<Quarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaQuarto.Add(new Quarto()
                    {
                        Numero = Convert.ToString(rd["NUMERO"]),
                        Andar = Convert.ToString(rd["ANDAR"]),
                        Status = Convert.ToString(rd["STATUS"]),
                        Tipo = Convert.ToString(rd["TIPO_QUARTO"]),
                        Situacao = Convert.ToString(rd["SITUACAO"])
                    }); ;

                }
                if (ListaQuarto.Count() > 0)
                {
                    return ListaQuarto;
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

        public List<Quarto> BuscarLista_Quarto(Quarto Quarto)
        {
            string comandoSql = "SELECT * FROM tbl_Quarto WHERE Numero LIKE '%" + Quarto.Numero + "%' OR Andar LIKE '%" + Quarto.Andar + "%' OR Status LIKE '%" + Quarto.Status + "%' OR Situacao LIKE '%" + Quarto.Situacao + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<Quarto> ListaQuarto = new List<Quarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaQuarto.Add(new Quarto()
                    {
                        Numero = Convert.ToString(rd["NUMERO"]),
                        Andar = Convert.ToString(rd["ANDAR"]),
                        Status = Convert.ToString(rd["STATUS"]),
                        Tipo = Convert.ToString(rd["TIPO_QUARTO"]),
                        Situacao = Convert.ToString(rd["SITUACAO"])
                    }); ;

                }
                if (ListaQuarto.Count() > 0)
                {
                    return ListaQuarto;
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
        public List<Quarto> Buscar_ListaTipoQuarto()
        {
            string comandoSql = "SELECT TIPO FROM tbl_TipoQuarto order by TIPO desc";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Quarto> ListaTipoQuarto = new List<Quarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new Quarto()
                    {
                        Tipo = Convert.ToString(rd["TIPO"])                        
                    }); ;

                }
                if (ListaTipoQuarto.Count() > 0)
                {
                    return ListaTipoQuarto;
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
        public List<Quarto> Obter_QtdHospede_ValorDiaria(Quarto Quarto)
        {
            string comandoSql = "SELECT QTD_HOSPEDE, VALOR_DIARIA FROM tbl_TipoQuarto WHERE TIPO LIKE '%" + Quarto.Tipo + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Quarto> ListaTipoQuarto = new List<Quarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new Quarto()
                    {
                        Qtd_Max = Convert.ToInt32(rd["QTD_HOSPEDE"]),
                        Valor_Diaria = Convert.ToDouble(rd["VALOR_DIARIA"]),
                    }); ;

                }
                if (ListaTipoQuarto.Count() > 0)
                {
                    return ListaTipoQuarto;
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

        public int Verif_SituacaoQuarto(Quarto Quarto)
        {
            int aux = 0;
            string comandoSql = "SELECT COUNT(*) FROM TBL_RESERVA WHERE Quarto_Numero = @NUM_QUARTO";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUM_QUARTO", Quarto.Numero);

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    aux = rd.GetInt32(0);
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
            return aux;
        }
    }
}
