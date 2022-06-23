using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercico 3: 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio\n" +
                ", para trocar entre  si os valores de duas variáveis A e B");

            Console.WriteLine("Digite uma frase qualquer :");
            string variavel1 = Console.ReadLine();
            Console.WriteLine("Digite qualquer outra frase");
            string variavel2 = Console.ReadLine();
            Console.WriteLine("O conteudo da variavel 1 è : "+ variavel1);
            Console.WriteLine(" O conteudo da variavel 2 è: "+ variavel2);

            Console.WriteLine(" Processo de troca de valores entre duas variáveis ");

            string tmp = variavel1;
            variavel1 = variavel2;
            variavel2 = tmp;

            Console.WriteLine(" O conteúdo da variavel1 é: " + variavel1);
            Console.WriteLine(" O conteúdo da variavel2 é: " + variavel2);
        }
    }
}
