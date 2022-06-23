using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACIONAMENTO
{
    internal class Carro
    {
       /// <summary>
       /// encapsulamento de varivaveis 
       /// </summary>
        private string placa;
        private string entradaGaragem;
        private string horarioEntrada;
        private int espera;
        private double cobrança;
        private string DataSaida;
        private string HoraSaida;
        private string text3;
        private string horaEntrada;
        /// <summary>
        /// Construtor Data e hora, com parametro de entrada.
        /// </summary>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        public Carro(string dataSaida, string horaSaida)
        {
            DataSaida = dataSaida;
            HoraSaida = horaSaida;
        }
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="tempoPermanecia"></param>
        /// <param name="valorCobrado"></param>
        public Carro(string placa, string dataEntrada, string horaEntrada,
       string dataSaida, string horaSaida, int tempoPermanecia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            this.DataSaida = dataSaida;
            this.HoraSaida = horaSaida;
            this.Espera = tempoPermanecia;
            this.Cobrança = valorCobrado;
        }
        /// <summary>
        /// Construtor (referencia textBox_palca,textbox_Data,textBox_Horario, espera, cobrança)
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="entradaGaragem"></param>
        /// <param name="horarioEntrada"></param>
        /// <param name="espera"></param>
        /// <param name="cobrança"></param>
        public Carro(string placa, string entradaGaragem, string horarioEntrada, int espera, double cobrança)
        {
            this.placa = placa;
            this.entradaGaragem = entradaGaragem;
            this.horarioEntrada = horarioEntrada;
            this.espera = espera;
            this.cobrança = cobrança;
        }
        /// <summary>
        /// Construtor de referencia a lista
        /// </summary>
        /// <param name="dataSaida"></param>
        /// <param name="horaSaida"></param>
        /// <param name="horaEntrada"></param>
        public Carro(string dataSaida, string horaSaida, string horaEntrada) : this(dataSaida, horaSaida)
        {
            this.horaEntrada = horaEntrada;
        }
        /// <summary>
        /// gerador de horario e data para calculos
        /// </summary>
        /// <param name="tipo"></param>
        public void gerarDataHora(string tipo)
        {
            DateTime dateTime = DateTime.Now;
            string[] vetorDados = dateTime.ToString().Split(' ');
            switch (tipo)
            {
                case "entrada":
                    this.entradaGaragem = vetorDados[0];
                    this.horarioEntrada = vetorDados[1];
                    break;
                case "saida":
                    this.DataSaida = vetorDados[0];
                    this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Método de cobrança
        /// </summary>
        /// <param name="valorHora"></param>
        public void realizarCobranca(double valorHora)
        {
            //horaEntrada = "8:14"; -> 8*60+14 = 494
            //horaSaida = "10:15";  -> 10*60+15 = 615
            //descobrindo o tempo em minutos da entrada
            string[] vetorDados = entradaGaragem.Split(':');
            // int hora = int.Parse(vetorDados[0]);
            int hora=0;
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;

            //descobrindo o tempo em minutos da saida
            vetorDados = horarioEntrada.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = hora * 60 + minutos;

            this.Espera = saida - entrada;
            double resultado = (double)this.Espera / 60;
            double qtdHorasNaGaragem = Math.Ceiling(resultado);

            this.Cobrança = (int)qtdHorasNaGaragem * valorHora;
            cobrança = 5;
        }
        /// <summary>
        /// Gett's e Sett's
        /// </summary>
        public string Placa { get => placa; set => placa = value; }
        public string EntradaGaragem { get => entradaGaragem; set => entradaGaragem = value; }

        public string HorarioEntrada { get => horarioEntrada; set => horarioEntrada = value; }
        public int Espera { get => espera; set => espera = value; }
        public double Cobrança { get => cobrança; set => cobrança = value; }
        public string DataSaida1 { get => DataSaida; set => DataSaida = value; }
        public string HoraSaida1 { get => HoraSaida; set => HoraSaida = value; }
        /// <summary>
        /// Método que aponta se ja existe carros cadastrado
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="carros"></param>
        /// <returns></returns>
        public static bool jaCadastrado(string placa,List<Carro>carros)
        {
            foreach(Carro carro in carros)
            {
                if(carro.Equals(carro.Placa))
                {
                    return true;
                }
                
            }
            return false;
          
        }
        public static int localizado(string placa, List<Carro> lista)
        {
            foreach (Carro carro in lista)
            {
                if (carro.Placa.Equals(placa))
                {
                    return lista.IndexOf(carro);
                }
            }
            return -27; 
        }
        /// <summary>
        /// Aponta se há vagas 
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="tamanhoGaragem"></param>
        /// <returns></returns>
        public static bool temLugar(List<Carro> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;
        }
    }
}



