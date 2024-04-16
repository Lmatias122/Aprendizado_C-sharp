using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Fatorial(num));

            Console.ReadKey();
        }

        static int Fatorial(int num)
        {            
            if(num<=0)
            {
                return 1;
            }

            return num*Fatorial(num - 1);
        }
    }
}
