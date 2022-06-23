//12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
//número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
//R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
//armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
//No final do processamento, exibir o salário total e o salário excedente do operário.


int codigo, qt_hora; 

double salario, qt_hora_extra, salario_total, vl_extra;

Console.WriteLine("Digite o código do operário e o numero de horas trabalhadas: ");
codigo = int.Parse(Console.ReadLine());
qt_hora = int.Parse(Console.ReadLine());

if (qt_hora <= 50)
{
    salario = qt_hora * 10;
    qt_hora_extra = 0;
    Console.WriteLine($"O salário do operário é :{salario:C}");
}
else
{
    //70 horas = 70-50 = 20
    qt_hora_extra = qt_hora - 50;
    salario = 50 * 10;
    vl_extra = qt_hora_extra * 20;
    salario_total = salario + vl_extra;
    Console.WriteLine($" O salário total é : {salario_total:C}");
    Console.WriteLine($" O salário excedente é { vl_extra:C}");
}