using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Console.Classes
{
    public class Funcionario : Pessoa
    {
        public override void mostraSalario()
        {
            decimal salario_bruto = salario + 100.00m;
            Console.WriteLine(Nome + " - " + salario_bruto);
        }

    }
}
