using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class carro :veiculo
    {
        
        public int VelocidadeMaxima { get; set; }


        public void LigarMotor()
        {
            Console.WriteLine("Motor Ligado");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
         }


        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }


    }
}
