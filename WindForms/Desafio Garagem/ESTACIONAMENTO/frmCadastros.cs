using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTACIONAMENTO
{

    public partial class frmCadastros : Form
    {
        int espera;
        double cobrança;

       
        List<Carro> listaEntrada = new List<Carro>();
        List<Carro> listaSaida = new List<Carro>();

        public frmCadastros()
        {
            InitializeComponent();
        }


        private void textBox_Guardados_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_HoraSaida.Text = "";
            textBox_Placa.Text = "";
            textBox_Horario.Text = "";
            textBox_Data.Text = "";
            listaEntrada.Clear();
            listaSaida.Clear();
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            if (textBox_Placa.Text.Equals("")||textBox_Horario.Text.Equals(""));

           

            if (Carro.jaCadastrado(textBox_Placa.Text, listaEntrada))
            {
                MessageBox.Show("Carro cadastrado");
            }
            else
            {
                Carro carro = new Carro(textBox_Placa.Text, textBox_Data.Text, textBox_Horario.Text, espera, cobrança);
                listaEntrada.Add(carro);
                
              

                textBox_Guardados.AppendText(textBox_Placa.Text.ToString().ToUpper() + ";" + textBox_Data.Text + ";" + textBox_Horario.Text);
                
                Gravador.gravarNoArquivoEntrada(listaEntrada);
               
              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = 5;
            if (textBox_Placa.Text.Equals("") || textBox_HoraSaida.Text.Equals(""))
            {
    
                Carro carros = new Carro(textBox_Placa.Text, textBox_Data.Text, textBox_Horario.Text, espera, cobrança);
                listaSaida.Add(carros);
                MessageBox.Show("carro na lista de saida");

                textBox_Saida.AppendText(textBox_Placa.Text.ToString().ToUpper() + ";" + textBox_HoraSaida.Text+";"+valor);
                Gravador.gravarNoArquivoSaida(listaSaida);
                carros.realizarCobranca(valor);
                textBox_HoraSaida.Text = valor.ToString();
            }


        }

        private void textBox_Saida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



