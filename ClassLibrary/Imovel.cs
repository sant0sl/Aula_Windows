using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Imovel
    {

        private string connectionString { get; } = @"Data Source=SANT0SLNOTE;Initial Catalog=imobiliaria;Integrated Security=True";

        public int id { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public bool situacao { get; set; }
        public bool tipo_locacao { get; set; }
        public decimal valor { get; set; }

        //Métodos Imovel--------------------------------------------

        public string cadastrarImovel()
        {
            try
            {
                string procedure = "sp_createImovel";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = this.cidade;
                command.Parameters.Add("@bairro", SqlDbType.VarChar).Value = this.bairro;
                command.Parameters.Add("@situacao", SqlDbType.Bit).Value = this.situacao;
                command.Parameters.Add("@tipo", SqlDbType.Bit).Value = this.tipo_locacao;
                command.Parameters.Add("@valor", SqlDbType.Decimal).Value = this.valor;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Imóvel cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Imóvel não foi cadastrado.\n" + ex.Message;
            }
        }

        public string alterarImovel()
        {
            try
            {
                string procedure = "sp_updateImovel";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = this.id;
                command.Parameters.Add("@cpf", SqlDbType.VarChar).Value = this.cpf;
                command.Parameters.Add("@cidade", SqlDbType.VarChar).Value = this.cidade;
                command.Parameters.Add("@bairro", SqlDbType.VarChar).Value = this.bairro;
                command.Parameters.Add("@situacao", SqlDbType.Bit).Value = this.situacao;
                command.Parameters.Add("@tipo", SqlDbType.Bit).Value = this.tipo_locacao;
                command.Parameters.Add("@valor", SqlDbType.Decimal).Value = this.valor;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Imóvel alterado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Imóvel não foi alterado.\n" + ex.Message;
            }
        }

        public DataSet buscaImoveis()
        {
            try
            {
                string procedure = "sp_buscaImoveis";
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

        public string excluirImovel()
        {
            try
            {

                string procedure = "sp_deleteImovel";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.id;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return "Imóvel deletado com sucesso!";
            }
            catch (SqlException ex)
            {
                return "Imóvel não foi deletado.\n" + ex.Message;
            }
        }

        //Outros métodos--------------------------------------------

        public Imovel buscaImovelPorID(string id)
        {
            try
            {
                string procedure = "sp_buscarImovelPorID";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.id = Convert.ToInt32(reader[0].ToString());
                        this.cpf = reader[1].ToString();
                        this.cidade = reader[2].ToString();
                        this.bairro = reader[3].ToString();
                        this.situacao = Convert.ToBoolean(reader[4].ToString());
                        this.tipo_locacao = Convert.ToBoolean(reader[5].ToString());
                        this.valor = Convert.ToDecimal(reader[6].ToString());
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

        //Busca por cidade ou bairro
        public DataSet buscaImoveisPorFiltro(string filtro)
        {
            try
            {
                string procedure = "sp_buscarImovelPorFiltro";
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

        //Busca por Situacao
        public DataSet buscaImoveisPorSituacao(bool situacao)
        {
            try
            {
                string procedure = "sp_buscarImovelPorSituacao";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@situacao", SqlDbType.Bit).Value = situacao;

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(ds);

                return ds;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        //Busca por Tipo de alocação
        public DataSet buscaImoveisPorTipo(bool tipo)
        {
            try
            {
                string procedure = "sp_buscarImovelPorTipo";
                DataSet ds = new DataSet();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@tipo", SqlDbType.Bit).Value = tipo;

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
