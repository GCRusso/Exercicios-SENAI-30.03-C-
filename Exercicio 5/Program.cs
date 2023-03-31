Console.WriteLine($"Quantas maçãs voce deseja comprar?: ");
int macas = int.Parse(Console.ReadLine());

float acima = 0.25f;
float abaixo = 0.30f;

if (macas >= 12)
{
    float total = (acima * macas);
    Console.WriteLine($"o valor da sua compra e de: {total}");


}

else if (macas < 12)
{

    float total = (abaixo * macas);
    Console.WriteLine($"o valor da sua compra e de: {total}");

}








// 5)As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 
// se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
// calcule e escreva o valor    total    da compra.

// menos que 12 macas 30,00 cada 

