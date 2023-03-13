namespace Exercicio2
{
    internal static class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Digite o  valor que será convertido em celcius: ");
          
            decimal f = Convert.ToDecimal(Console.ReadLine());

            decimal c = (f - 32) + 5 / 9;
            
            c= Math.Round(c, 2);
            
            Console.WriteLine(f + " O valor em celsius sera: " + c);

           
        }
    }
}