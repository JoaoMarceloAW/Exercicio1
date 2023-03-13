namespace exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite quantos metros tem o lado esquerdo do seu terreno: ");
            decimal ladoA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite quantos metros tem  o lado direito do seu terreno: ");
            decimal ladob = Convert.ToDecimal(Console.ReadLine());

            decimal area = ladoA * ladob;

            Console.WriteLine("A area do seu é de:" + area + " Metros quadrados");
        }
    }
}