using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ContaBancaria
    {
        //SANT0SLNOTE\SANT0SL = qualquer string com diretório que dê erro utiliza @ antes
        private string connectionString { get; } = @"Data Source=SANT0SLNOTE\SANT0SL;Initial Catalog=bancoeletronico;Integrated Security=True";

        public string cpf { get; set; }
        public string nomecompleto { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public decimal saldo { get; set; }

        //-------------Métodos de gerenciamento das informações da conta--------------------------------------

        public string sp_createConta()
        {
            try
            {
                string procedure = "sp_createConta";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomecompleto", SqlDbType.VarChar).Value = this.nomecompleto;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Conta foi aberta com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Conta não foi aberta.\n" + ex.Message;
            }
        }

        public string sp_updateConta()
        {
            try
            {
                string procedure = "sp_updateConta";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@nomecompleto", SqlDbType.VarChar).Value = this.nomecompleto;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = this.email;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Informações da conta atual foram alterados!";
            }
            catch (SqlException ex)
            {
                return "Informações da conta não foram alterados.\n" + ex.Message;
            }
        }

        public ContaBancaria sp_readContaByCPF(string cpf)
        {
            try
            {
                string procedure = "sp_readContaByCPF";
                HistoricoBancario historico = new HistoricoBancario();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.cpf = reader[0].ToString();
                        this.nomecompleto = reader[1].ToString();
                        this.email = reader[2].ToString();
                        this.senha = reader[3].ToString();
                        this.saldo = Convert.ToDecimal(reader[4].ToString());
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

        public ContaBancaria sp_readContaByCPFandPass(string cpf, string senha)
        {
            try
            {
                string procedure = "sp_readContaByCPFandPass";
                ContaBancaria cb = new ContaBancaria();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cb.cpf = reader[0].ToString();
                        cb.nomecompleto = reader[1].ToString();
                        cb.email = reader[2].ToString();
                        cb.senha = reader[3].ToString();
                        cb.saldo = Convert.ToDecimal(reader[4].ToString());
                    }
                }
                connection.Close();

                return cb;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public string sp_deleteContaByCPF()
        {
            try
            {
                string procedure = "sp_deleteContaByCPF";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Conta apagada com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Conta não foi apagada. \nErro: " + ex;
            }
        }

        //-------------Métodos de operação bancária-----------------------------------------------------------

        public Decimal sp_consultarSaldo()
        {
            try
            {
                string procedure = "sp_consultarSaldo";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = this.senha;

                connection.Open();
                decimal saldo = (Decimal)command.ExecuteScalar();
                connection.Close();

                return saldo;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataSet sp_consultarHistorico()
        {
            try
            {
                string procedure = "sp_consultarHistorico";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public string sp_depositoBancario(decimal valorDepositado)
        {
            try
            {
                string procedure = "sp_depositoBancario";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@valorDepositado", SqlDbType.Decimal).Value = valorDepositado;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Depósito feito com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Depósito não foi concluído com sucesso. \nErro: " + ex.Message;
            }
        }

        public string sp_saqueBancario(decimal valorSacado)
        {
            try
            {
                string procedure = "sp_saqueBancario";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@valorSacado", SqlDbType.Decimal).Value = valorSacado;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                if (this.saldo >= valorSacado)
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    return "Saque feito com sucesso!";
                }
                else
                {
                    return "Saque não foi concluído com sucesso. Valor de saque maior que o saldo que possui.";
                }
            }
            catch (SqlException ex)
            {
                return "Saque não foi concluído com sucesso. \nErro: " + ex.Message;
            }
        }

        public string sp_transferenciaBancaria(ContaBancaria cbEmissor, ContaBancaria cbRecebedor, decimal valorTransferencia)
        {
            try
            {
                string procedure = "sp_transferenciaBancaria";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpfEmissor", SqlDbType.VarChar).Value = cbEmissor.cpf;
                command.Parameters.Add("@nomeEmissor", SqlDbType.VarChar).Value = cbEmissor.nomecompleto;
                command.Parameters.Add("@cpfRecebedor", SqlDbType.VarChar).Value = cbRecebedor.cpf;
                command.Parameters.Add("@nomeRecebedor", SqlDbType.VarChar).Value = cbRecebedor.nomecompleto;
                command.Parameters.Add("@valorTransferencia", SqlDbType.Decimal).Value = valorTransferencia;
                command.Parameters.Add("@quando", SqlDbType.DateTime).Value = DateTime.Now;

                if (cbEmissor.saldo >= valorTransferencia)
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    return "Transferência feita com sucesso!";
                }
                else
                {
                    return "Transferência não foi concluída com sucesso. Valor de transferência maior que o saldo que o emissor possui.";
                }
            }
            catch (SqlException ex)
            {
                return "Transferência não foi concluída com sucesso. \nErro: " + ex.Message;
            }
        }

    }
}
