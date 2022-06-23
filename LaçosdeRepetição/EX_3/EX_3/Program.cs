//3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
//Se o usuário digitar 0 o programa em VS deve parar. 
//Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.  

bool v;
while (true)
{
    Console.WriteLine("Digite um valor : ");
    int valor = int.Parse(Console.ReadLine());
    if (valor % 2 == 0)
    {
        Console.WriteLine("O valor digitado é par");
        Console.ReadLine();
        Console.Clear();
        if ()
    }
    else
    {
        Console.WriteLine("O valor digitado é impar");
        Console.ReadLine();
        Console.Clear();
    }
    if (valor == 0)
    {
        
        Console.WriteLine("fim de programa");
        Console.ReadKey();
        break;
        
    }
 
}
 