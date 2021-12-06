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
  class Dao_Usuario
  {
    NpgsqlConnection conexao;
    public Dao_Usuario()
    {
      //string conexao BD AZURE
      //conexao = new SqlConnection("");
      //
      //string conexando Heroku + Postgresql
      //conexao = new NpgsqlConnection("");
    }

    public void Create(Usuario Usuario)
    {
      string comandoSql = "INSERT INTO tbl_Usuario (Usuario, Senha, Situacao) VALUES (@USUARIO, @SENHA, @SITUACAO)";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
      comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);
      comando.Parameters.AddWithValue("@SITUACAO", Usuario.Situacao_U);
      try
      {
        conexao.Open();
        comando.ExecuteNonQuery();
        MessageBox.Show("Usuário Cadastrado com sucesso!!!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    public void Update(Usuario Usuario)
    {
      string comandoSql = "UPDATE tbl_Usuario SET Usuario = @USUARIO, Senha = @SENHA, Situacao = @SITUACAO WHERE Id_Usuario = @ID_USUARIO";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);
      comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
      comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);
      comando.Parameters.AddWithValue("@SITUACAO", Usuario.Situacao_U);
      try
      {
        conexao.Open();
        comando.ExecuteNonQuery();
        MessageBox.Show("Dados alterados com sucesso!!!", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    public void Delete(Usuario Usuario)
    {
      string comandoSql = "DELETE FROM tbl_Usuario WHERE Id_Usuario = @ID_USUARIO";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);
      try
      {
        conexao.Open();
        comando.ExecuteNonQuery();
        MessageBox.Show("Usuário deletado com sucesso!!!", "Exclusão de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    //Carrega Lista Usuarios
    public List<Usuario> CarregarLista_Usuario()
    {
      string comandoSql = "SELECT * FROM tbl_Usuario";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      List<Usuario> ListaUsuario = new List<Usuario>();

      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          ListaUsuario.Add(new Usuario()
          {
            Id = Convert.ToInt32(rd["ID_Usuario"]),
            User = Convert.ToString(rd["USUARIO"]),
            Senha = Convert.ToString(rd["SENHA"]),
            Situacao_U = Convert.ToString(rd["SITUACAO"])
          }); ;

        }
        if (ListaUsuario.Count() > 0)
        {
          return ListaUsuario;
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
    public List<Usuario> BuscarLista_Usuario(Usuario Usuario)
    {
      string comandoSql = "SELECT * FROM tbl_Usuario WHERE  Id_Usuario = " + Usuario.Id + " OR Usuario LIKE '%" + Usuario.User + "%'";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);
      Console.WriteLine(comandoSql);
      List<Usuario> ListaUsuario = new List<Usuario>();
      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          ListaUsuario.Add(new Usuario()
          {
            Id = Convert.ToInt32(rd["ID_USUARIO"]),
            User = Convert.ToString(rd["USUARIO"]),
            Senha = Convert.ToString(rd["SENHA"]),
            Situacao_U = Convert.ToString(rd["SITUACAO"])
          }); ;

        }
        if (ListaUsuario.Count() > 0)
        {
          return ListaUsuario;
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
    public bool Logar(Usuario Usuario)
    {
      bool resp;

      string comandoSql = "SELECT * FROM tbl_Usuario WHERE Usuario = @USUARIO AND SENHA = @SENHA";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@USUARIO", Usuario.User);
      comando.Parameters.AddWithValue("@SENHA", Usuario.Senha);

      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        if (rd.HasRows)
        {
          return resp = true;
        }
        else
        {
          return resp = false;
        }
      }
      catch (NpgsqlException ex)
      {
        // Handle the SQL Exception as you wish
        Console.WriteLine(ex.ToString());
        return resp = false;
      }
      finally
      {
        conexao.Close();
      }
    }
    public int Buscar_Id_User(Usuario Usuario)
    {
      int Id_Usuario = 0;
      string comandoSql = "SELECT id_Usuario FROM tbl_Usuario WHERE Usuario = @USUARIO";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@USUARIO", Usuario.User);

      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          Id_Usuario = rd.GetInt32(0);
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
      return Id_Usuario;
    }
    public int Verif_SituacaoUsuario(Usuario Usuario)
    {
      int res = 0;
      int aux_tbl_H = 0;
      int aux_tbl_TQ = 0;
      int aux_Tbl_Q = 0;
      int aux_Tbl_R = 0;
      int aux_Tbl_P = 0;
      //
      string comandoSql = "SELECT COUNT(*) FROM tbl_hospede WHERE Autor = @ID_USUARIO";
      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);

      try
      {
        conexao.Open();

        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          aux_tbl_H = rd.GetInt32(0);
        }
        conexao.Close();
        //
        conexao.Open();
        comandoSql = "SELECT COUNT(*) FROM tbl_tipoquarto WHERE Autor = @ID_USUARIO";
        comando = new NpgsqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);

        rd = comando.ExecuteReader();

        while (rd.Read())
        {
          aux_tbl_TQ = rd.GetInt32(0);
        }
        conexao.Close();
        //
        conexao.Open();
        comandoSql = "SELECT COUNT(*) FROM tbl_quarto WHERE Autor = @ID_USUARIO";
        comando = new NpgsqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);

        rd = comando.ExecuteReader();

        while (rd.Read())
        {
          aux_Tbl_Q = rd.GetInt32(0);
        }
        conexao.Close();
        //
        conexao.Open();
        comandoSql = "SELECT COUNT(*) FROM TBL_RESERVA WHERE Autor = @ID_USUARIO";
        comando = new NpgsqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);

        rd = comando.ExecuteReader();

        while (rd.Read())
        {
          aux_Tbl_R = rd.GetInt32(0);
        }
        conexao.Close();
        //
        conexao.Open();
        comandoSql = "SELECT COUNT(*) FROM tbl_pagamento WHERE Autor = @ID_USUARIO";
        comando = new NpgsqlCommand(comandoSql, conexao);
        comando.Parameters.AddWithValue("@ID_USUARIO", Usuario.Id);

        rd = comando.ExecuteReader();

        while (rd.Read())
        {
          aux_Tbl_P = rd.GetInt32(0);
        }
        //
        res = (aux_tbl_H + aux_tbl_TQ + aux_Tbl_Q + aux_Tbl_R + aux_Tbl_P);
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
      return res;
    }

    public bool Verif_Ativo_Inativo(Usuario Usuario)
    {
      bool resp;
      string Situacao = "";

      string comandoSql = "SELECT Situacao FROM tbl_Usuario WHERE Usuario = @USUARIO";

      NpgsqlCommand comando = new NpgsqlCommand(comandoSql, conexao);

      comando.Parameters.AddWithValue("@USUARIO", Usuario.User);

      try
      {
        conexao.Open();
        NpgsqlDataReader rd = comando.ExecuteReader();

        while (rd.Read())
        {
          Situacao = rd.GetString(0);
        }
        if (Situacao == "ATIVO")
        {
          resp = true;
        }
        else
        {
          resp = false;
        }
        return resp;
      }
      catch (NpgsqlException ex)
      {
        // Handle the SQL Exception as you wish
        Console.WriteLine(ex.ToString());
        return resp = false;
      }
      finally
      {
        conexao.Close();
      }
    }
  }
}
