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
        SqlConnection conexao;

        public Dao_Quarto()
        {
            //string conexao BD AZURE
            conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        }

        public void Create(Quarto Quarto)
        {
            string comandoSql = "INSERT INTO tbl_Quarto (Numero, Andar, Status, Tipo_Quarto) VALUES (@NUMERO, @ANDAR, @STATUS, @TIPO_QUARTO)";

            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUMERO", Quarto.Numero);
            comando.Parameters.AddWithValue("@ANDAR", Quarto.Andar);
            comando.Parameters.AddWithValue("STATUS", Quarto.Status);
            comando.Parameters.AddWithValue("TIPO_QUARTO", Quarto.Tipo);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Quarto Cadastrado com sucesso!!!", "Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update(Quarto Quarto)
        {
            string comandoSql = "UPDATE tbl_Quarto SET Numero = @NUMERO, Andar = @ANDAR, Status = @STATUS, Tipo_Quarto = @TIPO_QUARTO WHERE Numero = @NUMERO";

            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUMERO", Quarto.Numero);
            comando.Parameters.AddWithValue("@ANDAR", Quarto.Andar);
            comando.Parameters.AddWithValue("STATUS", Quarto.Status);
            comando.Parameters.AddWithValue("TIPO_QUARTO", Quarto.Tipo);

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

        public void Delete()
        {

        }

        public void CarregarLista_Quarto()
        {

        }

        public void BuscarLista_Quarto()
        {

        }

        public List<Quarto> Buscar_ListaTipoQuarto()
        {
            string comandoSql = "SELECT TIPO FROM tbl_TipoQuarto order by TIPO desc";
            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            List<Quarto> ListaTipoQuarto = new List<Quarto>();

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

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
