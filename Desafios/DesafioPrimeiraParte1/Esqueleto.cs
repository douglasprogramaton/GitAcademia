using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPrimeiraParte
{
    internal class Esqueleto
    {
        /// <summary>
        /// Método que ira apresentar a lista com horario e placas de carros.
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void lista(List<Veiculos> listaveiculos)
        {
            Console.WriteLine("lista veiculos");
            foreach (Veiculos v in listaveiculos)
            {
                Console.WriteLine(v.Placa + "-" + v.DateTime);
                
            }
        }
        /// <summary>
        /// "StreamReader" leitor de arquivo.
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void carregarLista(List<Veiculos> listaveiculos)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";");
                } while (!leitor.EndOfStream);
            }

            //"Wrong" errado.
            catch (Exception wrong)
            {
                Console.WriteLine($"Arquivo problemas ou inexistente +:  {wrong.Message}");
            }
        }
        /// <summary>
        /// Método com encapsulamento (static para declarar um membro estático que pertença ao próprio tipo).
        /// </summary>
        /// <param name="text"></param>
        private static void adicionarCarro(Veiculos text)
        {

            //"try" usado para fazer a tratativa de StreamWriter.
            try
            {

                StreamWriter writer = new StreamWriter("garagem.dat");

                writer.WriteLine(text.Placa + ";" + text.DateTime);
                //"Fluch()" Método para fazer a descarga. Ou seja Limpa todos os buffers para o gravador para o gravador atual,
                //e faz com que todos os dados armazenados em buffer sejam gravados no fluxo subjacente.
                writer.Flush();
                //Você deve chamar Close para garantir que todos os dados sejam gravados corretamente no fluxo subjacente
                writer.Close();
            }
            catch (Exception wrong)
            {
                Console.WriteLine($"Arquivo com problemas ou inexistente:  {wrong.Message} ");

            }


        }
        /// <summary>
        /// Método para fazer o cadastramento dos veliculos adicionando os mesmos em listas e em arquivo,
        /// esta sendo utilizado um loop para que o usuário adicione quantos veiculos ele quiser 
        /// </summary>
        /// <param name="listaveiculos"></param>
       public static void cadastrarEntradaDeVeiculo(List<Veiculos> listaveiculos)
        {
            string placa;
               
            string sair="";
            do
            {

                Console.WriteLine("Digite a placa: "); 
                placa = Console.ReadLine().ToUpper();
               
                DateTime datetime=DateTime.Now;
                Console.WriteLine(datetime);
                Veiculos veiculos = new Veiculos(placa, datetime);
                listaveiculos.Add(veiculos );
                Esqueleto.adicionarCarro(veiculos);

                Console.WriteLine("Quando desejar sair é só digitar: SAIR ");
                sair = Console.ReadLine();
            } while (sair!="SAIR");
        }
    }
}
