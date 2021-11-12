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
    class Dao_TipoQuarto
    {
        NpgsqlConnection conexao;

        public Dao_TipoQuarto()
        {
            //string conexao BD AZURE
            //conexao = new NpgsqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(TipoQuarto TipoQuarto)
        {
            string comandoSql = "INSERT INTO tbl_TipoQuarto (Tipo, Qtd_Hospede, Valor_Diaria, Refeicao) VALUES (@TIPO, @QTD_HOSPEDE, @VALOR_DIARIA, @REFEICAO)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
            comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
            comando.Parameters.AddWithValue("VALOR_DIARIA", TipoQuarto.Valor_Diaria);
            comando.Parameters.AddWithValue("REFEICAO", TipoQuarto.Refeicao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Tipo Quarto Cadastrado com sucesso!!!", "Tipo de Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update(TipoQuarto TipoQuarto)
        {
            string comandoSql = "UPDATE tbl_tipoQuarto SET Tipo = @TIPO, Qtd_Hospede = @QTD_HOSPEDE, Valor_Diaria = @VALOR_DIARIA, Refeicao = @REFEICAO WHERE Tipo = @TIPO";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
            comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
            comando.Parameters.AddWithValue("VALOR_DIARIA", TipoQuarto.Valor_Diaria);
            comando.Parameters.AddWithValue("REFEICAO", TipoQuarto.Refeicao);

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

        public void Delete(TipoQuarto TipoQuarto)
        {
            string comandoSql = "DELETE FROM tbl_tipoQuarto WHERE Tipo = @TIPO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Tipo Quarto apagado com sucesso!!!");
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
        //Carrega Lista Tipo Quarto
        public List<TipoQuarto> CarregarLista_TipoQuarto()
        {
            string comandoSql = "SELECT * FROM tbl_TipoQuarto";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<TipoQuarto> ListaTipoQuarto = new List<TipoQuarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new TipoQuarto()
                    {
                        Tipo = Convert.ToString(rd["TIPO"]),
                        Qtd_Max = Convert.ToInt32(rd["QTD_HOSPEDE"]),
                        Valor_Diaria = Convert.ToDouble(rd["VALOR_DIARIA"]),
                        Refeicao = Convert.ToString(rd["REFEICAO"]),
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
        public List<TipoQuarto> BuscarLista_TipoQuarto(string ParamWhere, string ParamBusca)
        {
            string comandoSql = "SELECT * FROM tbl_TipoQuarto WHERE " + ParamBusca + " LIKE '%" + ParamWhere + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<TipoQuarto> ListaTipoQuarto = new List<TipoQuarto>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new TipoQuarto()
                    {
                        Tipo = Convert.ToString(rd["TIPO"]),
                        Qtd_Max = Convert.ToInt32(rd["QTD_HOSPEDE"]),
                        Valor_Diaria = Convert.ToDouble(rd["VALOR_DIARIA"]),
                        Refeicao = Convert.ToString(rd["REFEICAO"]),
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
    }
}
