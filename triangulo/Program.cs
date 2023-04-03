Console.WriteLine($"informe a medida do primeiro angulo do triangulo ");
float angulo1 = float.Parse(Console.ReadLine());
Console.WriteLine($"informe a medida do segundo angulo do triangulo ");
float angulo2 = float.Parse(Console.ReadLine());
Console.WriteLine($"informe a medida do terceiro angulo do triangulo ");
float angulo3 = float.Parse(Console.ReadLine());

if (angulo1==angulo2 && angulo2==angulo3)
{
    Console.WriteLine($"Triângulo    Equilátero:    possui    os    3    lados    iguais.");
}

else if (angulo1 == angulo2 || angulo2==angulo3 || angulo1==angulo3)
{
    Console.WriteLine($"Triângulo    Isóscele:    possui    2    lados    iguais.");
}

else
{
Console.WriteLine($"Triângulo    Escaleno:    possui    3    lados    diferentes.");

}