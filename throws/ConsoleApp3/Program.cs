using System.Data;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                throw new Exception("teste");

            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Segundo Catch: " + ex.Message);
            }
            catch (Exception ex )
            {
                Console.WriteLine("Primeiro Catch: " + ex.Message) ;

                throw ex ;
            }


            Console.ReadLine();
        }
    }
}