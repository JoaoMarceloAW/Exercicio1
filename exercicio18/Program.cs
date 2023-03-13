namespace exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("Informe 3 valores inteiros para que seja exibido em ordem decrescente");

            Console.WriteLine("Informe o primeiro valor:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor:");

            c = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c && b < c)
            {
                Console.WriteLine(a , b , c);
            }
            else if (b < a && b < c && a < c)
            {
                Console.WriteLine(b + a + c);
            }
            else if (c < a && c < b && b < a)
            {
                Console.WriteLine(c + b + a);
            }
        }
    }
}