
using System;

namespace FatorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            long fatorial = 1; // Usando long para evitar erro com números grandes

            Console.WriteLine("=== Cálculo de Fatorial ===");
            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Fatorial de número negativo não existe!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"O fatorial de {n} é: {fatorial}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }

}