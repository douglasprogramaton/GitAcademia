using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 10 :10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo \n" +
             "para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que\n" +
             "realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as\n" +
             "notas de menor valor fossem distribuídas em número mínimo possível.\n" +
             "Por exemplo, se a quantia solicitada fosse R$ 87, 00 o programa deveria indicar uma nota de R$ 50, 00,\n" +
             "três notas de R$ 10, 00, uma nota de R$ 5, 00 e duas notas de R$ 1, 00.\n" +
             "Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas\n" +
             "de acordo com o critério da “distribuição ótima”.");

            Console.WriteLine("Caixa Eletronico\n\n");
           
 
            Console.Write("Digite o valor do saque: ");
            int valor = Convert.ToInt16(Console.ReadLine()); //recebendo o valor digitado pelo usuário.
            int nota100 = valor / 200; //contagem das notas de 100R$
            int restov = valor - (nota100 * 100); //valor menos as notas de 100.
            int nota50 = restov / 50;//contagem das notas de 50R$
            restov = restov - (nota50 * 50);
            int nota20 = restov / 20;//contagem das notas de 20R$
            restov = restov - (nota20 * 20);
            int nota10 = restov / 10;//contagem das notas de 10R$
            restov = restov - (nota10 * 10);
            int nota2 = restov / 5;//contagem das notas de 5R$
            restov = restov - (nota2 * 5);
            int nota1 = restov / 2;//contagem das notas de 1R$
            restov = restov - (nota1 * 2);
            Console.WriteLine();
            Console.WriteLine("Quantidade de notas:");
            Console.WriteLine();
            Console.WriteLine("Notas de 100:  " + nota100);
            Console.WriteLine();
            Console.WriteLine("Notas de 50:  " + nota50);
            Console.WriteLine();
            Console.WriteLine("Notas de 20:  " + nota20);
            Console.WriteLine();
            Console.WriteLine("Notas de 10:  " + nota10);
            Console.WriteLine();
            Console.WriteLine("Notas de 2:  " + nota2);
            Console.WriteLine();
            
            Console.ReadKey();
        }





    }
    }

