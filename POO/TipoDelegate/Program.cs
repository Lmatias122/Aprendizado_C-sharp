using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operacao Conta = null;

            Conta += m.Somar;
            Conta += m.Subtair;
            Conta += m.Multiplicar;
            Conta += m.Dividir;

            Conta(10, 2);

            Console.WriteLine();

            Conta -= m.Dividir;
            Conta -= m.Subtair;

            Conta(15, 3);

            Console.ReadKey();




        }
    }
}
