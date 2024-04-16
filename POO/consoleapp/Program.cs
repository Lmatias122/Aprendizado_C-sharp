using System.Data.Common;

namespace consoleapp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Classe Pessoa
            Pessoa p1 = new Pessoa();
            p1.nome = "Leonardo";
            p1.sobrenome = "Matias";
            p1.anoNascimento = 2004;


            Pessoa p2 = new Pessoa()
            {
                nome = "pedro",
                sobrenome = "mattos",
                anoNascimento = 2000
            };

            p1.nome = "Joao";

            Console.WriteLine("Pessoa1: " + p1.nome);
            Console.WriteLine("Pessoa1: " + p1.sobrenome);
            Console.WriteLine("Pessoa1: " + p1.anoNascimento);

            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine("Pessoa2: " + p2.nome);
            Console.WriteLine("Pessoa2: " + p2.sobrenome);
            Console.WriteLine("Pessoa2: " + p2.anoNascimento);

            p2.Cumprimentar();

            Console.ReadKey();
            #endregion


        }
    }
}