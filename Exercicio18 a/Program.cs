namespace Exercicio18_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Informe 3 valores inteiros para que seja exibido em ordem decrescente");
            Console.WriteLine("Informe o primeiro valor:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor:");
            c = Convert.ToDouble(Console.ReadLine());
            if (a <= b && a <= c)
            {
                if (b <= c)
                {
                    Console.WriteLine($"{a}, {b}, {c}");
                }
                else
                {
                    Console.WriteLine($"{a}, {c}, {b}");
                }
            }
            else if (b <= a && b <= c)
            {
                if (a <= c)
                {
                    Console.WriteLine($"{b}, {a}, {c}");
                }
                else
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }
            else
            {
                if (a <= b)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
                else
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            }
        }
    }
}