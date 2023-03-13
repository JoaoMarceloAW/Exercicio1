namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int cont = 0;

            Console.WriteLine("Programa números primos");
            Console.WriteLine("Informe o número:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    cont++;
                    break;
                }
            }

            if (cont == 0 && n > 1)
            {
                Console.WriteLine("O número " + n + " é um número primo");
            }
            else
            {
                Console.WriteLine("O número " + n + " não é um número primo");
            }

        }
    }
}