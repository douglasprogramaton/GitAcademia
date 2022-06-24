using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemDS
{
    
    public partial class frmCadastro : Form
    {/// <summary>
    /// tbp variavel usada para passar o valor de textbox_placa para o construtor da classe Carro.
    /// </summary>
        public string tbp="";
        /// <summary>
        /// "valorHora" usado para auxiliar no calcula de horas pagas. 
        /// </summary>
        public double valorHora = 5;
        /// <summary>
        /// usado em "indexof" retorna o primeiro indice
        /// </summary>
        int placeCarro;
        /// <summary>
        /// usado para passar para o construr o valor do calculo em horas.
        /// </summary>
        public double valor;
        public double txt;
       public DateTime time = DateTime.Now;
        public frmCadastro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// evendo do botão cadastrar onde ira cadastrar dados do carro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_cadastrar_Click(object sender, EventArgs e)
        {

            bool nagaragem=false;
           

            // Responsavel por passar os valores de textbox_placa, valorCobrado, time para o contruto da classe Carro.
            Carros carro = new Carros(textBox_placa.Text,valorCobrado:valor,time );
            
            if (carro.listaCarrosEntrada.Count() >= 50)// limitie de carros
            {
                MessageBox.Show("Sem vagas", "Alerta!");
                
            }
            else if (textBox_placa.Text.Equals(""))
            {
                MessageBox.Show("Erro ou digitar placa", "Alerta!");
            }
            if (!nagaragem)
            {
                
                //apresenta ao usuario hora de entrada  e data
                dataGridView_entrada.Rows.Add(carro.Placa, carro.HorarioEntrada.ToString("d"), carro.HorarioSaida.ToString("t"));
                
                carro.listaCarrosEntrada.Add(carro);
                carro.listaCarrosSaida.Add(carro);
                int vagas=0;
                //contagem de carros na garagem.
                for (int i = 0; i < 50; i++)
                {
                    if (vagas <= 50)
                    {
                        MessageBox.Show($"{carro.listaCarrosEntrada.Count()} Carro na garagem, restam:{ 50-carro.listaCarrosEntrada.Count()}");
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"limite de gavas!");
                    }

                }
               
            }
            else
            {
                MessageBox.Show("Carro ja foi Cadastrado", "Alerta!");
                
            }
            //metodo gravar no arquivo entrada do veiculo
            carro.gravardorDarquivoEntrada();
           

        }
        
        private void button_saida_Click(object sender, EventArgs e)
        {
            tbp = textBox_placa.Text;
            textBox_dthora.Text = dtp_data.Value.Hour.ToString();
            Carros carro = new Carros(textBox_placa.Text,valorHora,time);

            DataGridViewRow place = dataGridView_entrada.CurrentRow;
            int chosenLocation = place.Index;
            //remove dado da primeira celula
            string placa = (string)dataGridView_entrada.Rows[chosenLocation].Cells[1].Value;
              //calcular valor pago em horas de permanencia.
            foreach (Carros c in carro.listaCarrosEntrada)
            {
                if (Placa.Equals(placa))
                {

                    placeCarro = c.listaCarrosEntrada.IndexOf(c);
                    c.listaCarrosSaida.Add(c);
                    c.HorarioSaida = DateTime.Now;
                    c.Permanencia = c.HorarioSaida.Subtract(c.HorarioEntrada);
                    c.ValorCobrado = Math.Ceiling((c.Permanencia.TotalMinutes /60)) * valorHora;
                    valor= c.ValorCobrado;
                    c.ValorCobrado = Convert.ToDouble(textBox_valorh.Text);
                    
                    break;
                }
               
            }
            //passa para "dataGridView_saida" a saida do carro para controle.
            dataGridView_saida.Rows.Add(carro.Placa, carro.HorarioEntrada.ToString("d"), carro.HorarioEntrada.ToString("t"),carro.ValorCobrado);
            foreach (Carros c in carro.listaCarrosEntrada)
            {

                if (c.Placa.Equals(placa))
                {
                    c.placeCarro = carro.listaCarrosEntrada.IndexOf(c);
                    c.listaCarrosEntrada.Remove(carro.listaCarrosEntrada[carro.placeCarro]);
                    break;
                }
                DataGridViewRow placel = dataGridView_saida.CurrentRow;
                int isvalid = placel.Index;
                
                carro.listaCarrosSaida.Add(carro);

               
            }
            //limpa dataGridView.
            dataGridView_entrada.Rows.RemoveAt(chosenLocation);
            carro.gravardorDarquivoSaida();
        }

        private void dataGridView_entrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_placa.Clear();
            textBox_valorh.Clear();
            textBox_dthora.Clear();
            
            
        }
    }
    
}
