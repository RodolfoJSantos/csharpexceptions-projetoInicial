using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            M1();

            Console.ReadLine();
        }

            
        
      private static void M1()
        {
            Console.WriteLine("Iniciando método 1");
            Console.WriteLine("Chamando método 2");
            try
            {
                M2();
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine("Msg capiturada em M1");
            }
            
        }

        private static void M2()
        {
            Console.WriteLine("Iniciando Método 2");
            Console.WriteLine("chamando método 3");

            try
            {
                M3();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Msg capturada em M2");
            }
        }

        private static void M3()
        {
            try
            {
                int divisor = 0;
                int resultado = 1 / divisor;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("mensagem capturada em M3");
            }

           
        }
    }
}
