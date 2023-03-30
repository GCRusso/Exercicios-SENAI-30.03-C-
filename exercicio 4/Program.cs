Console.WriteLine($"insira sua senha");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"Acesso permitido");
    
}
else
{
    Console.WriteLine($"Acesso negado");
    
}