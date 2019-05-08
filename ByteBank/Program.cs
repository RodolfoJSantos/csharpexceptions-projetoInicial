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
            //M1();

            try
            {

                ContaCorrente conta = new ContaCorrente(123, 978324);

                conta.Depositar(50);
                Console.WriteLine("Saldo da conta: " + conta.Saldo);
                conta.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro de ArgumentException.");
                Console.WriteLine(ex.Message);
            }

            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Msg capturada em M2");
                Console.WriteLine(ex.Message);
            }
        }

        private static void M3()
        {
            try
            {
                int divisor = 0;
                int resultado = 1 / divisor;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("mensagem capturada em M3");
                Console.WriteLine(ex.Message);

                throw;
            }

           
        }
    }
}
