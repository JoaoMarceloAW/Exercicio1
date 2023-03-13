namespace Exercicio1
{
    internal static class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Preencha os campos de uma caixa retangular");
            
            Console.WriteLine();

            Console.WriteLine("Comprimento ");
            int Comprimento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largura ");
            int Largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Altura ");
            int Altura = Convert.ToInt32(Console.ReadLine());

            int volume = Comprimento + Largura + Altura;

            Console.WriteLine("O volume é de: " + volume);

            Console.ReadLine();

        }
    }
}