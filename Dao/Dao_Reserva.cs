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
    class Dao_Reserva
    {
        NpgsqlConnection conexao;

        public Dao_Reserva()
        {
            //string conexao BD AZURE
            //conexao = new NpgsqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(Reserva Reserva)
        {

            string comandoSql = "INSERT INTO tbl_Reserva (Dt_Checkin, Dt_Checkout, Quarto_Numero, Id_Hospede, ValorTotal, Status_Reserva) VALUES (@DT_CHECKIN, @DT_CHECKOUT, @NUM_QUARTO, @ID_HOSPEDE, @VALOR_TOTAL, @STATUS_RESERVA)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@DT_CHECKIN", Reserva.Dt_Checkin);
            comando.Parameters.AddWithValue("@DT_CHECKOUT", Reserva.Dt_Checkout);
            comando.Parameters.AddWithValue("@NUM_QUARTO", Reserva.Numero);
            comando.Parameters.AddWithValue("@ID_HOSPEDE", Reserva.Id_Hospede);
            comando.Parameters.AddWithValue("@VALOR_TOTAL", Reserva.ValorTotal);
            comando.Parameters.AddWithValue("@STATUS_RESERVA", Reserva.Status_Reserva);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Reserva Efetuada com sucesso!!!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //
        public void UpdateStatusOcupado(Reserva Reserva)
        {
            string comandoSql = "UPDATE tbl_quarto SET Status = 'OCUPADO' WHERE Numero = @NUM_QUARTO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUM_QUARTO", Reserva.Numero);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();                
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
        //
        public int Verif_QtdHospede(Reserva Reserva)
        {
            int Qtd_Hospede = 0;
            string comandoSql = "SELECT Qtd_Hospede FROM tbl_TipoQuarto WHERE Tipo = @TIPO";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@TIPO", Reserva.Tipo);

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                        Qtd_Hospede = Convert.ToInt32(rd["QTD_HOSPEDE"]);
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
            return Qtd_Hospede;
        }

        public double Obtem_ValorDiaria(Reserva Reserva)
        {
            double Valor_Diaria = 0;
            string comandoSql = "SELECT Valor_Diaria FROM tbl_TipoQuarto WHERE Tipo = @VALOR_DIARIA";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@VALOR_DIARIA", Reserva.Tipo);

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Valor_Diaria = Convert.ToDouble(rd["VALOR_DIARIA"]);
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
            return Valor_Diaria;
        }

        public List<Reserva> CarregarLista_Reserva()
        {
            string comandoSql = "SELECT * FROM tbl_reserva WHERE Status_Reserva LIKE '%A RECEBER%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Reserva> ListaReserva = new List<Reserva>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaReserva.Add(new Reserva()
                    {
                        Num_Reserva = Convert.ToInt32(rd["NUM_RESERVA"]),
                        Dt_Checkin = Convert.ToDateTime(rd["DT_CHECKIN"]),
                        Dt_Checkout = Convert.ToDateTime(rd["DT_CHECKOUT"]),
                        Numero = Convert.ToString(rd["QUARTO_NUMERO"]),
                        Id_Hospede = Convert.ToInt32(rd["ID_HOSPEDE"]),
                        ValorTotal = Convert.ToDouble(rd["VALORTOTAL"]),
                        Status_Reserva = Convert.ToString(rd["STATUS_RESERVA"])
                    }); ;

                }
                if (ListaReserva.Count() > 0)
                {
                    return ListaReserva;
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

        public List<Reserva> BuscarLista_Reserva(string ParamWhere, string ParamBusca)
        {
            string comandoSql = "SELECT * FROM tbl_Reserva WHERE " + ParamBusca + " LIKE '%" + ParamWhere + "%'";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
            Console.WriteLine(comandoSql);
            List<Reserva> ListaReserva = new List<Reserva>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaReserva.Add(new Reserva()
                    {
                        Num_Reserva = Convert.ToInt32(rd["NUM_RESERVA"]),
                        Dt_Checkin = Convert.ToDateTime(rd["DT_CHECKIN"]),
                        Dt_Checkout = Convert.ToDateTime(rd["DT_CHECKOUT"]),
                        Numero = Convert.ToString(rd["QUARTO_NUMERO"]),
                        Id_Hospede = Convert.ToInt32(rd["ID_HOSPEDE"]),
                        ValorTotal = Convert.ToDouble(rd["VALORTOTAL"]),
                        Status_Reserva = Convert.ToString(rd["STATUS_RESERVA"])
                    }); ;

                }
                if (ListaReserva.Count() > 0)
                {
                    return ListaReserva;
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
