using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
           // carro c = new carro();  
           // Bicicleta b = new Bicicleta();

           // c.Acelerar();
           //b.Acelerar();

           // c.Parar();
           // b.Parar();

            #endregion

            Humano  a    =  new Humano();
            Pessoa  b    =  new Pessoa();    
            Homem   c    =  new Homem();

            Console.Write("\nHumano\n");

            a.Olhos();
            a.Cabelos();

            Console.Write("\nPessoa\n");

            b.Olhos();
            b.Cabelos();

            Console.Write("\nHomem\n");

            c.Olhos();
            c.Cabelos();
            


            Console.ReadKey();


            
            
        }
    }
}
