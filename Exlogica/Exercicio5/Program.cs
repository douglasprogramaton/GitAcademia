using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5: 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel\n" +
                " (medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume\n" +
                " de combustível consumido para percorrê - la(medido em l).\n");
            
            Console.WriteLine("==========================================\n");
     
            float distancia;
            float consumo;
            float consumototal;
            
            Console.Write("Informe quantos km o carro ira automovel ira andar :");

            distancia = float.Parse(Console.ReadLine());

            Console.Write("\nInforme quanto litros voce deseja que o automovel vai consumir km/l :");
            consumo = float.Parse(Console.ReadLine());

            consumototal = distancia / consumo;

            Console.WriteLine($"\nO veiculo consome {consumototal} km/l");

        }
    }
}
