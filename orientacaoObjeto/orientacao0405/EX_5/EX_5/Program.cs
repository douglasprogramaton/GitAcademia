// See https://aka.ms/new-console-template for more information


//Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra
//“Aprovado” se a média das duas notas for maior ou igual a 7,0. Caso a média seja inferior a 7,0,
//o programa deve ler a nota do exame e calcular a média final. Se esta média for maior ou igual a 5,0,
//o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.

float media;

Console.WriteLine("Digite as notas do aluno:");
float nota1=float.Parse(Console.ReadLine());
float nota2=float.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

if(media >= 7)
{
    Console.WriteLine($"{media}\n\n");
    Console.WriteLine("Aprovado com exito!");
}
else if (media>= 5)
{
    Console.WriteLine($"{media}\n\n");
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado");
}
