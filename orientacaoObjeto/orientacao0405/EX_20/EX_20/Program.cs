//20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
//plus: você pode gerar o número de forma randomica (função random c#).



string resp = "";
Random random = new Random();
int num = random.Next(1, 10);
resp = resp + ""+random.Next(1, 10);


Console.WriteLine("QUANTAS VEZES VOÇÊ QUER TENTAR :");
int tentar=int.Parse(Console.ReadLine());   
for (int i = 0; i <tentar; i++)
{
    Console.WriteLine("Jogo da sorte digite um número: ");
    int num2 = int.Parse(Console.ReadLine());
    if (num2  == num)
    {
        Console.WriteLine("Voçê acertou!");
    }else if(num2!=num)
    {
        Console.WriteLine("Voçê errou tente novamente!");
    }
    
} 