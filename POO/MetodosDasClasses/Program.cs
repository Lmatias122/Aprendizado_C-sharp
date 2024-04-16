using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Metodos m = new Metodos();
            #region
            //m.Cumprimentar();
            //m.Somar(10,5);
            //m.Apresentar("Matias", 19);


            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine("O valor 1: " + valor1);
            //Console.WriteLine("O valor 2: " + valor2);
            

            //string nomecompleto = m.MontaNome("Leonardo", "Matias");
            //int codigochar = m.CodigoChar('a');
            //double pi = m.ValorPI();

            //Console.WriteLine(nomecompleto);
            //Console.WriteLine(codigochar);
            //Console.WriteLine(pi);

            #endregion

            m.Cumprimentar();
            m.Cumprimentar("matias");
            m.Cumprimentar("Matias",17);

           bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Matias", "matias");

            Console.WriteLine(res1);
            Console.WriteLine(res2);

            Console.ReadKey();
           


        }
    }
}
