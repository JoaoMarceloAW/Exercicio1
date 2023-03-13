namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Digite o primeiro valor:");
            int primeirovalor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int segundovalor = Convert.ToInt32(Console.ReadLine());

            if (primeirovalor == segundovalor)
            {
                c = primeirovalor + segundovalor;
            }
            else
            {
                c = primeirovalor * segundovalor;
            }
            Console.WriteLine("O valor é de: " + c);
        }
    }
}