using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1.Classes
{
    public class Matematica
    {
        public int n1 { get; set; }
        public int n2 { get; set; }

        public static void verificaNumero(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                Console.WriteLine("O N1 é maior!");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O N2 é maior!");
            }
            else if (numero1 == numero2)
            {
                Console.WriteLine("Os números são iguais!");
            }
        }

        public static void tabuadaDoNumero(int numero1)
        {
            Console.WriteLine("\nTabuada do " + numero1);
            for (int i=0; i<11; i++)
            {
                Console.WriteLine(numero1+"X"+i+"="+numero1*i);
            }
        }
    }
}
