using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Classes
{
    public class Windows
    {
        //CRIAÇÃO DE PASTA NO WINDOWS
        string raiz = @"C:\Facear_2019";
        string destino = @"C:\Facear_2020";


        public void criarPasta()
        {
            if (!Directory.Exists(raiz))
            {
                Console.WriteLine("Criando pasta..");
                Directory.CreateDirectory(raiz);
                Directory.CreateDirectory(destino);
                Console.ReadKey();
            }
        }

        public void criarArquivo(string nome_arquivo, string ext)
        {
            string arquivo = raiz + @"\" + nome_arquivo + "." + ext;
            File.Create(arquivo);
        }

        public void escreverArquivo(string texto_dentro)
        {
            string arquivo = raiz + @"\criarArquivo.txt";
            StreamWriter texto = new StreamWriter(arquivo, true);
            using (texto)
            {
                texto.WriteLine(texto_dentro + "\n");
            }
        }

        public void lerArquivo(string nome_arquivo, string ext)
        {
            string arquivo = raiz + @"\"+nome_arquivo+"."+ext;
            StreamReader leitura = new StreamReader(arquivo, true);
            using (leitura)
            {
                string linha = string.Empty;
                while ((linha = leitura.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public void apagarPasta()
        {
            if (Directory.Exists(raiz))
            {
                Console.WriteLine("Excluindo pasta..");
                Directory.Delete(raiz); //Directory.Delete(raiz,true); EXCLUI A PASTA E TUDO O QUE TEM DENTRO..
                Console.ReadKey();
            }
        }

        //MÉTODO DE MOVER ARQUIVOS DE UMA PASTA PARA OUTRA
        public void moverArquivos()
        {
            DirectoryInfo lista_pastas = new DirectoryInfo(raiz); //VAI ARMAZENAR AS INFORMAÇÕES DO QUE TEM DENTRO DA PASTA
            foreach (var item in lista_pastas.GetFiles())
            {
                Directory.Move(raiz + @"\" + item, destino + @"\" + item);
                //Console.WriteLine("\nNome do arquivo: " + item.Name + "\nExtensão: " + item.Extension + "\nCaminho: " + lista_pastas.FullName);
            }

            Console.ReadKey();
        }

        public void varrerPasta(string filtro)
        {
            DirectoryInfo lista_pastas = new DirectoryInfo(raiz); //VAI ARMAZENAR AS INFORMAÇÕES DO QUE TEM DENTRO DA PASTA
            foreach (var item in lista_pastas.GetFiles().Where(x => x.Name.Contains(filtro)))
            {
                Console.WriteLine("\nNome do arquivo: " + item.Name + "\nExtensão: " + item.Extension + "\nCaminho: " + lista_pastas.FullName);
            }
            Console.ReadKey();
        }
    }
}