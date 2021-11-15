﻿using Npgsql;
using Software_Gerenciamento_Hotelaria_PIM_IV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

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
    }
}