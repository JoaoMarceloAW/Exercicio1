namespace exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento, desconto;
            Console.WriteLine("Programa para ler o salario do funcionario ");
                Console.WriteLine("Digite o valor que o funcionario ganha:");
               salario = double.Parse(Console.ReadLine());
            aumento = salario * 1.15;

            desconto = aumento * 0.92;

            Console.WriteLine("O salario inical do funcionario é de: R$" + salario);
            Console.WriteLine("O Salario do funcionario com o aumento será de: R$" + aumento);
            Console.WriteLine("O salario final do funcionario será de: R$" + desconto);

        }
    }
}