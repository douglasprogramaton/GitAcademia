using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 8: 8)Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. \n" +
                "A fórmula da conversão é F = (9 * C + 160) / 5.");

            float f, C;
            Console.WriteLine("informe a temperatura:");
            C = float.Parse(Console.ReadLine());
            f = (9 * C + 160) / 5;
            Console.WriteLine("A temperatura convertida é "+f);

        }
    }
}
 