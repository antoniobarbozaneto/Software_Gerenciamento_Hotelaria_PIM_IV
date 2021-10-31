using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Dao
{
    class Dao_Hospede
    {
        SqlConnection conexao;
        public Dao_Hospede()
        {
            //string conexao BD AZURE
            conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        }

        public void Create(Hospede Hospede)
        {
            string comandoSql = "INSERT INTO tbl_Hospede (Nome,Dt_Nascimento,Rg,Cpf,Passaporte,Rua,Numero,Bairro,Cidade,Cep,Telefone,Celular_Um,Celular_Dois,Email,Observacao) Values (@NOME, @DT_NASCIMENTO, @RG, @CPF, @PASSAPORTE, @RUA, @NUMERO, @BAIRRO, @CIDADE, @CEP, @TELEFONE, @CELULAR_UM, @CELULAR_DOIS, @EMAIL, @OBS)";

            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NOME", Hospede.Nome);
            comando.Parameters.AddWithValue("@DT_NASCIMENTO", Hospede.Dt_Nascimento);
            comando.Parameters.AddWithValue("@RG", Hospede.RG);
            comando.Parameters.AddWithValue("@CPF", Hospede.Cpf);
            comando.Parameters.AddWithValue("@PASSAPORTE", Hospede.Passaporte);
            comando.Parameters.AddWithValue("@RUA", Hospede.Rua);
            comando.Parameters.AddWithValue("@NUMERO", Hospede.Num);
            comando.Parameters.AddWithValue("@BAIRRO", Hospede.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", Hospede.Cidade);
            comando.Parameters.AddWithValue("@CEP", Hospede.Cep);
            comando.Parameters.AddWithValue("@TELEFONE", Hospede.Telefone);
            comando.Parameters.AddWithValue("@CELULAR_UM", Hospede.Celular_Um);
            comando.Parameters.AddWithValue("@CELULAR_DOIS", Hospede.Celular_Dois);
            comando.Parameters.AddWithValue("@EMAIL", Hospede.Email);
            comando.Parameters.AddWithValue("@OBS", Hospede.Obs);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
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

        //Carrega Lista Hospedes
        public List<Hospede> CarregaLista_Hospede()
        {
            string comandoSql = "SELECT * FROM tbl_Hospede";
            SqlCommand comando = new SqlCommand(comandoSql, conexao);

            List<Hospede> ListaHospede = new List<Hospede>();

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaHospede.Add(new Hospede()
                    {
                        Id_Hospede = Convert.ToInt32(rd["ID_HOSPEDE"]),
                        Nome = Convert.ToString(rd["NOME"]),
                        Dt_Nascimento = Convert.ToString(rd["DT_NASCIMENTO"]),
                        RG = Convert.ToString(rd["RG"]),
                        Cpf = Convert.ToString(rd["CPF"]),
                        Passaporte = Convert.ToString(rd["PASSAPORTE"]),
                        Rua = Convert.ToString(rd["RUA"]),
                        Num = Convert.ToString(rd["NUMERO"]),
                        Bairro = Convert.ToString(rd["BAIRRO"]),
                        Cidade = Convert.ToString(rd["CIDADE"]),
                        Cep = Convert.ToString(rd["CEP"]),
                        Telefone = Convert.ToString(rd["TELEFONE"]),
                        Celular_Um = Convert.ToString(rd["CELULAR_UM"]),
                        Celular_Dois = Convert.ToString(rd["CELULAR_DOIS"]),
                        Email = Convert.ToString(rd["EMAIL"]),
                        Obs = Convert.ToString(rd["OBSERVACAO"])
                    }); ;

                }
                if (ListaHospede.Count() > 0)
                {
                    return ListaHospede;
                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}