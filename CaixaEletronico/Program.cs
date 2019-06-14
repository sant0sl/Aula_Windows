using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Classes;
using CaixaEletronico.EDM;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            Console.Clear();
            int opcao;
            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("[       1 ] Criar Conta");
                Console.WriteLine("[       2 ] Depositar");
                Console.WriteLine("[       3 ] Sacar");
                Console.WriteLine("[       4 ] Consultar Saldo");
                Console.WriteLine("[       5 ] Ver Histórico");
                Console.WriteLine("[ 0 ou >6 ] Fechar");
                Console.WriteLine("-------------------------------------");
                Console.Write("\nDigite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        criarConta();
                        break;
                    case 2:
                        depositar();
                        break;
                    case 3:
                        sacar();
                        break;
                    case 4:
                        consultarSaldo();
                        break;
                    case 5:
                        consultarHistorico();
                        break;
                    default:
                        fechar();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
        }

        private static void fechar()
        {
            Console.WriteLine("\nAté mais!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void criarConta() {
            Console.Clear();

            conta c = new conta();

            Console.WriteLine("Insira seu nome: ");
            c.nome = Console.ReadLine();
            Console.WriteLine("Insira seu sobrenome: ");
            c.sobrenome = Console.ReadLine();
            Console.WriteLine("Insira seu CPF: ");
            c.cpf = Console.ReadLine();
            Console.WriteLine("Insira seu email: ");
            c.email = Console.ReadLine();

            CEletronico.criarConta(c);

            menu();
        }
        private static void depositar() {
            Console.Clear();

            string cpf;
            decimal valor;

            Console.WriteLine("Insira seu CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Insira o valor para depósito: ");
            valor = Convert.ToDecimal(Console.ReadLine());

            CEletronico.depositar(valor, cpf);

            menu();
        }
        private static void sacar() {
            Console.Clear();

            string cpf;
            decimal valor;

            Console.WriteLine("Insira seu CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Insira o valor para saque: ");
            valor = Convert.ToDecimal(Console.ReadLine());

            CEletronico.sacar(valor, cpf);

            menu();
        }
        private static void consultarSaldo() {
            Console.Clear();

            string cpf;

            Console.WriteLine("Insira seu CPF: ");
            cpf = Console.ReadLine();

            CEletronico.consultarSaldo(cpf);

            menu();
        }
        private static void consultarHistorico() {
            Console.Clear();

            string cpf;

            Console.WriteLine("Insira seu CPF: ");
            cpf = Console.ReadLine();

            Console.WriteLine(CEletronico.consultarHistorico(cpf));
            Console.ReadKey();

            menu();
        }

    }
}
