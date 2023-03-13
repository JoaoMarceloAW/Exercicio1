using System.Threading.Channels;

namespace exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de salário de um vendedor");
            Console.WriteLine();

            Console.WriteLine("Digite o salário do vendedor: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o quanto o vendedor vendeu: ");
            decimal vendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissão do vendedor: ");
            decimal porcentagem = Convert.ToDecimal(Console.ReadLine());

            decimal comissao = vendas * (porcentagem / 100);
            decimal salariototal = salario + comissao;

            Console.WriteLine("O total que o vendedor ganhou foi de $" + salariototal);





        }
    }
}