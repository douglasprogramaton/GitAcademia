
/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/

int placar_casa, placar_visitante;

Console.WriteLine("Digite o placar para o time de casa logo em segida o placar do time de fora: ");
placar_casa= int.Parse(Console.ReadLine());
placar_visitante= int.Parse(Console.ReadLine());
int placar_jogo;

placar_jogo = placar_casa * 2;
if (placar_casa > 2)
{
    Console.WriteLine($"O time da casa ja se classificou palcar : {placar_casa} x {placar_visitante} ");
}
else
{
    Console.WriteLine("Os times voltaram a se enfrentar");
}


//if (placar_visitante !=2 )
//    {
//        Console.WriteLine($"o time vizitante ja se classificou palcar : {placar_visitante} x {placar_casa} ");
//    }
//else if (placar_visitante !=1 )
//{
//    Console.WriteLine("os times voltaram a se enfrentar");
//}