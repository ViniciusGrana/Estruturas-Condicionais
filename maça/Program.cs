Console.WriteLine($"Quantas maças você vai comprar? ");
float macas = float.Parse(Console.ReadLine());

if ( macas >= 12 )
{
    float pagar = macas * 0.25f;
    Console.WriteLine($"total sera: {pagar}R$");
}

else
{
    float pagar = macas * 0.30f;
    Console.WriteLine($"total sera: {pagar}R$");
    
}