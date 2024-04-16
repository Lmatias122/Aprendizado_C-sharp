using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {

        //Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Ola seja bem vindo.");
        }

        //Métodos com Parâmetros

        public void Somar(int num1, int num2)
        {
            int resultado= num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + "anos");
        }

        // Passagem de parametros por valor

        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é " +  valor);
        }

        // Passagem de parametros por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referencia) é " + valor);
        }

        // Métodos com retorno de valores

        public string MontaNome(string nome, string sobrenome)
        {
            string NomeCompleto = nome + " " + sobrenome;
            return NomeCompleto;
        }

        public int CodigoChar(char caractere)
        {
         
            //int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        // Sobrecarga de Metodos

        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Ola, " + nome + " Seja Bem Vindo");
        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa Tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
