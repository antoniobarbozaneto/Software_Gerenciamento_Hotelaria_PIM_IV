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
      //conexao = new SqlConnection("");
      //
      //string conexando Heroku + Postgresql
      //conexao = new NpgsqlConnection("");
    }

    public void Create(TipoQuarto TipoQuarto)
    {
      string comandoSql = "INSERT INTO tbl_TipoQuarto (Tipo, Qtd_Hospede, Valor_Diaria, Refeicao, Autor) VALUES (@TIPO, @QTD_HOSPEDE, @VALOR_DIARIA, @REFEICAO, @AUTOR)";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
      comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
      comando.Parameters.AddWithValue("@VALOR_DIARIA", TipoQuarto.Valor_Diaria);
      comando.Parameters.AddWithValue("@REFEICAO", TipoQuarto.Refeicao);
      comando.Parameters.AddWithValue("@AUTOR", TipoQuarto.Id_UserLogado);
      try
      {
        conexao.Open();
        comando.ExecuteNonQuery();
        MessageBox.Show("Tipo de Quarto: " + TipoQuarto.Tipo + " Cadastrado com sucesso!!!", "Tipo de Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
      string comandoSql = "UPDATE tbl_tipoQuarto SET Tipo = @TIPO, Qtd_Hospede = @QTD_HOSPEDE, Valor_Diaria = @VALOR_DIARIA, Refeicao = @REFEICAO, Autor = @AUTOR WHERE Tipo = @TIPO";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@TIPO", TipoQuarto.Tipo);
      comando.Parameters.AddWithValue("@QTD_HOSPEDE", TipoQuarto.Qtd_Max);
      comando.Parameters.AddWithValue("VALOR_DIARIA", TipoQuarto.Valor_Diaria);
      comando.Parameters.AddWithValue("REFEICAO", TipoQuarto.Refeicao);
      comando.Parameters.AddWithValue("@AUTOR", TipoQuarto.Id_UserLogado);

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
        MessageBox.Show("Tipo de Quarto: " + TipoQuarto.Tipo + " deletado com sucesso!!!", "Tipo de Quarto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    public List<TipoQuarto> BuscarLista_TipoQuarto(TipoQuarto TipoQuarto)
    {
      string comandoSql = "SELECT * FROM tbl_TipoQuarto WHERE Tipo LIKE '%" + TipoQuarto.Tipo + "%'";
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
            Id = Convert.ToInt32(rd["AUTOR"])
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
    public int Verif_TipoQuartoUsado(TipoQuarto TipoQuarto)
    {
      int Qtd_QuartoUsado = 0;
      string comandoSql = "SELECT COUNT(*) FROM TBL_QUARTO WHERE TIPO_QUARTO = @TIPO_QUARTO";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@TIPO_QUARTO", TipoQuarto.Tipo);

      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          Qtd_QuartoUsado = rd.GetInt32(0);
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
      return Qtd_QuartoUsado;
    }
  }
}
