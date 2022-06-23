// See https://aka.ms/new-console-template for more information
//Crie uma classe Carro com os atributos: modelo, marca, cor e placa.
//Crie um método para definir os atributos, outro método para ligar o
//carro e outro método para desligar o carro.

Carro c= new Carro();

Console.WriteLine($"O {c.modelo} da marca {c.marca} na cor {c.cor} e de placa {c.placa} està {c.ligado} ou seja ligado ");
c.ligar();
public class Carro {
    public string modelo= "prisma";
    public string marca = "chevrolet";
    public string cor = "prata";
    public int placa = 1889;
    public bool ligado;
    
    public void ligar ()
    {
        Console.WriteLine("Carro ligado!");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("Carro desligado!");
        ligado = false;
    }









}


