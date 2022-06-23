
//13.Elaborar um programa que apresente o somatório dos valores pares existentes 
//entre 1 e 500.


int soma = 0;

for (int i = 0; i < 500; i++)
{

    if (i % 2 == 0)
    {
        soma += i;
    }
}
Console.WriteLine($"A soma dos valors pares de 1 até 500 é  : {soma} ");