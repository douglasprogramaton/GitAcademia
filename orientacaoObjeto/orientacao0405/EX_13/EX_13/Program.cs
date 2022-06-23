//13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
//seu peso ideal, utilizando as seguintes fórmulas:
//Para homens: (72.7 * h) - 58
//Para mulheres: (62.1 * h) - 44.7


double altura, peso_ideal;
string sexo;

Console.WriteLine("Digite a altura e o sexo ( feminino ou masculino ) de uma pessoa: ");
altura = double.Parse(Console.ReadLine());
sexo = Console.ReadLine();

if (sexo.Contains("feminino") == true)
{
    peso_ideal = (62.1 * altura) - 44.7;
    Console.WriteLine($"O peso ideal é {peso_ideal:F} Kg");
}
else if (sexo.Contains("masculino") == true)
{
    peso_ideal = (72.7 * altura) - 58;
    Console.WriteLine($"O peso ideal é  {peso_ideal:F} Kg");
}
else
{
    Console.WriteLine("Sexo inválido.");
}