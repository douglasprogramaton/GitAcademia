﻿// Desafio: programa no VS, com menu, para cadastrar usuários no sistema e gerar seus emails
//                automaticamente. Os usuários (nome completo e email) devem ser persistidos em arquivo.
//                Além disso, é preciso mantê-los em uma lista dinâmica em memória, que é populada sempre que 
//                o programa executa.

//                 Menu
//                 1 - Cadastrar usuário (só o nome completo)
//                         - gerar o email 
//                         - verificar se este email já foi gerado (na lista)
//                         - caso não exista, colocar na lista e persistir no arquivo: nome completo;email
//                 2 - Listar os usuários (nome completo e email)
//                         - mostrar ordenado (pode)
//                 3 - Sair 
//                 Opção: 


//StreamReader, StreamWriter, List, Usuário

using DesafioZamberlan2;

List<Usuario> listaUsuarios = new List<Usuario>();
/// <summary>
/// objeto da classe string que gera a opção de escolha ao usuário.
/// </summary>
string opcao;

//popular a lista com dados do arquivo
Util.carregarListas(listaUsuarios);
/// <summary>
/// do - while, criar o loop de seleção de de opção do usuário.
/// </summary>
do
{ //O exemplo a seguir usa o Clear método para limpar o console antes de executar um loop.
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um usuario");
    Console.WriteLine("2 - Listar usuários");
    Console.WriteLine("3 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();
    // Switch (opcao)- para criar o menu de seleção do usuário.
    switch (opcao)
    {
        case "1":
            //cadastrar um usuário; (Util= classe)- (cadastrarUsuario = metodo da classe usuário)
            Util.cadastrarUsuario("Cadastrando usuário", listaUsuarios);
            break;
        case "2":
            //listar usuários;
            Util.exibirLista("Exibindo a lista de usuários", listaUsuarios);
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");

