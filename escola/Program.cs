Console.WriteLine($"Qual foi sua frequencia ? ");
float frequencia = float.Parse(Console.ReadLine());
Console.WriteLine($"Qual foi sua média? ");
float media = float.Parse(Console.ReadLine());


if (frequencia >= 75 && media>=7)
{
    Console.WriteLine($"Aprovado");
}

else if (frequencia >= 75 && media >= 3)
{
    Console.WriteLine($"Recuperacao");
}

else
{
    Console.WriteLine($"reprovado");  
}
