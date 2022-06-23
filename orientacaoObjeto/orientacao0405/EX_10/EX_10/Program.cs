//10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
//O programa deve mostrar os dados do atleta mais novo e mais alto.


int idade,idade2;
double altura,altura2;
string nome,nome2;


Console.WriteLine("Digite o nome :");
nome= Console.ReadLine();
Console.WriteLine("digite a idade: ");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("digite a altura : ");
altura = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome :");
nome2 = Console.ReadLine();
Console.WriteLine("digite a idade: ");
idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("digite a altura : ");
altura2 = double.Parse(Console.ReadLine());


if (altura > altura2)

    Console.WriteLine($"O Atleta mais alto é {nome} com{altura} de altura");
  

if (idade < idade2)

    Console.WriteLine($"Atleta mais novo é {nome} com a idade de {idade} anos ");


if (altura2 > altura)

    Console.WriteLine($"O Atleta mais alto é {nome2} com{altura2} de altura");

if (idade2 < idade)

    Console.WriteLine($"Atleta mais novo é {nome2} com a idade de {idade2} anos ");