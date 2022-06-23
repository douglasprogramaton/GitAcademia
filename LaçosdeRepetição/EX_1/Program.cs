

//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

//Exemplo:
//Digite um número inteiro positivo: -8
//Valor incorreto!
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.



int numero; 


Console.WriteLine("Digite um número inteiro e positivo: ");
numero = int.Parse(Console.ReadLine());

while (numero <= 0)
{
    Console.WriteLine("Número inválido, digite um número inteiro e positivo: ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("Os números pares entre 1 e " + numero + " é: ");
for (int i = 2; i < numero; i = i + 2)

{
    Console.WriteLine(i);
}