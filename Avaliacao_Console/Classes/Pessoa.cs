using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Console.Classes
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public int idade { get; set; }
        public decimal salario { get; set; }

        public virtual void mostraSalario()
        {
            Console.WriteLine(Nome + " - " + salario);
        }
        


    }
}
