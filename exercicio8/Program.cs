namespace exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {    double pi = 3.14159;
            Console.WriteLine("Calculadora do volume de uma lata de óleo:");

            Console.WriteLine("Digite o raio da sua lata de óleo:");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da sua lata de óleo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = pi * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da sua lata de óleo será de: " + volume);



        }
    }
}