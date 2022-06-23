//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. Caso positivo, o programa em VS deve ser repetido.

//Exemplo:
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.


//Deseja informar outro número (s/n)? S

//Digite um número inteiro positivo: 12
//Numero digitado: 20
//Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


//Deseja informar outro número (s/n)? N 

int num;
int repetir;

bool isValid = true;

while (true)
{
    if (isValid==true)
    {

        Console.WriteLine("Digite um valor : ");

        num = int.Parse(Console.ReadLine());


        if (num <= 0)
        {

            Console.WriteLine("Vamos refazer");


        }


        for (int k = 0; k < num; k--)
        {
            num--;
            if (num % 2 == 0)
            {
                Console.WriteLine("numero pare" + num);

            }
            else if (num <= 0)
            {

                Console.WriteLine("Acertou!");
                break;
            }
            

        }
        Console.WriteLine($"Deseja repetir? sim/não");
            isValid = Console.ReadLine().ToUpper() == "S" ? true : false;
    }else
    {
        isValid = false;
        Console.WriteLine("Ok!");
        Console.Clear();
        Console.ReadKey();

     }

    
}


 
    




















