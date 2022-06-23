using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACIONAMENTO
{
    internal class Gravador
    {
              /// <summary>
              /// lista de carros que passa os dados tambem para o arquivo entrada.
              /// </summary>
              /// <param name="lista"></param>
            public static void gravarNoArquivoEntrada(List<Carro> lista)
            {
                StreamWriter escritor = new StreamWriter("Entrada.dat");

                foreach (Carro i in lista)
                {
                    escritor.WriteLine(i.Placa + ";" + i.EntradaGaragem + ";" + i.HorarioEntrada);
                    escritor.Flush();
                }
                escritor.Close();
            }

            /// <summary>
            /// método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
            /// </summary>
            /// <param name="lista">lsita de veículos</param>
            public static void gravarNoArquivoSaida(List<Carro> lista)
            {
                StreamWriter escritor = new StreamWriter("Saida.dat");

                foreach (Carro i in lista)
                {
                    escritor.WriteLine(i.Placa + ";" + i.EntradaGaragem + ";" + i.HorarioEntrada + ";" + i.DataSaida1 + ";" + i.HoraSaida1 + ";" + i.Espera + ";" + i.Cobrança);
                    escritor.Flush();
                }
                escritor.Close();
            }

            /// <summary>
            /// método que popula a lista de veículos de estão na garagem a partir do arquivo base
            /// </summary>
            /// <param name="lista">lista de veículos</param>
            public static void lerArquivoEntrada(List<Carro> lista)
            {
                StreamReader leitor = new StreamReader("Entrada.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(";");
                    lista.Add(new Carro(vetorDados[0], vetorDados[1], vetorDados[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }

            /// <summary>
            /// método que popula a lista de veículos de passaram pela garagem a partir do arquivo base
            /// </summary>
            /// <param name="lista">lista veículos</param>
            public static void lerArquivoSaida(List<Carro> lista)
            {
                StreamReader leitor = new StreamReader("Saida.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(";");
                    lista.Add(new Carro(vetorDados[0], vetorDados[1], vetorDados[2], vetorDados[3],
                        vetorDados[4], int.Parse(vetorDados[5]), double.Parse(vetorDados[6])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
        
    }
}

