using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);
        
            Console.WriteLine("Valor 1: "+valor1);
            Console.WriteLine("Valor 2: " + valor2);

#endregion

            Console.ReadKey();
        }

    }
}
