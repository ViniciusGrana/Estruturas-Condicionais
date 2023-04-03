Console.WriteLine($"informe quantos gols o time 1 fez ");
float time1 = float.Parse(Console.ReadLine());
Console.WriteLine($"informe quantos gols o time 2 fez");
float time2 = float.Parse(Console.ReadLine());

if (time1 > time2)
{
    Console.WriteLine($"o time 1 foi o vencedor");
}

else if (time1 == time2)
{
    Console.WriteLine($" o resultado foi o empate");
    
}

else
{
    Console.WriteLine($"o time 2 foi o vencedor");
}