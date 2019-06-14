using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Classes
{
    public class Pessoa
    {
        private int Idade;

        //GET E SET PADRÃO
        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        //GET E SET DA MICROSOFT
        private int Codigo;
        public int codigo
        {
            get { return this.Codigo; }
            set { Codigo = value; }
        }

        //GET E SET DA ATUALIDADE
        public string Nome { get; set; }
        public string sobrenome { get; set; }

        public void mostraIdade(int idade)
        {
            Console.WriteLine("Minha idade é:" + idade);
        }

        public void mostraIdade()
        {
            Console.WriteLine("Sua idade é: " + this.GetIdade());
        }

        public void mostraNome()
        {
            Console.WriteLine("Seu nome é: " + Nome);
        }
    }
}
