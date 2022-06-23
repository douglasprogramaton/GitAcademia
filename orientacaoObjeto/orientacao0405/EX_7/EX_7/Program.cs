// See https://aka.ms/new-console-template for more information


//7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
//exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.


string [] palavra_chave = new string[2] {"Olá", "Mundo"};
Console.WriteLine("Qual a frase que dizem que se não parecerem em C# o programa não da certo?");




string palavra;

Console.WriteLine("quantas vezes deseja tentar  acertar a palavra ?");
int tentativas = int.Parse(Console.ReadLine());
for (int i = 0; i < palavra_chave.Length; i++)
{
    Console.Write("Digite a frase aqui: ");
    palavra= Console.ReadLine();
    palavra = palavra_chave[i];
    if (tentativas==palavra_chave.Length)
    {
        Console.WriteLine("A palavra encontra-se na frase");
    } else if (tentativas != palavra_chave.Length)
    {
        Console.WriteLine("A palavra não se encontra na frase");
    }


}




