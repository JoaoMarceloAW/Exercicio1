namespace exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu nome:");
            string nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            int dias = 365;

            int calculo = idade * dias;

            Console.WriteLine("Você " + nome + " Tem o total de: " + calculo + " Dias");


        }
    }
}