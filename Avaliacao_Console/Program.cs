using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avaliacao_Console.Classes;
using Consulta.CNPJ;
using Consulta.CNPJ.Models;
using Consulta.CNPJ.Services;

namespace Avaliacao_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> listanomes = new List<string>();
            //listanomes.Add("Leonardo");
            //listanomes.Add("Talita");
            //listanomes.Remove("Leonardo");

            //for (int i=0; i<listanomes.Count; i++)
            //{
            //    Console.WriteLine(listanomes[i]);
            //}

            //foreach (var item in listanomes)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------

            //List<Pessoa> lista_pessoas = new List<Pessoa>();

            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Leonardo";
            //p1.idade = 20;
            //p1.salario = 1000.00m;
            //lista_pessoas.Add(p1);
            //Pessoa p2 = new Pessoa();
            //p2.Nome = "Talita";
            //p2.idade = 17;
            //p2.salario = 1500.00m;
            //lista_pessoas.Add(p2);

            //foreach (var item in lista_pessoas)
            //{
            //    Console.WriteLine(item.Nome + " - " + item.salario);
            //}

            //---------------------------------------------

            //List<Pessoa> lista_facear = new List<Pessoa>();

            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Leonardo";
            //p1.salario = 1000.00m;
            ////p1.mostraSalario();
            //lista_facear.Add(p1);

            //Funcionario f1 = new Funcionario();
            //f1.Nome = "Rodrigo";
            //f1.salario = 1000.00m;
            ////f1.mostraSalario();
            //lista_facear.Add(f1);

            //Socio s1 = new Socio();
            //s1.Nome = "Fabiano";
            //s1.salario = 1000.00m;
            ////s1.mostraSalario();
            //lista_facear.Add(s1);

            //mostraSalarioTodos(lista_facear);

            //consultarCNPJ();

            Console.ReadKey();

        }

        public static void consultarCNPJ()
        {
            Console.WriteLine("Insira o CNPJ: ");
            string cnpj = Console.ReadLine();

            CNPJService service = new CNPJService();
            CNPJResult result = service.ConsultarCPNJ(cnpj);

            Console.WriteLine("\n");
            Console.WriteLine("Nome da Empresa: " + result.Nome);
            Console.WriteLine("Situação: " + result.Situacao);
            Console.WriteLine("Telefone: " + result.Telefone);
            Console.WriteLine("UF: " + result.Uf);
            Console.WriteLine("Logradouro: " + result.Logradouro);
            Console.WriteLine("Municipio: " + result.Municipio);
        }

        public static void mostraSalarioTodos(List<Pessoa> lista)
        {
            for (int x=0; x<lista.Count; x++)
            {
                lista[x].mostraSalario();
            }
        }
    }
}
