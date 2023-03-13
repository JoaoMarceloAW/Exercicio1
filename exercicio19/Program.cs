namespace exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Programa para calcular o IMC");
            Console.WriteLine("Digite o peso em kg:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em metros:");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("O seu IMC é de: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }



        }
    }
}