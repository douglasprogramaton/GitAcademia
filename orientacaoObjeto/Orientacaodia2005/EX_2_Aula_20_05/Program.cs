// See https://aka.ms/new-console-template for more information

//•Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. Faça métodos para apresentar os dados.
Pessoa pessoa = new Pessoa();
pessoa.nome = "Ralf";
pessoa.idade = 30;
pessoa.altura = 1.90;
pessoa.cor = "parada";
pessoa.pessoas();
pessoa.acordou();
pessoa.HappyHour();
pessoa.voltou();
 class Pessoa
{
    public string nome;
    public int idade;
    public double altura;
    public string cor;

    public void pessoas()
    {
        Console.WriteLine($"Olá {nome} você tem {idade} anos, altura {altura} e se declara na cor {cor}." );
    }
    public void acordou()
    {
        Console.WriteLine("Acordou as 07:00, escovou os dentes e foi trabalhar.");
    }
    public void HappyHour()
    {
        Console.WriteLine("Após o trabalho foi para um HappyHour com os amigos do trabalho.");
    }
    public void voltou()
    {
        Console.WriteLine("Voltou as 00:30 para casa e foi descansar.");
    }

}
