Console.WriteLine($"Informe a medida lado A do triangulo: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida lado B do triangulo: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a medida lado C do triangulo: ");
int C = int.Parse(Console.ReadLine());

if (A == B && B == C)
{
    Console.WriteLine($"Seu triangulo e um Equilatero");
}

else if (A != B && B != C && A != C)
{
    Console.WriteLine($"Seu triangulo e um Escaleno");
    
}

else {
    Console.WriteLine($"Seu triangulo e um Isoscele");
 }
