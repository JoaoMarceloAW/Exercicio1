namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora para calcular o volume de um cilindro! ");

            Console.WriteLine("Digite o raio do seu cilindro: ");

            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite a altura do seu cilindro: ");

            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal calculo = (decimal)Math.PI * (decimal)Math.Pow(raio, 2) * altura;

            Console.WriteLine();

            Console.WriteLine("O valor do volume será de : " + calculo);

            Console.ReadKey();
        }
    }
}