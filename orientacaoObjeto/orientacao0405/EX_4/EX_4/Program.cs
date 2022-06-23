// See https://aka.ms/new-console-template for more information


//Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o
//valor por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.

float horasAulas, sProfessor1, sProfessor2;

Console.WriteLine("Digite quantas horas aulas o professor1 tem: ");
horasAulas= float.Parse(Console.ReadLine());

sProfessor1 = (horasAulas / 24) * 25;


Console.WriteLine("Digite quantas horas aulas o professor2 tem: ");
horasAulas = float.Parse(Console.ReadLine());

sProfessor2 = (horasAulas/24) * 25;

if (sProfessor1 > sProfessor2)
{
    Console.WriteLine("professor1 tem o maior salário");
    Console.WriteLine(sProfessor1);

}else if(sProfessor2>sProfessor1)
{
    Console.WriteLine("professor2 tem o maior salário");
    Console.WriteLine(sProfessor2);
}


