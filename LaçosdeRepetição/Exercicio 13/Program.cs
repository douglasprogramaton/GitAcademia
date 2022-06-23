using System;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 13 : 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais,\n" +
                " mais uma comissão de 15% sobre o preço de custo de cada bicicleta vendida, dividida igualmente entre eles.\n" +
                " Escreva um algoritmo que leia o número de empregados da loja, o valor do salário mínimo, o preço de custo de cada bicicleta, o número de bicicletas\nn" +
                " vendidas, calcule e escreva: o salário total de cada empregado.");

            double salaraio_minimo, preco_custo, valor_total, salario_final, comissao;
            int empregados, n_bic_vendida;

            Console.Write("\nInforme o número de empregados :");
            empregados = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o valor do salario mínimo :");
            salaraio_minimo = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o número de biciquetas vendidas :");
            n_bic_vendida = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o custo de cada bicicleta :");
            preco_custo = double.Parse(Console.ReadLine());

            valor_total = (preco_custo +( preco_custo * 0.5)) * n_bic_vendida;

            comissao = (preco_custo * 0.15) * n_bic_vendida;

            salario_final = (2 * salaraio_minimo) + (comissao / empregados);

           

            Console.WriteLine($"\n Salario final de cada empregado é = {salario_final:C}, A comissao é = {comissao:c}." );

        }
    }
}
