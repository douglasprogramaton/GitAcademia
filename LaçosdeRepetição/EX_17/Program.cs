//Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
//elevada a um expoente qualquer, ou seja, NM.



Random rnd = new Random();
int potencia = rnd.Next(1, 10);
int expoente = rnd.Next(1, 10);
double resultado;

resultado = Math.Pow(potencia, expoente);
Console.WriteLine($"Resultado de potencia {potencia} elevada a expoente {expoente} = {resultado} ");