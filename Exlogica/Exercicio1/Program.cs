using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.


            Console.WriteLine("Exercicio 1");

            float num1;
            float num2;
            float media;
            Console.Write("Digite um numero quelaquer:");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Digite um segundo numero quelaquer:");
            num2 = float.Parse(Console.ReadLine());

            media = (num1 / num2) / 2;

            Console.WriteLine("A media aritimetica dos valores e de:" + media);
        }
    }
}
