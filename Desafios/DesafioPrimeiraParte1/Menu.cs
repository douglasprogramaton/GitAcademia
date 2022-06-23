using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPrimeiraParte
{
    internal class Menu
    {

        /// <summary>
        /// Lista que ira armazenar os carros.
        /// </summary>
        List<Veiculos> listaveiculos = new List<Veiculos>();
        public Menu()
        {
            Veiculos v = new Veiculos("");
            string opcao;

            //popular a lista com dados do arquivo

            Esqueleto.carregarLista(listaveiculos);

            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastrar veiculo no sistema Garagem ");
                Console.WriteLine("2 - Veiculos já cadastrados no sistema");
                Console.WriteLine("3 - Sair");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar um Veiculo;
                        Esqueleto.cadastrarEntradaDeVeiculo(listaveiculos);
                        break;
                    case "2":
                        //listar lista de veiculos;
                        Esqueleto.lista(listaveiculos);
                        Esqueleto.carregarLista(listaveiculos);
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por usar o sistema... \nTenha um ótimo dia :) ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Write("Pressione algo para continuar!");
                Console.ReadKey();
            } while (opcao != "3");

        }
    }
}
