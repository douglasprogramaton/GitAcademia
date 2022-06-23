//#4
//Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
//uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
//um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
//(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
//terceiro que constrói um asteroide com posição x e posição y. 
//O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
//asteróides da lista.
using Exercicio4;

List<Astreris> Aster = new List<Astreris>();
int n, x = 0, y = 0;

Console.WriteLine("Quantos objetos você deseja cadastrar?");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Clear();
    Console.WriteLine("Digite o ponto x: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ponto y: ");
    y = int.Parse(Console.ReadLine());

    Aster.Add(new Astreris(x, y));
}
foreach (Astreris s in Aster)
{
    Console.WriteLine($"lista de asterides\n{s} ");
}
