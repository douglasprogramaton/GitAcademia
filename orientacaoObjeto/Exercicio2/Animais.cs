using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    //#2
    //Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
    //O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

    //Regras que deverão ser seguidas para a implementação do programa:

    //Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
    //Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
    //É obrigatório criar uma classe para representar o Animal.
    //A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
    //A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).

    class Animais
    {


        private string Nome { get; set; }
        private string Tipo { get; set; }
        public List<Animais> AnimaisUsuario = new List<Animais>();

        public Animais(string nomes, string tipo)
        {
            this.Nome = nomes;
            this.Tipo = tipo;
            int qtdGato = 0, qtdCachorro = 0, qtdPeixe = 0;

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.WriteLine("Qual o nome do seu animal?");
                    nomes = Console.ReadLine();
                    Console.WriteLine("Qual o tipo do seu animal?(Cachorro/Gato/Peixe)");
                    tipo = Console.ReadLine();
                    if (tipo == "Gato" || tipo == "Cachorro" || tipo == "Peixe" || tipo == "gato" || tipo == "cachorro" || tipo == "peixe")
                    {

                        AnimaisUsuario.Add(new Animais(nomes, tipo));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }
                if (AnimaisUsuario[i].Tipo == "Gato" || AnimaisUsuario[i].Tipo == "gato")
                {
                    qtdGato++;
                }
                else if (AnimaisUsuario[i].Tipo == "Cachorro" || AnimaisUsuario[i].Tipo == "cachorro")
                {
                    qtdCachorro++;
                }
                else if (AnimaisUsuario[i].Tipo == "Peixe" || AnimaisUsuario[i].Tipo == "peixe")
                {
                    qtdPeixe++;
                }
            }
            Console.WriteLine($"Quantidade de gatos: {qtdGato}\nQuantidade de cachorros: {qtdCachorro}\nQuantidade de peixes: {qtdPeixe}");



        }
    }


}

    

}
