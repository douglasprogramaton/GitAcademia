using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
   public class Cenario
    {

        string descricao;

        DateTime data_criacao;

   
        float altura;

        public string Descricao { get => descricao; set => descricao = value; }

        public DateTime Data_criacao { get => data_criacao; set => data_criacao = value; }

        public float Altura { get => altura; set => altura = value; }
        public Cenario()
        {
        }

        /// <summary>
        /// método construtor do cenário com todos atributos
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="data_criacao"></param>
        /// <param name="altura"></param>
        public Cenario(string descricao, DateTime data_criacao, float altura)
        {
            this.descricao = descricao;
            this.data_criacao = data_criacao;
            this.altura = altura;
        }

        public void exibirDados()
        {
            Console.WriteLine("Exibindo dados...");
            Console.WriteLine(Descricao + "|" + Data_criacao.ToString("d") + "|" + Altura);
        }
        public TimeSpan calcularTempo()
        {
           
            return DateTime.Now.Subtract(Data_criacao);
           
        }

        public void imprimirCenario()
        {
            string arquivo = "teste.txt";
            string caminho = @"C:\temp\";
            string fullPath = System.IO.Path.Combine(caminho, arquivo);
            Console.BackgroundColor = ConsoleColor.Green;
          
        }

    }
}



