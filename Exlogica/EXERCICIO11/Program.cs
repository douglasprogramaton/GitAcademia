using System;

namespace EXERCICIO11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11 escreveu um branco para ler o número de votos de um município\n" +
           ", o número, nulos e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de energia c#\n\n");
            
            
           int votos_Validos;
           int votos_Nulos;
           int  votos_Brancos;
           Console.Write($"Digite a quantidade de votos: ");
           int total = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Digite a quantidade de votos válidos : ");
            votos_Validos = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Digite a quantidade de votos nulos : ");
            votos_Nulos = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write($"Digite a quantidade de votos brancas : ");
            votos_Brancos = int.Parse(Console.ReadLine());
            Console.Clear();

            double percentual_votos_validos = (votos_Validos * 100) / total;
            double percentual_votos_nulos = (votos_Nulos * 100) / total;
            double percentual_votos_brancos = (votos_Brancos * 100) / total;

            Console.WriteLine("O percentual de votos validos é: "+percentual_votos_validos.ToString()+"%");
            Console.WriteLine("O percentual de votos nulos é: " + percentual_votos_nulos.ToString() + "%");
            Console.WriteLine("O percentual de votos validos é: " + percentual_votos_brancos.ToString() + "%");
        }
    }
}
