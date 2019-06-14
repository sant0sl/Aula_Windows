using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppThread
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread minhaThread = new Thread(mostraLetra);
            minhaThread.Start();
            Console.ReadKey();
        }

        static void mostraNumeros()
        {
            for (int i=1; i<301; i++)
            {
                Console.WriteLine("1");
            }
        }

        static void mostraLetra()
        {
            for (int i = 1; i < 301; i++)
            {
                Console.Write("A");
            }
        }
    }
}
