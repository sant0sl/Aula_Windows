using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Aluno
    {
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE;Initial Catalog=escola;Integrated Security=True";

        public int id { get; set; }
        public string nome { get; set; }
        public string turma { get; set; }

        //Métodos Alunos----------------

        public string cadastrarAluno()
        {
            try
            {
                string procedure = "sp_createAluno";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.nome;
                command.Parameters.Add("@turma", SqlDbType.VarChar).Value = this.turma;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Aluno cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Aluno não foi cadastrado.\n" + ex.Message;
            }
        }

        public string alterarAluno()
        {
            try
            {
                string procedure = "sp_updateAluno";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = this.nome;
                command.Parameters.Add("@turma", SqlDbType.VarChar).Value = this.turma;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Aluno alterado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Aluno não foi alterado.\n" + ex.Message;
            }
        }

        public Aluno buscaAlunoByID(string id)
        {
            try
            {
                string procedure = "sp_readAlunoByID";
                Aluno aluno = new Aluno();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aluno.id = Convert.ToInt32(reader[0].ToString());
                        aluno.nome = reader[1].ToString();
                        aluno.turma = reader[2].ToString();
                    }
                }
                connection.Close();

                return aluno;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataSet buscaAlunos()
        {
            try
            {
                string procedure = "sp_readAlunos";
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

        public string excluirAluno()
        {
            try
            {

                string procedure = "sp_deleteAluno";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.id;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Aluno deletado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Aluno não foi deletado.\n" + ex.Message;
            }
        }

        //Métodos Notas-----------------

        public string cadastrarNota(Notas nota)
        {
            try
            {
                string procedure = "sp_createNota";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idAluno", SqlDbType.Int).Value = nota.idAluno;
                command.Parameters.Add("@idMateria", SqlDbType.Int).Value = nota.idMateria;
                command.Parameters.Add("@nota", SqlDbType.Decimal).Value = nota.nota;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Nota cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Nota não foi cadastrada.\n" + ex.Message;
            }
        }

        public string alterarNota(Notas nota)
        {
            try
            {
                string procedure = "sp_updateNota";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = nota.id;
                command.Parameters.Add("@nota", SqlDbType.Decimal).Value = nota.nota;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Nota alterada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Nota não foi alterada.\n" + ex.Message;
            }
        }

        public Notas buscaNotaByID(string idNota)
        {
            try
            {
                string procedure = "sp_readNotaByID";
                Notas nota = new Notas();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(idNota);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nota.id = Convert.ToInt32(reader[0].ToString());
                        nota.idAluno = Convert.ToInt32(reader[1].ToString());
                        nota.idMateria = Convert.ToInt32(reader[2].ToString());
                        nota.nota = Convert.ToDecimal(reader[3].ToString());
                        nota.quando = Convert.ToDateTime(reader[4].ToString());
                    }
                }
                connection.Close();

                return nota;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataSet buscaNotasByIDAluno(string idAluno)
        {
            try
            {
                string procedure = "sp_readNotasByIDAluno";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idAluno", SqlDbType.Int).Value = Convert.ToInt32(idAluno);

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public string excluirNota(string idNota)
        {
            try
            {

                string procedure = "sp_deleteNota";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(idNota);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Nota deletada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Nota não foi deletada.\n" + ex.Message;
            }
        }

    }
}
