using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1;
            float num2;
            float num3;
            float num4;
            float media;
            Console.WriteLine(" Informe o primeiro numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro numero:");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quarto numero:");
            num4 = float.Parse(Console.ReadLine());
            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("A media dos 4 valores é :" + media);
        }
    }
}
