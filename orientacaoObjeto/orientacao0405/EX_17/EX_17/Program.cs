//17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
//formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
//os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

int lado_a , lado_b, lado_c;

Console.WriteLine("Escreva um valor para o Lado A o Triângulo:  ");
lado_a=int.Parse(Console.ReadLine());

Console.WriteLine("Escreva um valor para  o  Lado B do Triângulo: ");
lado_b=int.Parse(Console.ReadLine());


Console.WriteLine("Escreva um valor para  o  Lado c do Triângulo: ");
lado_c = int.Parse(Console.ReadLine());


if ((lado_a + lado_b > lado_c && lado_a + lado_c > lado_b && lado_b + lado_c > lado_a))
{

    Console.WriteLine("os valores não são lados de um triângulo");
    if (lado_a == lado_b && lado_a == lado_c)
        Console.WriteLine("Equilatero");
    else

        if (lado_a == lado_b || lado_a == lado_c || lado_b == lado_c)

        Console.WriteLine("Isoceles");
    else
        Console.WriteLine("Escaleno");
}
else
{
    Console.WriteLine("os valores são lados de um triangulo");
}