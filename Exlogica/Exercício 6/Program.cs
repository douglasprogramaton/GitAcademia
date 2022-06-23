using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6 : 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, \n" +
                "isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem\n" +
                "de IPI(única) a ser acrescentada. ");

          
            int quantidadeA;
            int quantidadeB;
            string codigo_parafusoA = "";
            string codigo_parafusoB = "";
            float valor;
            float valorm;
            
            float porcentagem;// imposto sobre produto insdustrializado.
       
            Console.Write("Quantos parafusos (A) deseja obter:");
            quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor da unidade do parafuso (A):");
            valor = float.Parse(Console.ReadLine());
            valorm = quantidadeA * valor;

            var IPI = 0.15*valor;
            
            Random codigor = new Random();
            float random = codigor.Next(1000, 2500);
            codigo_parafusoA = codigo_parafusoA + "" + codigor.Next(1000, 2500);

            Console.Write($"O codigo do parafuso (A) é: {codigo_parafusoA}, o valor total é: {valorm:C} e  IPI é: {IPI}\n ");

            Console.Write("Quantos parafusos (B) deseja obter:");
            quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("\nQual o valor da unidade do parafuso(B):");
            valor = float.Parse(Console.ReadLine());
            valorm = quantidadeB * valor;
            
            Random codigorb = new Random();
            int randomb = codigor.Next(1000, 2500);
            codigo_parafusoB = codigo_parafusoB + "" + codigor.Next(1000, 2500);
            Console.WriteLine($"\nO codigo do parafuso (B) é:{ codigo_parafusoB}, o valor total é: {valorm:C} e o IPI é :{IPI}");}
        }
    }
}
