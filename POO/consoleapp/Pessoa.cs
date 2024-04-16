using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp
{
    internal class Pessoa
    {
        //Atributos / Campos
        public string? nome;
        public string? sobrenome;
        public int? anoNascimento;


        // Métodos Simples
        public void Cumprimentar()
        {

            Console.WriteLine("Ola eu sou " + nome + " " + sobrenome);

        }
    }

}
