using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Crianca
    {
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE\SANT0SL;Initial Catalog=upaforms;Integrated Security=True";

        public string cpf { get; set; }
        public string nomeCrianca { get; set; }
        public string nomeMae { get; set; }
        public int idade { get; set; }

        //Métodos -------------------------------------------------------

        public string sp_createCrianca()
        {
            try
            {
                string procedure = "sp_createCrianca";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomeCrianca", SqlDbType.VarChar).Value = this.nomeCrianca;
                command.Parameters.Add("@nomeMae", SqlDbType.VarChar).Value = this.nomeMae;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.idade;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Criança cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Criança não foi cadastrada.\n" + ex.Message;
            }
        }

        public string sp_updateCrianca()
        {
            try
            {
                string procedure = "sp_updateCrianca";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomeCrianca", SqlDbType.VarChar).Value = this.nomeCrianca;
                command.Parameters.Add("@nomeMae", SqlDbType.VarChar).Value = this.nomeMae;
                command.Parameters.Add("@idade", SqlDbType.Int).Value = this.idade;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Criança alterada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Criança não foi alterada.\n" + ex.Message;
            }
        }

        public DataSet sp_readCrianca()
        {
            try
            {
                string procedure = "sp_readCrianca";
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

        public Crianca sp_readCriancaByCPF()
        {
            try
            {
                string procedure = "sp_readCriancaByCPF";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.cpf = reader[0].ToString();
                        this.nomeCrianca = reader[1].ToString();
                        this.nomeMae = reader[2].ToString();
                        this.idade = Convert.ToInt32(reader[3].ToString());
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

        public DataSet sp_readCriancaByFiltro(string filtro)
        {
            try
            {
                string procedure = "sp_readCriancaByFiltro";
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

        public string sp_deleteCrianca()
        {
            try
            {
                string procedure = "sp_deleteCrianca";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Criança deletada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Criança não foi deletada.\n" + ex.Message;
            }
        }

        //Vacinas------------------------------

        public string sp_createVacina(Crianca crianca, Vacinas vacinas)
        {
            try
            {
                string procedure = "sp_createVacina";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@nomeVacina", SqlDbType.VarChar).Value = vacinas.nomeVacina;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = crianca.cpf;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Vacina cadastrada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Vacina não foi cadastrada.\n" + ex.Message;
            }
        }

        public string sp_updateVacina(Crianca crianca, Vacinas vacinas)
        {
            try
            {
                string procedure = "sp_updateVacina";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idVacina", SqlDbType.Int).Value = vacinas.idVacina;
                command.Parameters.Add("@nomeVacina", SqlDbType.VarChar).Value = vacinas.nomeVacina;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = crianca.cpf;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Vacina alterada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Vacina não foi alterada.\n" + ex.Message;
            }
        }

        public string sp_deleteVacina(Crianca crianca, Vacinas vacinas)
        {
            try
            {
                string procedure = "sp_deleteVacina";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idVacina", SqlDbType.Int).Value = vacinas.idVacina;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = crianca.cpf;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Vacina deletada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Vacina não foi deletada.\n" + ex.Message;
            }
        }

        public DataSet sp_readVacinasByCPF(string cpf)
        {
            try
            {
                string procedure = "sp_readVacinasByCPF";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Vacinas sp_readVacinasById(Vacinas v)
        {
            try
            {
                string procedure = "sp_readVacinasById";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = v.idVacina;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        v.nomeVacina = reader[0].ToString();
                    }
                }
                connection.Close();

                return v;
            }
            catch (SqlException)
            {
                return null;
            }
        }

    }
}
