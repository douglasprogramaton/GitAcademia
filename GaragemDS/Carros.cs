using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragemDS
{
    internal class Carros
    {
        public List<Carros> listaCarrosEntrada = new List<Carros>();
       
        public List<Carros> listaCarrosSaida = new List<Carros>();
        /// <summary>
        /// encapsulamento dos dados (placa, horarioEntrada, HorarioSaida, Permanencia, ValorCobrado)
        /// </summary>
        private string placa;
        private DateTime horarioEntrada;
        private DateTime horarioSaida;
        private TimeSpan permanencia;
        private double valorCobrado;
        public int placeCarro;
        /// <summary>
        /// cosntrutor que recebe valores e armazena nas variaveis 
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="valorCobrado"></param>
        /// <param name="horarioSaida"></param>
        public Carros(string placa, double valorCobrado,DateTime horarioSaida )
        {
            this.placa = placa;

            this.horarioSaida = horarioSaida;
            this.permanencia = permanencia;
            this.valorCobrado = valorCobrado;
            horarioEntrada = DateTime.Now;

        }
        /// <summary>
        /// metodos "get's e set's" para pegar e ler valores, das variaveis encapsuladas
        /// </summary>
        public string Placa { get => placa; set => placa = value; }
        public DateTime HorarioEntrada { get => horarioEntrada; set => horarioEntrada = value; }
        public DateTime HorarioSaida { get => horarioSaida; set => horarioSaida = value; }
        public TimeSpan Permanencia { get => permanencia; set => permanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
        /// <summary>
        /// responsavel por avisar que o carro esta na garagem.
        /// </summary>
        public void Nagaragem()
        {
            frmCadastro frm = new frmCadastro();

            bool jaEstacionado = false;

            foreach (Carros c in listaCarrosEntrada)
            {
                if (Placa == frm.tbp)
                {
                    MessageBox.Show("Placa já registrada, o carro já está no pátio");
                    jaEstacionado = true;
                    break;
                }
            }
        }
        /// <summary>
        /// grava no arquivo entrada
        /// </summary>
        public void gravardorDarquivoEntrada()
        {
            try
            {       // strig que gera o nome do arquivo
                string fileName = "writefileentry.dat";
                // escreve no arquivo 
                StreamWriter writer = new StreamWriter(fileName,true);
                foreach (Carros c in listaCarrosEntrada)
                {
                    writer.WriteLine($"{horarioEntrada.ToString("dd/MM/yyyy")};{placa};{HorarioSaida.ToString("HH:mm:ss")}");
                    writer.Flush();
                }
                writer.Close();
            }
            catch(IOException ex)
            {
                
                MessageBox.Show("Erro!");
            }
           
        }
        /// <summary>
        /// grava arquivo saida 
        /// </summary>
        public void gravardorDarquivoSaida()
        {
            frmCadastro frm = new frmCadastro();
          
            try
            {   // strig que gera o nome do arquivo
                string fileNamew = "recordfileoutput.dat";
                // escreve no arquivo 
                StreamWriter writerr = new StreamWriter(fileNamew, true);
                foreach (Carros c in listaCarrosEntrada)
                {
                    writerr.WriteLine($"{HorarioEntrada.ToString("dd/MM/yyyy")};{placa};{HorarioSaida.ToString("HH:mm:ss")};{frm.valorHora}");
                    writerr.Flush();
                }
                writerr.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Erro ao gravar!");
            }

        }

    }
}

