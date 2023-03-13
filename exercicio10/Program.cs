namespace exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora dé media ponderada");
            Console.WriteLine("Digite a primeira nota:");
                double primeiranota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira nota");
                double pesoprimeirantoa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
                double segundanota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda nota:");
                double pesodasegundanota = Convert.ToDouble(Console.ReadLine());

            double somadospesos = pesoprimeirantoa + pesodasegundanota;

            double somadasnotas = (primeiranota * pesoprimeirantoa) + (segundanota * pesodasegundanota);

            double mediaponderada = somadasnotas / somadospesos ;

            Console.WriteLine("A média ponderada do aluno é:" + mediaponderada);





        }
    }
}