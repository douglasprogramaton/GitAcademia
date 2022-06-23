
//8.Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até q
//ue seja. após, informe se ele é par ou impar. 
//Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.


string numero;

int inteiro;


bool num = false;


char repetir;

do
{
    do
    {
        Console.WriteLine("Digite um número inteiro: ");
        numero = Console.ReadLine();
        num = int.TryParse(numero, out inteiro);

    } while (num == false);

    if (inteiro% 2 == 0)
    {
        Console.WriteLine("O número informado é Par.");
    }
    else
    {
        Console.WriteLine("O número informado é Ímpar.");
    }

    Console.WriteLine("Deseja repetir a análise do número? (s/n)");
    repetir = char.Parse(Console.ReadLine());
    repetir = char.ToUpper(repetir);


} while (repetir == 'S');

//verificação de dados:
Console.WriteLine("Mostra número convertido em inteiro: " +inteiro + " É inteiro? " + num);