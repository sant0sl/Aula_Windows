using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Professor
    {
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE;Initial Catalog=facear_2019;Integrated Security=True";

        public int Id_Professor { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Métodos Professor-------------------------------------------------

        public string cadastrarProfessor()
        {
            try
            {
                string procedure = "sp_createProfessor";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.Nome;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.Idade;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Professor cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Professor não foi cadastrado.\n" + ex.Message;
            }
        }

        public string alterarProfessor()
        {
            try
            {
                string procedure = "sp_updateProfessor";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.Id_Professor;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.Nome;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.Idade;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Professor alterado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Professor não foi alterado.\n" + ex.Message;
            }
        }

        public void persistirProfessor()
        {
            try
            {
                if (this.Id_Professor.Equals(null))
                {
                    this.cadastrarProfessor();
                }

                bool existe = false;
                existe = existeProf(Convert.ToString(this.Id_Professor));
                
                if (existe == true)
                {
                    this.alterarProfessor();
                }
                else
                {
                    this.cadastrarProfessor();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataSet buscaProfessores()
        {
            try
            {
                string procedure = "sp_buscaProfessor";
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
                throw;
            }
        }

        public string excluirProfessor()
        {
            try
            {

                string procedure = "sp_deleteProfessor";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = this.Id_Professor;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Professor deletado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Professor não foi deletado.\n" + ex.Message;
            }
        }

        //Outros métodos----------------------------------------------------
 
        public bool existeProf(string id)
        {
            try
            {
                Professor prof = new Professor();
                prof = buscaProfessoresPorID(id);

                if (prof != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public Professor buscaProfessoresPorID(string id)
        {
            try
            {
                string procedure = "sp_buscaProfessorByID";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.Id_Professor = Convert.ToInt32(reader[0].ToString());
                        this.Nome = reader[1].ToString();
                        this.Idade = Convert.ToInt32(reader[2].ToString());
                    }
                }
                connection.Close();

                return this;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataSet buscaProfessoresPorNome(string nome)
        {
            try
            {
                string procedure = "sp_buscaProfessorByName";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataSet buscaProfessoresPorFiltro(string filtro)
        {
            try
            {
                string procedure = "sp_buscaProfessorByFilter";
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
                throw;
            }
        }

        public int buscaQtdProfessores()
        {
            string procedure = "sp_buscaQtdProfessores";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(procedure, connection);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            int qtd = (Int32)command.ExecuteScalar();
            connection.Close();

            return qtd;
        }

    }
}
