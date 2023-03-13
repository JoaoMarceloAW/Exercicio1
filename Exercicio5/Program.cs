namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o volume de uma esfera: ");

            Console.WriteLine("Digite o valor do raio da esfera:");
                double raio = Convert.ToDouble (Console.ReadLine());

                double equacao = Math.Pow (raio , 3);

                double volume = ( 4.0 / 3.0) * Math.PI * equacao;


            Console.WriteLine("O calculo do volume é de: " + volume);



        }
    }
}