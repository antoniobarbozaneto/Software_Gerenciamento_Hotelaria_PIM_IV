using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace Software_Gerenciamento_Hotelaria_PIM_IV.Dao
{
    class Dao_Hospede
    {
        NpgsqlConnection conexao;
        public Dao_Hospede()
        {
            //string conexao BD AZURE
            //conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(Hospede Hospede)
        {
            string comandoSql = "INSERT INTO tbl_Hospede (Nome, Dt_Nascimento, Rg, Cpf, Passaporte, Rua, Numero, Bairro, Cidade, Cep, Telefone, Celular_Um, Celular_Dois, Email, Observacao, Situacao) Values (@NOME, @DT_NASCIMENTO, @RG, @CPF, @PASSAPORTE, @RUA, @NUMERO, @BAIRRO, @CIDADE, @CEP, @TELEFONE, @CELULAR_UM, @CELULAR_DOIS, @EMAIL, @OBS, @SITUACAO)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NOME", Hospede.Nome);
            comando.Parameters.AddWithValue("@DT_NASCIMENTO", Hospede.Dt_Nascimento);
            comando.Parameters.AddWithValue("@RG", Hospede.RG);
            comando.Parameters.AddWithValue("@CPF", Hospede.Cpf);
            comando.Parameters.AddWithValue("@PASSAPORTE", Hospede.Passaporte);
            comando.Parameters.AddWithValue("@RUA", Hospede.Rua);
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
            comando.Parameters.AddWithValue("@SITUACAO", Hospede.Situacao_h);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Hóspede Cadastrado com sucesso!!!", "Cadastro de Hóspede", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        public void Update(Hospede Hospede)
        {
            string comandoSql = "UPDATE tbl_Hospede SET Nome = @NOME, Dt_Nascimento = @DT_NASCIMENTO,Rg = @RG, Cpf = @CPF, Passaporte = @PASSAPORTE, Rua = @RUA, Numero = @NUMERO, Bairro = @BAIRRO, Cidade = @CIDADE, Cep = @CEP, Telefone = @TELEFONE, Celular_Um = @CELULAR_UM, Celular_Dois = @CELULAR_DOIS, Email = @EMAIL, Observacao = @OBS, Situacao = @SITUACAO WHERE ID_HOSPEDE = @ID_HOSPEDE";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_HOSPEDE", Hospede.Id_Hospede);
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
            comando.Parameters.AddWithValue("@SITUACAO", Hospede.Situacao_h);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados alterados com sucesso!!!","Alteração de Dados",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

        public void Delete(Hospede Hospede)
        {
            string comandoSql = "DELETE FROM tbl_Hospede WHERE Id_Hospede = @ID_HOSPEDE";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_HOSPEDE", Hospede.Id_Hospede);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Hóspede deletado com sucesso!!!");
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

        //Carrega Lista Hospedes
        public List<Hospede> CarregarLista_Hospede()
        {
            string comandoSql = "SELECT * FROM tbl_Hospede";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Hospede> ListaHospede = new List<Hospede>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

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
                        Obs = Convert.ToString(rd["OBSERVACAO"]),
                        Situacao_h = Convert.ToString(rd["SITUACAO"])
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
        public List<Hospede> BuscarLista_Hospede(string ParamWhere, string ParamBusca)
        {
            string comandoSql = "SELECT * FROM tbl_Hospede WHERE " + ParamBusca + " LIKE '%" + ParamWhere + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<Hospede> ListaHospede = new List<Hospede>();
            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

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
                        Obs = Convert.ToString(rd["OBSERVACAO"]),
                        Situacao_h = Convert.ToString(rd["SITUACAO"])
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
        public int Verif_SituacaoHospede(Hospede Hospede)
        {
            int aux = 0;
            string comandoSql = "SELECT COUNT(*) FROM TBL_RESERVA WHERE Id_Hospede = @ID_HOSPEDE";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_HOSPEDE", Hospede.Id_Hospede);

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