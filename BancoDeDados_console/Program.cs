using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeDados_console.Controllers;


namespace BancoDeDados_console
{
    public class Program
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
                Console.WriteLine("[       1 ] Listar Clientes");
                Console.WriteLine("[       2 ] Registrar Cliente");
                Console.WriteLine("[       3 ] Alterar Cliente");
                Console.WriteLine("[       4 ] Apagar Cliente");
                Console.WriteLine("[ 0 ou >4 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("\nDigite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        readCliente();
                        break;
                    case 2:
                        createCliente();
                        break;
                    case 3:
                        updateCliente();
                        break;
                    case 4:
                        deleteCliente();
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

        private static void createCliente()
        {
            Console.Clear();
            using (ClienteEntities entitie = new ClienteEntities())
            {
                bool nomeaux = false;
                bool emailaux = false;
                bool sexoaux = false;

                cliente cliente = new cliente();

                Console.WriteLine("Insira seu nome: (50 Caracteres) - 0 para cancelar");
                cliente.name = Console.ReadLine();
                if (cliente.name.Equals("0")){
                    menu();
                }else if (cliente.name.Equals(null) || cliente.name.Equals("") || cliente.name.Length > 50) {
                    Console.WriteLine("\nNome deve conter menos que 50 caracteres e não pode ser nulo...");
                    Console.ReadKey();
                    menu();
                }
                else {
                    nomeaux = true;
                }

                Console.WriteLine("Insira seu e-mail: (50 Caracteres) - 0 para cancelar");
                cliente.email = Console.ReadLine();
                if (cliente.email.Equals("0"))
                {
                    menu();
                }
                else if(cliente.email.Equals(null) || cliente.email.Equals("") || cliente.email.Length > 50)
                {
                    Console.WriteLine("\nE-mail deve conter menos que 50 caracteres e não pode ser nulo...");
                    Console.ReadKey();
                    menu();
                }
                else{
                    emailaux = true;
                }

                Console.WriteLine("Insira seu sexo: (m/f) - 0 para cancelar");
                cliente.sexo = Console.ReadLine();
                if (cliente.sexo.Equals("0"))
                {
                    menu();
                }
                else if(cliente.sexo.Equals(null) || cliente.sexo.Equals("") || cliente.sexo.Length > 1)
                {
                    Console.WriteLine("\nSexo deve ser apenas 'm' ou 'f' e não pode ser nulo...");
                    Console.ReadKey();
                    menu();
                }
                else if(cliente.sexo.Equals("m") || cliente.sexo.Equals("f"))
                {
                    sexoaux = true;
                }
                else
                {
                    Console.WriteLine("\nSexo deve ser apenas 'm' ou 'f' e não pode ser nulo...");
                    Console.ReadKey();
                    menu();
                }


                if (nomeaux==true && emailaux==true && sexoaux==true)
                {
                    entitie.clientes.Add(cliente);
                    Console.WriteLine("Registrando dados... \n");
                    entitie.SaveChanges();
                }

                Console.WriteLine("\nPressione qualquer tecla pra voltar ao menu...");
                Console.ReadKey();
            }
        }

        private static void readCliente()
        {
            Console.Clear();
            Console.WriteLine("Lendo informações na base de dados... \n\n");
            using (ClienteEntities entitie = new ClienteEntities())
            {
                cliente cliente = new cliente();
                List<cliente> listaClientes = new List<cliente>();

                listaClientes = entitie.clientes.ToList();
                foreach (cliente c in listaClientes)
                {
                    Console.WriteLine("(UID)" + c.UID + ": (Nome)" + c.name + " - (E-mail)" + c.email + " - (Sexo)" + c.sexo + "\n");
                }
                Console.WriteLine("\n\nSe não aparecer nada, é porque não há registros\n\nPressione qualquer tecla pra voltar ao menu...");
                Console.ReadKey();
            }
        }

        private static void updateCliente()
        {
            Console.Clear();
            Console.WriteLine("Lendo informações na base de dados... \n\n");
            using (ClienteEntities entitie = new ClienteEntities())
            {
                bool nomeaux = false;
                bool emailaux = false;
                bool sexoaux = false;

                cliente cliente = new cliente();
                List<cliente> listaClientes = new List<cliente>();

                listaClientes = entitie.clientes.ToList();
                foreach (cliente c in listaClientes)
                {
                    Console.WriteLine("(UID)" + c.UID + ": (Nome)" + c.name + " - (E-mail)" + c.email + " - (Sexo)" + c.sexo + "\n");
                }

                Console.WriteLine("\nSe não aparecer nada, é porque não há registros");
                Console.WriteLine("\nInsira seu UID: (0 para voltar ao menu)");
                cliente.UID = Convert.ToInt32(Console.ReadLine());

                if (cliente.UID == 0)
                {
                    menu();
                }
                else
                {
                    cliente = entitie.clientes.FirstOrDefault(c => c.UID == cliente.UID);

                    Console.WriteLine("Insira seu nome: " + cliente.name + "(<Atual)(50 Caracteres) - 0 para cancelar");
                    cliente.name = Console.ReadLine();
                    if (cliente.name.Equals("0"))
                    {
                        menu();
                    }
                    else if (cliente.name.Equals(null) || cliente.name.Equals("") || cliente.name.Length > 50)
                    {
                        Console.WriteLine("\nNome deve conter menos que 50 caracteres e não pode ser nulo...");
                        Console.ReadKey();
                        menu();
                    }
                    else
                    {
                        nomeaux = true;
                    }

                    Console.WriteLine("Insira seu e-mail: " + cliente.email + "(<Atual)(50 Caracteres) - 0 para cancelar");
                    cliente.email = Console.ReadLine();
                    if (cliente.email.Equals("0"))
                    {
                        menu();
                    }
                    else if (cliente.email.Equals(null) || cliente.email.Equals("") || cliente.email.Length > 50)
                    {
                        Console.WriteLine("\nE-mail deve conter menos que 50 caracteres e não pode ser nulo...");
                        Console.ReadKey();
                        menu();
                    }
                    else
                    {
                        emailaux = true;
                    }

                    Console.WriteLine("Insira seu sexo: " + cliente.sexo + "(<Atual)(m/f) - 0 para cancelar");
                    cliente.sexo = Console.ReadLine();
                    if (cliente.sexo.Equals("0"))
                    {
                        menu();
                    }
                    else if (cliente.sexo.Equals(null) || cliente.sexo.Equals("") || cliente.sexo.Length > 1)
                    {
                        Console.WriteLine("\nSexo deve ser apenas 'm' ou 'f' e não pode ser nulo...");
                        Console.ReadKey();
                        menu();
                    }
                    else if (cliente.sexo.Equals("m") || cliente.sexo.Equals("f"))
                    {
                        sexoaux = true;
                    }
                    else
                    {
                        Console.WriteLine("\nSexo deve ser apenas 'm' ou 'f' e não pode ser nulo...");
                        Console.ReadKey();
                        menu();
                    }

                    if (nomeaux == true && emailaux == true && sexoaux == true)
                    {
                        Console.WriteLine("Atualizando dados... \n");
                        entitie.SaveChanges();
                    }
                    
                    Console.WriteLine("Pressione qualquer tecla pra voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        private static void deleteCliente()
        {
            Console.Clear();
            Console.WriteLine("Lendo informações na base de dados... \n\n");
            using (ClienteEntities entitie = new ClienteEntities())
            {
                cliente cliente = new cliente();
                List<cliente> listaClientes = new List<cliente>();

                listaClientes = entitie.clientes.ToList();
                foreach (cliente c in listaClientes)
                {
                    Console.WriteLine("(UID)" + c.UID + ": (Nome)" + c.name + " - (E-mail)" + c.email + " - (Sexo)" + c.sexo + "\n");
                }

                Console.WriteLine("\nSe não aparecer nada, é porque não há registros");
                Console.WriteLine("\nInsira seu UID: (0 para voltar ao menu)");
                cliente.UID = Convert.ToInt32(Console.ReadLine());

                if (cliente.UID == 0)
                {
                    menu();
                }
                else
                {
                    cliente = entitie.clientes.FirstOrDefault(c => c.UID == cliente.UID);

                    int confirmaux;
                    Console.WriteLine("\nDeseja mesmo apagar esse registro definitivamente? (0-Não/1-Sim)");
                    confirmaux = Convert.ToInt32(Console.ReadLine());

                    if (confirmaux == 1)
                    {
                        Console.WriteLine("Apagando da base de dados... \n");
                        entitie.clientes.Remove(cliente);
                        Console.WriteLine("Apagado com sucesso!... \n");
                        entitie.SaveChanges();
                        Console.WriteLine("\nPressione qualquer tecla pra voltar ao menu...");
                        Console.ReadKey();
                        menu();
                    }
                    else if (confirmaux == 0)
                    {
                        Console.WriteLine("\nO Registro não foi apagado...");
                        Console.WriteLine("\nPressione qualquer tecla pra voltar ao menu...");
                        Console.ReadKey();
                        menu();
                    }
                    else if (confirmaux > 1)
                    {
                        Console.WriteLine("\nO Registro não foi apagado...");
                        Console.WriteLine("\nPressione qualquer tecla pra voltar ao menu...");
                        Console.ReadKey();
                        menu();
                    }
                    else
                    {
                        Console.WriteLine("\nO Registro não foi apagado...");
                        Console.WriteLine("\nPressione qualquer tecla pra voltar ao menu...");
                        Console.ReadKey();
                        menu();
                    }
                }
            }
        }
    }
}
