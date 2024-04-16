using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {


        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }


    }

    internal class Humano
    {
        protected string nome;
        private string sobrenome;

        internal int idade; 
    }

    internal class Homem : Humano 
    { 
        public void Metodo()
        {
            nome = "";
        }
    }

}
