namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora média harmonica ");
            
            Console.WriteLine("Digite a quantidade de numeros:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double somainversos = 0;
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o numero:" + i);
                double numero = Convert.ToDouble(Console.ReadLine());
                somainversos += 1 / numero;

            }
            double mediaharmonica = quantidade / somainversos;
            Console.WriteLine("a média harmonica é de:" + mediaharmonica);



            





        }
    }
}