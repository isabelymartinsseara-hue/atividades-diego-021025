 //declaração de variáveis

 int nul;

 Console.WriteLine("Digite um número");
nul = int.Parse(Console.ReadLine());

if (nul > 10)
{
    Console.WriteLine($"O número {nul} é MAIOR QUE 10.");
}
else
{
    Console.WriteLine($"O número {nul}é MENOR que 10.");

}