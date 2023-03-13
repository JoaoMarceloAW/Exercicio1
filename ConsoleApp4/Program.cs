namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para gerar uma tabuada  entre 1 e 10");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            int numero = 1;
            while (numero <= 10)
            {
                int resultado = tabuada * numero;
                Console.WriteLine(tabuada + "X" + numero + "=" + resultado);
                numero = numero + 1;
            }
        }
    }
}