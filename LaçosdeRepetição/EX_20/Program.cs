


List<char> listSexo = new List<char>();
List<string> listOlhos = new List<string>();
List<string> listCabelo = new List<string>();
List<int> listIdade = new List<int>(); int idade;
int maior_Idade = 0, qtd_Mulheres = 0;

do
{
    Console.WriteLine("Sexo: ");
    listSexo.Add(char.Parse(Console.ReadLine()));

    Console.WriteLine("Cor dos olhos: ");
    listOlhos.Add(Console.ReadLine());

    Console.WriteLine("Cor do cabelo: ");
    listCabelo.Add(Console.ReadLine());

    Console.WriteLine("Idade: ");
    idade = int.Parse(Console.ReadLine());
    listIdade.Add(idade);
} while (idade != -1);

for (int i = 0; i < listIdade.Count; i++)
{
    if (listIdade[i] > maior_Idade)
    {
        maior_Idade = listIdade[i];
    }
}
Console.WriteLine($"Maior idade dos habitantes: {maior_Idade}");

for (int i = 0; i < listSexo.Count; i++)
{
    if (listSexo[i] == 'F' || listSexo[i] == 'f')
    {
        if (listIdade[i] >= 18 && listIdade[i] <= 35)
        {
            if (listOlhos[i] == "verdes" && listCabelo[i] == "louros")
            {
                qtd_Mulheres++;
            }
        }
    }
}
Console.WriteLine($"quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros: {qtd_Mulheres}");