//6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
//ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
//Ao final, mostre a idade digitada.
int idade, idade_digitada;

Console.WriteLine("Digite uma idade : ");
idade_digitada = int.Parse(Console.ReadLine());
Console.WriteLine("Digite novamente : ");
idade = int.Parse(Console.ReadLine());
while (idade != idade_digitada)
{
    Console.WriteLine("Idade errada!\n\n Digite novamente :");
    idade_digitada = int.Parse(Console.ReadLine());
}
//int idade;
//do
//{
//    Console.WriteLine("Digite sua idade: ");
//    idade = int.Parse(Console.ReadLine());
//} while (idade < 0);
//Console.WriteLine($"A idade digitada foi {idade}");
