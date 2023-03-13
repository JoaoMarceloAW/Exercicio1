namespace Exercicio_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int f = 0;

            int c = 0;

            Console.WriteLine("Entre com a temperatura em fahrenheit: ");

            f= Convert.ToInt32(Console.ReadLine());

            c = (int)5 / 9 * (f - 32);

            Console.WriteLine("Temperatura Convertida em celcius é de: " + c);

            





        }
    }
}