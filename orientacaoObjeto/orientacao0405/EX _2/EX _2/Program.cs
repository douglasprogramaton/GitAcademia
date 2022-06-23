//Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.


Console.Write("digite um número:");
int num=int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é impar");
}
