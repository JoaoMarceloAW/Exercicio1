using System.Runtime.InteropServices;

namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int conta;
            Console.WriteLine("Digite o primeiro numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)

            {
                conta = a + b;
            }
            else
            {
                conta = a * b;
            }
            Console.WriteLine("O valor é:" + conta);

        }
    }
}