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
    class Dao_Pagamento
    {
        NpgsqlConnection conexao;
        public Dao_Pagamento()
        {
            //string conexao BD AZURE
            //conexao = new SqlConnection("Server = tcp:dbanetobarboza.database.windows.net, 1433; Initial Catalog = DB_Hotelaria; Persist Security Info = False; User ID = admxpto; Password = adm123456@; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //
            //string conexando Heroku + Postgresql
            conexao = new NpgsqlConnection("Server = ec2-44-194-54-186.compute-1.amazonaws.com, Port = 5432; DataBase = d7jt6pi3k8522j; User ID = mupfpakzcvzazq; Password = 6ca9b83c31140b0bde6e651f96a92ae7deba1354762395ac2dfd98ad49ba0550");
        }

        public void Create(Pagamento Pagamento)
        {
            string comandoSql = "INSERT INTO tbl_Pagamento (Num_Reserva, Forma_Pagamento, Num_Parcela, Valor_Total, Valor_Pago, Valor_Parcela, Troco, Dt_Pagamento) VALUES(@NUM_RESERVA, @FORMA_PAGAMENTO, @NUM_PARCELA, @VALOR_TOTAL, @VALOR_PAGO, @VALOR_PARCELA, @TROCO, @DT_PAGAMENTO)";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUM_RESERVA", Pagamento.Num_Reserva);
            comando.Parameters.AddWithValue("@FORMA_PAGAMENTO", Pagamento.FormPagamento);
            comando.Parameters.AddWithValue("@NUM_PARCELA", Pagamento.NumParcela);
            comando.Parameters.AddWithValue("@VALOR_TOTAL", Pagamento.ValorTotal);
            comando.Parameters.AddWithValue("@VALOR_PAGO", Pagamento.ValorPago);
            comando.Parameters.AddWithValue("@VALOR_PARCELA", Pagamento.ValorParcela);
            comando.Parameters.AddWithValue("@TROCO", Pagamento.ValorTroco);
            comando.Parameters.AddWithValue("@DT_PAGAMENTO", Pagamento.Dt_Pagamento);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Conta foi dado baixa com sucesso!", "Confirma Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void UpdateStatusDisponivel(Pagamento Pagamento)
        {
            string comandoSql = "UPDATE tbl_quarto SET Status = 'DISPONÍVEL' WHERE Numero = @NUM_QUARTO";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUM_QUARTO", Pagamento.Numero);

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
        public void UpdateStatusReserva(Pagamento Pagamento)
        {
            string comandoSql = "UPDATE tbl_reserva SET Status_Reserva = 'RECEBIDA' WHERE Num_Reserva = @NUM_RESERVA";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@NUM_RESERVA", Pagamento.Num_Reserva);

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
        public void DeletaReserva(Pagamento Pagamento)
        {
            string comandoSql = "DELETE FROM tbl_Reserva WHERE Num_Reserva = @NUM_RESERVA";

            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            comando.Parameters.AddWithValue("@ID_HOSPEDE", Pagamento.Num_Reserva);
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Reserva excluida com sucesso!!!");
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
        public List<Pagamento> CarregarLista_Pagamento()
        {
            string comandoSql = "SELECT * FROM tbl_Pagamento";
            NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

            List<Pagamento> ListaPagamento = new List<Pagamento>();

            try
            {
                conexao.Open();
                NpgsqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    ListaPagamento.Add(new Pagamento()
                    {
                        Nfe = Convert.ToString(rd["NFE"]),
                        Num_Reserva = Convert.ToInt32(rd["NUM_RESERVA"]),
                        FormPagamento = Convert.ToString(rd["FORMA_PAGAMENTO"]),
                        NumParcela = Convert.ToInt32(rd["NUM_PARCELA"]),
                        ValorTotal = Convert.ToDouble(rd["VALOR_TOTAL"]),
                        ValorParcela = Convert.ToDouble(rd["VALOR_PARCELA"]),
                        ValorTroco = Convert.ToDouble(rd["TROCO"]),
                        Dt_Pagamento = Convert.ToDateTime(rd["DT_PAGAMENTO"]),
                    }); ;

                }
                if (ListaPagamento.Count() > 0)
                {
                    return ListaPagamento;
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
