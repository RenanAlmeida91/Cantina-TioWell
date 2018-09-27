using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Web.Controller.Model;

namespace Web.Controller.DAO
{
    internal class FuncionarioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;
        
        //Cadastrar novo Funcionário
        internal Funcionario InserirFuncionario(string nome, string email, string celular)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO FUNCIONARIO(NomeFunc, Email, Celular) VALUES (@nome, @email, @celular)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@email", email));
            comando.Parameters.Add(new SqlParameter("@celular", celular));
            
            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na gravação dos dados!" + e);
            }
            finally
            {
                conn.Close();

            }
            return null;
        }

        //Consultar todos os funcionários
        internal List<Funcionario> ConsultarFuncionario()
        {
            List<Funcionario> lstFuncionarios = new List<Funcionario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select * from FUNCIONARIO";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Codigo = Convert.ToInt32(dr["IdFunc"].ToString());
                funcionario.NomeFunc = dr["NomeFunc"].ToString();
                funcionario.Email = dr["Email"].ToString();
                funcionario.Celular = dr["Celular"].ToString();

                lstFuncionarios.Add(funcionario);
            }
            conn.Close();
            return lstFuncionarios;
        }

        //Consultar Funcionários por ID
        internal List<Funcionario> ConsultarFuncionarioID(string id)
        {
            List<Funcionario> lstFuncionarios = new List<Funcionario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select * from FUNCIONARIO WHERE IdFunc = " + id;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Codigo = Convert.ToInt32(dr["IdFunc"].ToString());
                funcionario.NomeFunc = dr["NomeFunc"].ToString();
                funcionario.Email = dr["Email"].ToString();
                funcionario.Celular = dr["Celular"].ToString();

                lstFuncionarios.Add(funcionario);
            }
            conn.Close();
            return lstFuncionarios;
        }

        //Consultar Funcionários por Nome
        internal List<Funcionario> ConsultarFuncionarioNome(string nome)
        {
            List<Funcionario> lstFuncionarios = new List<Funcionario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM FUNCIONARIO WHERE NomeFunc like '%" + nome + "%'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Codigo = Convert.ToInt32(dr["IdFunc"].ToString());
                funcionario.NomeFunc = dr["NomeFunc"].ToString();
                funcionario.Email = dr["Email"].ToString();
                funcionario.Celular = dr["Celular"].ToString();

                lstFuncionarios.Add(funcionario);
            }
            conn.Close();
            return lstFuncionarios;
        }

        //Consultar lista apenas com o nome dos funcionários
        internal List<Funcionario> ConsultarListaFuncionario()
        {
            List<Funcionario> lstFuncionarios = new List<Funcionario>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "Select IdFunc, NomeFunc from FUNCIONARIO ORDER BY NomeFunc";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Codigo = Convert.ToInt32(dr["IdFunc"].ToString());
                funcionario.NomeFunc = dr["NomeFunc"].ToString();
                lstFuncionarios.Add(funcionario);
            }
            conn.Close();
            return lstFuncionarios;
        }

        //Atualizar Funcionário
        internal Funcionario AtualizaFuncionario (int id, string nome, string email, string celular)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "UPDATE FUNCIONARIO SET NomeFunc = @nome, Email = @email, Celular = @celular WHERE IdFunc = @id;";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@id", id));
            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@email", email));
            comando.Parameters.Add(new SqlParameter("@celular", celular));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema ao atualizar o funcionário!" + e);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        //Remover Funcionário
        internal Funcionario RemoverFuncionario(int id)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "DELETE FUNCIONARIO WHERE IdFunc = @id;";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@id", id));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema ao remover o funcionário!" + e);
            }
            finally
            {
                conn.Close();

            }
            return null;
        }

    }
}
