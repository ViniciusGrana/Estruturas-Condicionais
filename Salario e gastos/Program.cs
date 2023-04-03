Console.Write($"Informe seu salario ");
int salario = int.Parse(Console.ReadLine());
Console.Write($"Informe os gastos ");
int gastos = int.Parse(Console.ReadLine());

if (salario > gastos)
{
Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
Console.WriteLine($"Orçamento estourado");
}
