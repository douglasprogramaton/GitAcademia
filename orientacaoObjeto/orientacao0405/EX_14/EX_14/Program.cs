

//14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
//link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
//do arquivo usando este link (em minutos).



int tamanho_arquivo, veloc_internet;


double tempo_gasto;

Console.WriteLine("Digite o tamanho do arquivo e a velocidade da internet: ");
tamanho_arquivo = int.Parse(Console.ReadLine());
veloc_internet = int.Parse(Console.ReadLine());

tempo_gasto = tamanho_arquivo / veloc_internet;
tempo_gasto = tempo_gasto / 60;

Console.WriteLine(Math.Ceiling(tempo_gasto) + " minutos");