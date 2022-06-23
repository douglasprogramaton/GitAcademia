//6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério
string pessoa;
int peso; 
double altura ;


 
    Console.WriteLine("Digite o Nome da pessoa :");
    pessoa = Console.ReadLine();
    Console.WriteLine( "Digite o peso: " );
    peso= int.Parse( Console.ReadLine() );
    Console.WriteLine("Digite a autura: ");
    altura= double.Parse( Console.ReadLine() );



double imc =  (peso/(altura *altura ));


if (imc < 18)
    {
        Console.WriteLine("abaixo do peso");
    }
    else if (imc > 18 && (imc < 25))
    {
        Console.WriteLine("peso normal");
    }
    else if (imc > 25 && (imc < 30))
    {
        Console.WriteLine($"Sobrepeso");
    }
    else if (imc >30 && (imc < 35))
     {
            Console.WriteLine("obesidade");
     }
    else if (imc > 30)
     {
        Console.WriteLine("obesidade morbida ");
     }





