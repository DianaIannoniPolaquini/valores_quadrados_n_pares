using System;

namespace MESMO_QUADRADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string entrada;

            Console.Write("Entre com um valor: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int n);

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}.");
                }
            }
        }
    }
}
