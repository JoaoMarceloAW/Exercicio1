namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Farenheits para celsius");

            Console.WriteLine();

            Console.WriteLine("Digite a temperatura em farenheits: ");

            decimal farenheits = Convert.ToDecimal (Console.ReadLine());

            decimal celsius = (farenheits - 32) / 1.8m;

            Console.WriteLine("A temperatura em celsius será de exatos:" + celsius);

         

        }
    }
}