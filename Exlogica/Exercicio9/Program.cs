using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9) Uma loja vende seus produtos no sistema de entrada mais duas ofertas, sendo a entrada maior\n" +
                "do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.\n" +
                "Por exemplo, se o valor da entrada é igual a R$ 270,0, e as duas prestações são iguais a R$ 27,0;\n" +
                "se o valor da entrega,2 por R$ 30,75 a entrada é de R$ 1,75 e as duas 102 são iguais a R$ 100.\n" +
                "Escreva um programa em C# e no Visual Studio que aceita o valor da entrega e entrega o valor\n" +
                "da entrada e das duas regras, de acordo com as acima.\n" +
                "Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção eo\n" +
                "conseqüente pagamento dos boletos das duas prestações.\n\n");

          

            Console.Write("informe o valor a ser parcelado: ");
           double valor = float.Parse(Console.ReadLine());

            Console.Write("Informe o numero de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            int parcela = ((int)(valor / parcelas));
            double ent = (parcela + valor);
            double entrada = ent % parcela;
            Console.WriteLine("O valor : "+valor+ "Pode ser pago com entrada de : "+entrada+" e parcelas de : "+parcela);



        }
    }
}
