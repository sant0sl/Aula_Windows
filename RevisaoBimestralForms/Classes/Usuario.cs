using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoBimestralForms.Classes
{
    public class Usuario
    {
        private string connectionString { get; } = ConfigurationManager.AppSettings[@"connectionString"];

        public string cpf { get; set; }
        public string nomeCompleto { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        //----------------MÉTODOS USUÁRIO----------------------

        public string sp_createUsuario()
        {
            try
            {
                string procedure = "sp_createUsuario";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar).Value = this.nomeCompleto;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "usuário foi cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Usuário não foi cadastrado.\n" + ex.Message;
            }
        }

        public string sp_updateUsuario()
        {
            try
            {
                string procedure = "sp_updateUsuario";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomeCompleto", SqlDbType.VarChar).Value = this.nomeCompleto;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Usuário foi alterado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Usuário não foi alterado.\n" + ex.Message;
            }
        }

        public DataSet sp_readUsuario()
        {
            try
            {
                string procedure = "sp_readUsuario";
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

        public Usuario sp_readUsuarioByCPF()
        {
            try
            {
                string procedure = "sp_readUsuarioByCPF";

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
                        this.nomeCompleto = reader[1].ToString();
                        this.email = reader[2].ToString();
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

        public Usuario sp_readUsuarioByCPFandPass()
        {
            try
            {
                string procedure = "sp_readUsuarioByCPFandPass";
                Usuario u = new Usuario();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.cpf = reader[0].ToString();
                        this.nomeCompleto = reader[1].ToString();
                        this.email = reader[2].ToString();
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

        public DataSet sp_readUsuarioByFilter(string filtro)
        {
            try
            {
                string procedure = "sp_readUsuarioByFilter";
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

        public string sp_deleteUsuario()
        {
            try
            {
                string procedure = "sp_deleteUsuario";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Usuário deletado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Usuário não foi deletado.\n" + ex.Message;
            }
        }

        //----------------MÉTODOS PCS-------------------------

        public string sp_createPC(PC pc)
        {
            try
            {
                string procedure = "sp_createPC";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@processador", SqlDbType.VarChar).Value = pc.processador;
                command.Parameters.Add("@placaMae", SqlDbType.VarChar).Value = pc.placaMae;
                command.Parameters.Add("@fonte", SqlDbType.VarChar).Value = pc.fonte;
                command.Parameters.Add("@coolerProcessador", SqlDbType.VarChar).Value = pc.coolerProcessador;
                command.Parameters.Add("@memoriaRam", SqlDbType.VarChar).Value = pc.memoriaRam;
                command.Parameters.Add("@hd", SqlDbType.VarChar).Value = pc.hd;
                command.Parameters.Add("@ssd", SqlDbType.VarChar).Value = pc.ssd;
                command.Parameters.Add("@placaDeVideo", SqlDbType.VarChar).Value = pc.placaDeVideo;
                command.Parameters.Add("@gabinete", SqlDbType.VarChar).Value = pc.gabinete;
                command.Parameters.Add("@cpfCliente", SqlDbType.VarChar).Value = pc.cpfCliente;
                command.Parameters.Add("@fk_tipoServico", SqlDbType.Int).Value = pc.fk_tipoServico;
                command.Parameters.Add("@observacoes", SqlDbType.VarChar).Value = pc.observacoes;
                command.Parameters.Add("@statuspc", SqlDbType.Bit).Value = pc.statuspc;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "PC foi cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "PC não foi cadastrado.\n" + ex.Message;
            }
        }

        public string sp_updatePC(PC pc)
        {
            try
            {
                string procedure = "sp_updatePC";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@uid_pc", SqlDbType.Int).Value = pc.uid_pc;
                command.Parameters.Add("@processador", SqlDbType.VarChar).Value = pc.processador;
                command.Parameters.Add("@placaMae", SqlDbType.VarChar).Value = pc.placaMae;
                command.Parameters.Add("@fonte", SqlDbType.VarChar).Value = pc.fonte;
                command.Parameters.Add("@coolerProcessador", SqlDbType.VarChar).Value = pc.coolerProcessador;
                command.Parameters.Add("@memoriaRam", SqlDbType.VarChar).Value = pc.memoriaRam;
                command.Parameters.Add("@hd", SqlDbType.VarChar).Value = pc.hd;
                command.Parameters.Add("@ssd", SqlDbType.VarChar).Value = pc.ssd;
                command.Parameters.Add("@placaDeVideo", SqlDbType.VarChar).Value = pc.placaDeVideo;
                command.Parameters.Add("@gabinete", SqlDbType.VarChar).Value = pc.gabinete;
                command.Parameters.Add("@cpfCliente", SqlDbType.VarChar).Value = pc.cpfCliente;
                command.Parameters.Add("@fk_tipoServico", SqlDbType.Int).Value = pc.fk_tipoServico;
                command.Parameters.Add("@observacoes", SqlDbType.VarChar).Value = pc.observacoes;
                command.Parameters.Add("@statuspc", SqlDbType.Bit).Value = pc.statuspc;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "PC foi alterado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "PC não foi alterado.\n" + ex.Message;
            }
        }

        public DataSet sp_readPC()
        {
            try
            {
                string procedure = "sp_readPC";
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

        public PC sp_readPCByUID(PC pc)
        {
            try
            {
                string procedure = "sp_readPCByUID";
                PC retorno = new PC();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@uid_pc", SqlDbType.Int).Value = pc.uid_pc;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        retorno.uid_pc = Convert.ToInt32(reader[0].ToString());
                        retorno.processador = reader[1].ToString();
                        retorno.placaMae = reader[2].ToString();
                        retorno.fonte = reader[3].ToString();
                        retorno.coolerProcessador = reader[4].ToString();
                        retorno.memoriaRam = reader[5].ToString();
                        retorno.hd = reader[6].ToString();
                        retorno.ssd = reader[7].ToString();
                        retorno.placaDeVideo = reader[8].ToString();
                        retorno.gabinete = reader[9].ToString();
                        retorno.cpfCliente = reader[10].ToString();
                        retorno.fk_tipoServico = Convert.ToInt32(reader[11].ToString());
                        retorno.observacoes = reader[12].ToString();
                        retorno.statuspc = Convert.ToBoolean(reader[13].ToString());
                    }
                }
                connection.Close();

                return retorno;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataSet sp_readPCByCPFCliente(string cpfCliente)
        {
            try
            {
                string procedure = "sp_readPCByCPFCliente";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpfCliente", SqlDbType.VarChar).Value = cpfCliente;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public string sp_finalizarServico(PC pc)
        {
            try
            {
                string procedure = "sp_finalizarServico";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add("@uid_pc", SqlDbType.Int).Value = pc.uid_pc;
                command.Parameters.Add("@cpfCliente", SqlDbType.VarChar).Value = pc.cpfCliente;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Foi finalizado este serviço com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Não foi finalizado.\n" + ex.Message;
            }
        }

        //-----------------OUTROS MÉTODOS----------------------

        public DataSet sp_readComboServicos()
        {
            try
            {
                string procedure = "sp_readComboServicos";
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

    }
}
