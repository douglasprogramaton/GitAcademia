using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Exercicio : 4) Faça um programa em C# e no Visual Studio\n" +
                " que adiciona dados na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.\n" +
                "Note que o dia, o mês e o ano devem ser lidos em variáveis ​​diferentes.");

            /*  
             Console.Write("Digite um nome : ");
             nome = Console.ReadLine();



             DateTime dataEntrada = DateTime.Now;
             Console.WriteLine(dataEntrada);
             Console.WriteLine($"Data e horario :"+ dataEntrada);
            */
            int dia;
            int mes;
            int ano;
            Console.WriteLine("Informe o dia :");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o mes :");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano :");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("DD/MM/AAAA:" + dia + "/" + mes + "/" + ano);
            Console.WriteLine("AAAA/MM/DD:" + ano + "/" + mes + "/" + dia);
            Console.WriteLine("AA/MM/DDDD:" + (ano%100) + "/" + mes + "/" + dia);

        }

    }
}
