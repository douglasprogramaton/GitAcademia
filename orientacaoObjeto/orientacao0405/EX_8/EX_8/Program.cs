// See https://aka.ms/new-console-template for more information
string nome;
double salario,salario_final, total_e_vendas;
Console.WriteLine( "Digite o Nome do Vendedor : ");
 nome= Console.ReadLine();

Random cod=new Random();
int codi = cod.Next(5000, 10000);
codi = cod.Next();

Console.WriteLine("Digite o salario: ");
salario=double.Parse(Console.ReadLine());

Console.WriteLine("Informe quanto o Vendedor fez em R$ de vendas: ");
total_e_vendas=double.Parse(Console.ReadLine());



if (total_e_vendas > 500 && (total_e_vendas < 1000))
{
    salario_final = (salario + (total_e_vendas * 0.05));
    Console.WriteLine($"O nome do vendedor {nome} e o código :{codi} o salario final é :{salario_final:C} ");

}
else if (total_e_vendas > 1000 && (total_e_vendas < 5000))
{
    salario_final = (salario + (total_e_vendas * 0.07));
    Console.WriteLine($"O nome do vendedor {nome} e o código :{codi} o salario final é :{salario_final:C} ");
}
else if (total_e_vendas >= 5000)
{
    salario_final = (salario + (total_e_vendas * 0.1));
    Console.WriteLine($"O nome do vendedor {nome} e o código :{codi} o salario final é :{salario_final:C} ");
}

