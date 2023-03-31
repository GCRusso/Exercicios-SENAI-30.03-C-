Console.WriteLine($"Qual a frequencia de presenca do aluno?: ");
int frequencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual a nota do aluno?: ");
int media = int.Parse(Console.ReadLine());


if (frequencia >= 75 && media >= 7)
{
Console.WriteLine($"APROVADO!");

}

else if (frequencia >= 75 && media >= 3 && media < 7 )
{
Console.WriteLine($"O Aluno tem direito a uma ultima avaliacao! ");

}

else
{
Console.WriteLine($"REPROVADO!");

}