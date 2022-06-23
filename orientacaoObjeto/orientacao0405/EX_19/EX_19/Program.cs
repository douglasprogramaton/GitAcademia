


//18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.





int valor1, valor2, valor3;

Console.WriteLine("Digite 3 valores: ");
valor1=int.Parse(Console.ReadLine());
valor2=int.Parse(Console.ReadLine());
valor3=int.Parse(Console.ReadLine());



if (valor1 > valor2)
{
    Console.WriteLine(" valor1 é maior");
    if (valor1 > valor3)
        Console.WriteLine(" valor1 é maior");
    if (valor2 > valor1)
            Console.WriteLine(" valor2 é maior");
    if (valor2 > valor3)
                Console.WriteLine(" valor3 é maior");
    if (valor3 > valor1)
                    Console.WriteLine(" valor3 é maior");

}
else
{
    Console.WriteLine("valor3");
}