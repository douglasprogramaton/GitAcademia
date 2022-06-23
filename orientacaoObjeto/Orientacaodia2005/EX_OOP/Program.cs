// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Lampada l = new Lampada();
l.potencia = 9;
l.ligar();
Console.WriteLine("O atributo é do tipo"+l.ligado+"potência"+l.potencia );
l.desligar();
Console.WriteLine("O atributo é do tipo" + l.ligado + "potência" + l.potencia);
double n;
n = l.retornaPotencia();
Console.WriteLine($"A potância da lampada cadastrada é = {n}");
Console.WriteLine($"Vetorno da função está ligado = {l.estaLigado()}");
l.ligar();
l.desligar();

if (l.estaLigado())
{
    Console.WriteLine("A lampada esta ligada!");
}
else
{
    Console.WriteLine("A lampada esta desligada!");
}

public class Lampada
{
    //atributos
   public bool ligado;// AQUI SO PODE SER DEFINIDO SE É TRUE OU FALSE;
    public double potencia;

    public void ligar()
    {
        Console.WriteLine("A lampada desta sendo ligada !");
        ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("A lampada esta sendo desligada!");
        ligado = false;
    }
    public double retornaPotencia()//metodo  letra minuscula (classe letra maiuscula).
    {
        return potencia;
    }
    public bool estaLigado()
    {
        return ligado;
    }
   
}

