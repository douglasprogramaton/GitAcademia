using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7
{
    public class Inicio
    {

       
        public static void Add_vendedor()
        {


            Inicio inicio = new Inicio();
            Compras compras = new Compras();


            bool valido = true;
            Console.Write(".....................Digite o nome da loja que deseja fazer as compras: ");
            string nome_loja = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("....................Lista de vendedores...............");
            Console.ReadLine();
            compras.Vendedores();

            foreach (var add in Compras.Vendedors)
            {

                Console.WriteLine($" Id: {add.Id} - Nome: {add.Nome} - Código: {add.Codigo} - Salario: {add.Salario}");
            }

            do
            {
                try
                {
                    Console.Write("digite o Id do profissional:");
                    int id_Profissional = int.Parse(Console.ReadLine());

                    var proff = (from Vendedor in Compras.Vendas where Vendedor.Id == id_Profissional select Vendedor).SingleOrDefault();

                    Compras.Add_vendedor.Add(proff);

                    Compras compras1 = new Compras();
                    Vendedor vendedor = new Vendedor();
  
                    int total_vendas;
                    double salario_final;
                    double valor_comissao;
                    Console.Write("\nDigite o valor das compras: ");
                    total_vendas = int.Parse(Console.ReadLine());
                    if (total_vendas <= 400)
                    {
                        // valor total das compras multiplicado pela comissão que é de 15% .  
                        valor_comissao = (total_vendas * .15) / 100;

                    }

                    else
                    {
                        // valor de comissão 7% / por 100.  
                        valor_comissao = total_vendas * .07;


                    }
                   

                    salario_final = proff.Salario + valor_comissao;
                    Console.Clear();
                    Console.WriteLine($"O total de ganho em comissao do vendedor{proff.Id} é {valor_comissao:C}, e o salario final é {salario_final:C}");
                    Console.ReadLine();


                    Console.WriteLine("Deseja ter a ajuda de mais algum vendedor?\nS -SIM ou Qualquer tecla para NÃO... ");
                    valido = Console.ReadLine().ToUpper() == "S" ? true : false;
                }
                catch
                {
                    Console.WriteLine("DADOS INCORRETOS:");
                    valido = true;
                }

            } while (valido);
        }
    }
}













