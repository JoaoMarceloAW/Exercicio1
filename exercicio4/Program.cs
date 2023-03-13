namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe a velocidade inicial percorrida: ");
            
            decimal velocidadeinicial = Convert.ToDecimal(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Informe a velocidade final percorrida: ");

            decimal velocidadefinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Informe quantos litros foram gastos: ");
            
            decimal litros = Convert.ToDecimal(Console.ReadLine());

            decimal consumo = (velocidadefinal - velocidadeinicial) / litros;

            Console.WriteLine("O consumo médio foi de: " + consumo + "Km/L ");

            Console.ReadKey();






        }
    }
}