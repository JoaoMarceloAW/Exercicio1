using System.Security.Cryptography;

namespace exercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro para calcular o seu fatorial: ");
            int a = int.Parse(Console.ReadLine());

            int fatorial = 1;
            string sequencia = "";
            for (int i = a; i >= 1; i--)
            {
                fatorial *= i;
                sequencia += i.ToString() + (i > 1 ? " x " : " = ");
            }
            sequencia += fatorial.ToString();

            Console.WriteLine(sequencia);
        }
    }
}