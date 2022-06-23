// See https://aka.ms/new-console-template for more information
// 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero. 
float baase, altura, area;

Console.Write("Digite a base do Triângulo :");
baase= float.Parse(Console.ReadLine());
Console.Write("Digite a altura do Triângulo :");
altura = float.Parse(Console.ReadLine());

area = (baase * altura) / 2;
if (baase <=0)
{
    Console.WriteLine("Valor de base igual ou menor que zero!");
    
}else if (altura <= 0)
{
    Console.WriteLine("Valor de alturaigual ou menor que zero!");
}
Console.WriteLine("Area do Triângulo = " + area);

