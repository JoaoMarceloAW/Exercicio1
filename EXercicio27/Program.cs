namespace EXercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            Console.Write(a + " " + b + " ");

            while (c < num)
            {
                c = a + b;
                if (c > num)
                    break;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }

}