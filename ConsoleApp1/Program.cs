internal class Program
{
    public static void Main(string[] args)
    {
        BancoDeDados banco = new BancoDeDados();

        Usuario usuario1 = new Usuario("Richardson", "123456");

        banco.AdicionarUsuarioBanco(new Usuario[] { usuario1});

        Console.Clear();
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
                Usuario.CriarPerfil(banco);
            break;

            case ConsoleKey.D2:
                Console.WriteLine("Bem vindo Admim, o que desejas fazer ?");
                Console.WriteLine("1 - Acessar lista do banco de dados");
                opcao = Console.ReadKey();
        
                switch(opcao.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(banco.GetUsuarios());
                    break;
                }
            break;

            case ConsoleKey.D3:
                Console.WriteLine("Caso 3");
            break;
        }
    }
}


        
    