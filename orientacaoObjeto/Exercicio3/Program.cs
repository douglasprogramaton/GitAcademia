//#3
//Os quatro pilares do paradigma de Orientação a Objetos são:

//A - Sequenciamento, Procedimentos, Bibliotecas e Herança.
//B - Herança, Polimorfismo, Classes e Objetos.
//C - Classes, Atributos, Métodos e Abstração.
//D - Abstração, Encapsulamento, Herança e Polimorfismo.
string alternativa;
do
{
    Console.WriteLine("selecione a alternativa correta\n\n\n Os quatro pilares do paradigma de Orientação a Objetos são:\n\n ");
    Console.WriteLine("1 - Sequenciamento, Procedimentos, Bibliotecas e Herança.");
    Console.WriteLine("2 - Herança, Polimorfismo, Classes e Objetos.");
    Console.WriteLine("3 - Classes, Atributos, Métodos e Abstração.");
    Console.WriteLine("4 - Abstração, Encapsulamento, Herança e Polimorfismo.");
    Console.WriteLine("5- Sair .");
    Console.Write("Alternativa: ");
    alternativa = Console.ReadLine();


    switch (alternativa)
    {
        case "1":
            Console.WriteLine("ERRO!");
            break;
        case "2":
            Console.WriteLine("ERROU!");
            break;
        case "3":
            Console.WriteLine("ERROU!");
            break;
        case "4":
            Console.WriteLine("PARABENS VOCE ACERTOU!");
            break;
        case "5":
            Console.WriteLine("SAIR");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
    Console.WriteLine("Digite qualquer coisa para continuar .");
    Console.ReadKey();
} while (alternativa != "5");
