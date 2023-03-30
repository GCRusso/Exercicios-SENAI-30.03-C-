Console.WriteLine($"Informe seu salario: ");
int salario = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe seu gasto: ");
int gasto = int.Parse(Console.ReadLine());

if (salario >= gasto)
{
Console.WriteLine($"Voce esta dentro do orcamento! ;)" );
}

else
{
    Console.WriteLine($"voce estourou o orcamento! :(" );
    
}

