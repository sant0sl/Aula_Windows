using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_Console.Classes
{
    public class Socio : Pessoa
    {
        public override void mostraSalario()
        {
            decimal salario_bruto = salario + 500.00m;
            Console.WriteLine(Nome + " - " + salario_bruto);
        }

    }
}
