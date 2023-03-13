namespace exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtdpaes, qtdbroas, valorpaes, valorbroas, poupança, totalvendas;
                Console.WriteLine("Digite a quantidade de paes que foram vendidos:"); 
                qtdpaes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas que foram vendidas");
                qtdbroas = Convert.ToDouble(Console.ReadLine());

            valorpaes = 0.12 * qtdpaes;
            valorbroas = 1.50 * qtdbroas;
            totalvendas = valorpaes + valorbroas;
            poupança = totalvendas * 0.10;

            Console.WriteLine("O dono da padaria conseguirá botar na poupança o total de: " + totalvendas);
            



           

            
        }
    }
}