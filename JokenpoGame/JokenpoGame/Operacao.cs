using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenpoGame
{
    public class Operacao
    {
     
        public static int Calculo(int valor) 
        {
            Random r = new Random();
            if (valor == 1)
            {      
                var a = r.Next(1, 4);
                return a;
            }
            if (valor == 2)
            {
                var a = r.Next(1, 4);
                return a;
            }
            if (valor == 3)
            {
                var a = r.Next(1, 4);
                return a;
            }
            return 2;
        }


        public static int Resultado(int valorEscolhido, int valorPc) 
        {
            if(valorEscolhido == valorPc)
            {
                //empate

            }
            if (valorEscolhido > valorPc)
            {
                //ganhou
            }
            if (valorEscolhido < valorPc)
            {
                //perdeu
            }
            return 3;
        }

    }
}
