// See https://aka.ms/new-console-template for more information



//Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
//e escrever na tela os que são superiores à média.
double valor1, valor2, valor3, valor4, medias1, medias2;
Console.WriteLine("Digite os valores das médias 1 e 2 :");
valor1 = double.Parse(Console.ReadLine());
valor2 = double.Parse(Console.ReadLine());
medias1 = (valor1 + valor2) / 2;

Console.WriteLine("Digite os valores das médias 3 e 4:");
valor3 = double.Parse(Console.ReadLine());
valor4 = double.Parse(Console.ReadLine());

medias2 = (valor3 + valor4) / 2;


if (medias1 > medias2)
{
    Console.WriteLine("Média1 maior que Media2!");
    Console.WriteLine(medias1);
}
else if (medias2 > medias1)
{
    Console.WriteLine("Média2 maior que Média1!");
    Console.WriteLine(medias2);
}


