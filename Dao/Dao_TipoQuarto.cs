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
        SqlConnection conexao;

        public Dao_TipoQuarto()
        {
            //string conexao BD AZURE
            conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        }

        public void Create(TipoQuarto TipoQuarto)
        {
            string comandoSql = "INSERT INTO tbl_TipoQuarto (Tipo, Qtd_Hospede, ValorDiaria, Refeicao) VALUES (@TIPO, @QTD_HOSPEDE, @VALORDIARIA, @REFEICAO)";

            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_TIPOQUARTO", TipoQuarto.Id_TipoQuarto);
            comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
            comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
            comando.Parameters.AddWithValue("VALORDIARIA", TipoQuarto.Valor_Diaria);
            comando.Parameters.AddWithValue("REFEICAO", TipoQuarto.Refeicao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Tipo Quarto Cadastrado com sucesso!!!", "Tipo de Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
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
            string comandoSql = "UPDATE tbl_tipoQuarto SET Tipo = @TIPO, Qtd_Hospede = @QTD_HOSPEDE, ValorDiaria = @VALORDIARIA, Refeicao = @REFEICAO WHERE Id_TipoQuarto = @ID_TIPOQUARTO";
            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_TIPOQUARTO", TipoQuarto.Id_TipoQuarto);
            comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
            comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
            comando.Parameters.AddWithValue("VALORDIARIA", TipoQuarto.Valor_Diaria);
            comando.Parameters.AddWithValue("REFEICAO", TipoQuarto.Refeicao);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!!!", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
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
            string comandoSql = "DELETE tbl_tipoQuarto WHERE Id_TipoQuarto = @ID_TIPOQUARTO";

            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_TIPOQUARTO", TipoQuarto.Id_TipoQuarto);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Tipo Quarto apagado com sucesso!!!");
            }
            catch (SqlException ex)
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
            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            List<TipoQuarto> ListaTipoQuarto = new List<TipoQuarto>();

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new TipoQuarto()
                    {
                        Id_TipoQuarto = Convert.ToInt32(rd["ID_TIPOQUARTO"]),
                        Tipo = Convert.ToString(rd["TIPO"]),
                        Qtd_Max = Convert.ToInt32(rd["QTD_HOSPEDE"]),
                        Valor_Diaria = Convert.ToDouble(rd["VALORDIARIA"]),
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
            catch (SqlException ex)
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
            SqlCommand comando = new SqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<TipoQuarto> ListaTipoQuarto = new List<TipoQuarto>();

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaTipoQuarto.Add(new TipoQuarto()
                    {
                        Id_TipoQuarto = Convert.ToInt32(rd["ID_TIPOQUARTO"]),
                        Tipo = Convert.ToString(rd["TIPO"]),
                        Qtd_Max = Convert.ToInt32(rd["QTD_HOSPEDE"]),
                        Valor_Diaria = Convert.ToDouble(rd["VALORDIARIA"]),
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
            catch (SqlException ex)
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
