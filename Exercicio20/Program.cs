namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Programa para saber se seu numero é par ou impar");
            Console.WriteLine("Digite o seu numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Seu numero é par");
            }
            else
            {
                Console.WriteLine("Seu numero é impar");
            }
        }
    }
}