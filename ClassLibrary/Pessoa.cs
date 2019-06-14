using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pessoa
    {
        //SANT0SLNOTE\SANT0SL = qualquer string com diretório que dê erro utiliza @ antes
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE\SANT0SL;Initial Catalog=crudform;Integrated Security=True";

        public int uid_pessoa { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }

        public string sp_createPessoa()
        {
            try
            {
                string procedure = "sp_createPessoa";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.nome;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.idade;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Pessoa cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Pessoa não foi cadastrada.\n" + ex.Message;
            }
        }

        public string sp_updatePessoa()
        {
            try
            {
                string procedure = "sp_updatePessoa";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@uid_pessoa", SqlDbType.Int).Value = this.uid_pessoa;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.nome;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.idade;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Pessoa alterada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Pessoa não foi alterada.\n" + ex.Message;
            }
        }

        public string sp_deletePessoa()
        {
            try
            {
                string procedure = "sp_deletePessoa";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@uid_pessoa", SqlDbType.Int).Value = this.uid_pessoa;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Pessoa excluída com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Pessoa não foi excluída.\n" + ex.Message;
            }
        }

        public DataSet sp_readPessoa()
        {
            try
            {
                string procedure = "sp_readPessoa";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataSet sp_readPessoaByFilter(string filtro)
        {
            try
            {
                string procedure = "sp_readPessoaByFilter";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public Pessoa sp_readPessoaByUID()
        {
            try
            {
                string procedure = "sp_readPessoaByUID";
                Pessoa pessoa = new Pessoa();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@uid_pessoa", SqlDbType.Int).Value = this.uid_pessoa;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pessoa.uid_pessoa = Convert.ToInt32(reader[0].ToString());
                        pessoa.nome = reader[1].ToString();
                        pessoa.idade = Convert.ToInt32(reader[2].ToString());
                        pessoa.email = reader[3].ToString();
                    }
                }
                connection.Close();

                return pessoa;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public int sp_countPessoa()
        {
            try
            {
                string procedure = "sp_countPessoa";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                int qtd = (Int32)command.ExecuteScalar();
                connection.Close();

                return qtd;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
