//12.Apresentar o total da soma dos cem primeiros números inteiros.


int soma = 0;

for (int i = 0; i < 101; i++)
{

    Console.WriteLine("Digite um numero: ");
    float num = float.Parse(Console.ReadLine());
    soma += i;

}

Console.WriteLine("A soma dos 100 primeiros números inteiros é " + soma);