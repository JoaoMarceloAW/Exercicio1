using System.ComponentModel.Design;

namespace exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;


            Console.WriteLine("Digite o valor de A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite  o valor de C:");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b < c) 
            {
                Console.WriteLine("O seu valor esta correto");
            }
            else if (a + b > c)
            {
                Console.WriteLine("O seu valor esta incorreto");
            }
        }
    }
}