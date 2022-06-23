using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos.
//Além disso, aplicar a ideia de menu de opções.

//Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos
//veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória.
//Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

//MENU
//1 - Cadastrar veículo entrando na garagem
//2 - Exibir veículos cadastrados
//3 - Sair
//Opção: 

//Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, StreamReader, StreamWriter, DateTime
//Use como base de dados o arquivo 'garagem.dat'.

namespace DesafioPrimeiraParte
{
    internal class Veiculos
    {
        private string placa = "";
        DateTime dateTime;
        private string v;

        public Veiculos(string v)
        {
            this.v = v;
        }



        public Veiculos(string placa, DateTime dateTime)
        {
            this.Placa = placa;
            this.DateTime = dateTime;
        }

        /// <summary>
        /// Método para criado para trabalharmos com a variavel "Placa "get,set" para acessar e atualizar o valor de um private campo
        /// no caso a variavel do Método string placa
        /// </summary>
        public string Placa { get => placa; set => placa = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

     
    }
}



