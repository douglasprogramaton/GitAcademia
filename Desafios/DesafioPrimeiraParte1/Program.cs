﻿//Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos.
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


//Using para ter acesso a outras classes/
using DesafioPrimeiraParte;
/// <summary>
/// Instanciando "MENU" para que a classe principal possa acessar todo o programa 
/// e rodar o projeto.
/// </summary>
Menu menu = new Menu();




