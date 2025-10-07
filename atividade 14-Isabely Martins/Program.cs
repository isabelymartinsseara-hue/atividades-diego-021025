Console.WriteLine("Digite um valor N (maior que 0): ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"\nNumeros de 1 ate {n}:");
for (int i = 1; i <= n; i++)

    Console.WriteLine(i);

Console.WriteLine("\nPressione Enter para sair...");
Console.ReadLine();