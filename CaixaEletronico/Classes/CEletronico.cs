using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.EDM;

namespace CaixaEletronico.Classes
{
    class CEletronico
    {

        public static void criarConta(conta c) {
            Console.Clear();
            using (CEVSEntities entitieConta = new CEVSEntities())
            {
                c.saldo = 0.00m;
                c.numConta = geraNumConta();
                c.numAgencia = geraNumAgencia();
                entitieConta.contas.Add(c);
                entitieConta.SaveChanges();
                using (CEVSEntities entitieHistorico = new CEVSEntities())
                {
                    historico h = new historico();
                    h.cpf = c.cpf;
                    h.texto = "Conta aberta com sucesso! Seu saldo atual: " + c.saldo;
                    entitieHistorico.historicos.Add(h);
                    entitieHistorico.SaveChanges();
                }
            }
        }

        public static void sacar(decimal valor, string cpfSaque)
        {
            Console.Clear();
            conta c = new conta();

            using (CEVSEntities entitieConta = new CEVSEntities())
            {
                c = entitieConta.contas.FirstOrDefault(x => x.cpf == cpfSaque);

                if (c == null)
                {
                    Console.WriteLine("Não foi encontrado ninguém com este CPF na nossa base de dados! Operação Cancelada.");
                    Console.ReadKey();
                }
                else
                {
                    if (c.saldo < valor)
                    {
                        Console.WriteLine("Valor desejado para saque é maior que o disponível. Operação cancelada!");
                        Console.ReadKey();
                    }
                    else
                    {
                        c.saldo = c.saldo - valor;
                        entitieConta.SaveChanges();
                        using (CEVSEntities entitieHistorico = new CEVSEntities())
                        {
                            historico h = new historico();
                            h.cpf = c.cpf;
                            h.texto = "Saque de: " + valor + " efetuado com sucesso! Seu saldo atual: " + c.saldo;
                            entitieHistorico.historicos.Add(h);
                            entitieHistorico.SaveChanges();
                        }
                    }
                }
            }
        }

        public static void depositar(decimal valor, string cpfDeposito)
        {
            Console.Clear();
            conta c = new conta();

            using (CEVSEntities entitieConta = new CEVSEntities())
            {
                c = entitieConta.contas.FirstOrDefault(x => x.cpf == cpfDeposito);

                if (c == null)
                {
                    Console.WriteLine("Não foi encontrado ninguém com este CPF na nossa base de dados! Operação Cancelada.");
                    Console.ReadKey();
                }
                else
                {
                    c.saldo = c.saldo + valor;
                    entitieConta.SaveChanges();
                    using (CEVSEntities entitieHistorico = new CEVSEntities())
                    {
                        historico h = new historico();
                        h.cpf = c.cpf;
                        h.texto = "Depósito de: " + valor + " efetuado com sucesso! Seu saldo atual: " + c.saldo;
                        entitieHistorico.historicos.Add(h);
                        entitieHistorico.SaveChanges();
                    }
                }
            }
        }

        public static void consultarSaldo(string cpfConsulta)
        {
            Console.Clear();
            conta c = new conta();

            using (CEVSEntities entitieConta = new CEVSEntities())
            {
                c = entitieConta.contas.FirstOrDefault(x => x.cpf == cpfConsulta);

                if (c == null)
                {
                    Console.WriteLine("Não foi encontrado ninguém com este CPF na nossa base de dados! Operação Cancelada.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Seu saldo atual é de: " + c.saldo);
                    Console.ReadKey();
                    using (CEVSEntities entitieHistorico = new CEVSEntities())
                    {
                        historico h = new historico();
                        h.cpf = c.cpf;
                        h.texto = "Foi feito uma consulta recentemente do seu saldo! Seu saldo atual: " + c.saldo;
                        entitieHistorico.historicos.Add(h);
                        entitieHistorico.SaveChanges();
                    }
                }
            }
        }

        public static List<historico> consultarHistorico(string cpfConsulta)
        {
            Console.Clear();
            conta c = new conta();
            List<historico> lista_historico = new List<historico>();

            using (CEVSEntities entitieConta = new CEVSEntities())
            {
                c = entitieConta.contas.FirstOrDefault(x => x.cpf == cpfConsulta);

                if (c == null)
                {
                    Console.WriteLine("Não foi encontrado ninguém com este CPF na nossa base de dados! Operação Cancelada.");
                    Console.ReadKey();
                }
                else
                {
                    lista_historico = entitieConta.historicos.SqlQuery("select * from historicos where cpf='" + cpfConsulta + "'").ToList();

                    if (lista_historico == null)
                    {
                        Console.WriteLine("Não foi encontrado ninguém com este CPF na nossa base de dados! Operação Cancelada.");
                        Console.ReadKey();
                    }
                    else
                    {
                        foreach (historico h in lista_historico)
                        {
                            Console.WriteLine("CPF: " + h.cpf + " - " + h.texto + "\n");
                        }
                        Console.ReadKey();
                        using (CEVSEntities entitieHistorico = new CEVSEntities())
                        {
                            historico h = new historico();
                            h.cpf = cpfConsulta;
                            h.texto = "Foi feito uma consulta recentemente do seu histórico!";
                            entitieHistorico.historicos.Add(h);
                            entitieHistorico.SaveChanges();
                        }
                    }
                }
            }
            return lista_historico;
        }

        public static int geraNumConta()
        {
            Random r = new Random();
            return r.Next(1,3);
        }

        public static int geraNumAgencia()
        {
            Random r = new Random();
            return r.Next(4,6);
        }

    }
}
