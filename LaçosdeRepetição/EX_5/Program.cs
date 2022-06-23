//5.Modifique o programa em VS anterior para aceitar votos nulos 
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos 
//e o número de pessoas que votaram.


string votar; //LULA, BOSONARO, BRANCO
int totalVotoslula = 0, totalVotosBosonaro = 0, totalVotosBranco = 0, totalVotosNulos=0;

do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato,NULO ou BRANCO, ou FIM para encerrar: ");
    votar = Console.ReadLine().ToUpper();

    switch (votar)
    {
        case "BOSONARO":
            totalVotosBosonaro++;
            break;
        case "LULA":
            totalVotoslula++;
            break;
        case "BRANCO":
            totalVotosBranco++;
            break;
        case "NULO":
        totalVotosNulos++;
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Candidato inexistente");
            break;
    }
    Console.ReadKey();
    if (totalVotoslula > totalVotosBosonaro)
    {
        Console.WriteLine($"Vencedor é Lula com :{totalVotoslula} votos");
    }
    else
    {
        Console.WriteLine($"Vencedor é Bosonaro com : {totalVotosBosonaro}");
    }
} while (votar != "FIM");

Console.WriteLine($"Total de votos para o Lula= {totalVotoslula}");
Console.WriteLine($"Total de votos para o Bosonaro=  {totalVotosBosonaro}");
Console.WriteLine($"Total de votos em Branco= {totalVotosBranco}");
Console.WriteLine($"Total de votos Nulos= {totalVotosNulos}");