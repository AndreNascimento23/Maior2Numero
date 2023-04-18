Console.Clear();

double numero1, numero2;

Console.WriteLine(" --- Qual Número é Maior ---\n");

Console.Write("Digite o primeiro número: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"O maior número é {numero1}");
}
else if (numero1 < numero2)
{
    Console.WriteLine($"O maior número é {numero2}");
}
else
{
    Console.WriteLine(" --- Os dois números são iguais ---");
}