Console.WriteLine($"Informe quantos gols fez o Vasco: ");
int vasco = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe quantos gols fez o Santo Andre: ");
int santoAndre = int.Parse(Console.ReadLine());

if (vasco == santoAndre)
{
    Console.WriteLine($"Empatados");
}

else if (vasco > santoAndre)
{
Console.WriteLine($"Vasco ganhou a partida!");

}

else
{
    Console.WriteLine($"Santo Andre ganhou a partida!");
    
}
