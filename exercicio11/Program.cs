namespace exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public static bool IsPrime(int n)
            {
                // 1 não é primo
                if (n == 1)
                {
                    return false;
                }
                // 2 e 3 são primos
                else if (n == 2 || n == 3)
                {
                    return true;
                }
                // nenhum número par é primo, exceto o 2
                else if (n % 2 == 0)
                {
                    return false;
                }
                // testa os números ímpares de 3 a n-1
                else
                {
                    for (int i = 3; i < n; i += 2)
                    {
                        if (n % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                    Console.WriteLine("Digite aqui um número de 0 a 100 para saber se ele é primo:");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (IsPrime(numero))
                    {
                        Console.WriteLine(numero + " é primo.");
                    }
                    else
                    {
                        Console.WriteLine(numero + " não é primo.");
                    }
                }
            }
             




        }
    }
}