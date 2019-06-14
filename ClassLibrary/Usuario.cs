using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Usuario
    {
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE;Initial Catalog=Prova2;Integrated Security=True";

        public int id { get; set; }
        public string login_usuario { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }

        public Usuario pegarUsuarioID(string idUser)
        {
            try
            {
                string procedure = "pegarUsuarioID";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUser;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.id = Convert.ToInt32(reader[0].ToString());
                        this.nome = reader[1].ToString();
                        this.login_usuario = reader[2].ToString();
                        this.senha = reader[3].ToString();
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

        public Usuario verificarLogin(string user, string pass)
        {
            try
            {
                string procedure = "verificarLogin";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@login_usuario", SqlDbType.VarChar).Value = user;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = pass;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.id = Convert.ToInt32(reader[0].ToString());
                        this.nome = reader[1].ToString();
                        this.login_usuario = reader[2].ToString();
                        this.senha = reader[3].ToString();
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

        public void registrarLog(string idUsuario)
        {
            try
            {
                string procedure = "registrarLog";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataSet verificarLogUsuario(string idUsuario)
        {
            try
            {
                string procedure = "verificarLogUsuario";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
