using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Calculadora
    {
        float n1, n2,soma;

        public float  Soma(float n1, float n2)
        {
            return n1 + n2;
        }

        public float Subtracao(float n1, float n2)
        {
            return n1 - n2;
        }
        public float Multiplicacao(float n1, float n2)
        {
            return n1 * n2;
        }
        public float Divisao(float n1, float n2)
        {
            return n1 / n2;
        }

        public void astring()//metodo
        {
            Console.WriteLine("Digite N1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite N2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções");
           Console.WriteLine("a");
           Console.WriteLine("b");
           Console.WriteLine("c");
           Console.WriteLine("d");



            float resultado;
            String Texto = Console.ReadLine();
            switch (Texto)
            {
                case "a": resultado = Soma(n1, n2);
                    Console.WriteLine(resultado);
                    break;

                case "b": resultado = Subtracao(n1, n2); Console.WriteLine(resultado); break;
                case "c": resultado = Multiplicacao(n1, n2); Console.WriteLine(resultado); break;
                case "d":
                    while (n2 <= 0)
                    {

                        Console.WriteLine("O valor deve ser maior que 0, Digite um novo valor");
                        n2 = float.Parse(Console.ReadLine());
                    }
                    
                    resultado = Divisao(n1, n2); Console.WriteLine("O Resultado da divisao é: "+resultado); 
                    break;

                default: Console.WriteLine("Opção invalida");break;
            }
            Console.ReadKey();
                    
        }
    }
}
