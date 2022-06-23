//9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.

int medicao1,medicao2,medicao3, medicao_media;
string nome_usuario;
Console.WriteLine("Informe o nome do usuario :");
nome_usuario=Console.ReadLine();


Console.WriteLine("Primeira Medição da glicemia em jejum: ");
medicao1= int.Parse(Console.ReadLine());
Console.WriteLine("Segunda Medição da glicemia em jejum: ");
medicao2 = int.Parse(Console.ReadLine());
Console.WriteLine("Terceira Medição da glicemia em jejum: "); ;
medicao3 = int.Parse(Console.ReadLine());

    medicao_media=(medicao1+medicao2 +medicao3)/3;

if (medicao_media < 80)
{

    Console.WriteLine("preciso diminuir 2 unidades de insulina");
}
else if (medicao_media > 150)
{
    Console.WriteLine(" adicionar 2 unidades de insulina.");
}


if (medicao1 < 65)
    {
        Console.WriteLine("corre risco de hipoglicemia (fica esperto........)");
    }
    else if (medicao1 > 250)
    {
        Console.WriteLine("corre risco de hiperglicemia (para de comer doce..........)");
    }
    if (medicao2 < 65)
    {
        Console.WriteLine("corre risco de hipoglicemia (fica esperto........)");
    }
    else if (medicao2 > 250)
    {
        Console.WriteLine("corre risco de hiperglicemia (para de comer doce..........)");
    }

    if (medicao3 < 65)
    {
        Console.WriteLine("corre risco de hipoglicemia (fica esperto........)");
    }
    else if (medicao3 > 250)
    {
        Console.WriteLine("corre risco de hiperglicemia (para de comer doce..........)");
    }

    

