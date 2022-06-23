using System;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            
           double preco_combustivel = 6.9;
            float consumo;
           double consumototal;
           Random odometro = new Random();
           double kml = odometro.Next(100,200);
            
            Console.Write(" Quantos km o carro ira andar do inicio do dia até o fim do dia  : "+kml+"km/l");
           
            Console.Write("\n\n Informe quanto litros voce deseja que o automovel vai consumir km/l :");
            consumo = float.Parse(Console.ReadLine());
            Console.WriteLine("Preço do combustivel :6.9");
           
            Console.Write("\n\n Lucro por Km rodado de um taxi : R$ 5,30 ");
            double lucroKm;
            
            consumototal =(kml / consumo);

            lucroKm = (consumototal * preco_combustivel);
            double lucrototal=lucroKm * 2.3;
            double percentual_lucro = lucrototal  / consumototal;


            Console.Write("\n\nO veiculo consome : "+consumototal +"km/l" );
            Console.Write($"\n\nO lucro por km/l : {lucrototal:C} ");
            Console.Write("\n\n O percentual do lucro do motorista de taxi é : " + percentual_lucro + "%");

        }
    }
}
