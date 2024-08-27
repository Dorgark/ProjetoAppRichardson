BancoDeDados banco = new BancoDeDados();
DevConsole devConsole = new DevConsole();
Usuario usuario = new Usuario();
Console.WriteLine("Seja bem vindo ao CATMANIA");
Console.WriteLine("O que você deseja fazer ?");
Console.WriteLine("1 - Criar seu Perfil");
Console.WriteLine("2 - Fazer Login");
Console.WriteLine("3 - Sair");
Console.WriteLine("Digite abaxio a opção que deseja");

ConsoleKeyInfo opcao = new ConsoleKeyInfo();

opcao = Console.ReadKey();
switch(opcao.Key)
    {
        case ConsoleKey.D1:
            usuario.CriarPerfil(banco);
        break;

        case ConsoleKey.D2:
            Console.WriteLine("Bem vindo Admim, o que desejas fazer ?");
            Console.WriteLine("1 - Acessar lista do banco de dados");
            opcao = Console.ReadKey();
        
            switch(opcao.Key)
            {
                case ConsoleKey.D1:
                    banco.GetUsuarios();
                break;
            }
        
        break;

        case ConsoleKey.D3;

        break;

    }



        
    