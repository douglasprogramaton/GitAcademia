//11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida. 
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.


int hora,minuto;



string hora_digitada;


string[] time; //10:16


Console.WriteLine("Digite uma hora no formato HH:MM: ");
hora_digitada = Console.ReadLine();

time = hora_digitada.Split(':'); // posição 0 e 1
hora = int.Parse(time[0]);
minuto = int.Parse(time[1]);

Console.WriteLine("Hora splitada: " + time[0] + ":" + time[1]);

if (hora >= 0 && hora <= 23)
{
    if (minuto >= 1 && minuto <= 59)
    {
        Console.WriteLine("Hora válida.");
    }
    else
    {
        Console.WriteLine("Minuto inválido.");
    }
}
else
{
    Console.WriteLine("Hora inválida.");
}