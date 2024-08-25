public class DevConsole
{
    public void AccessDev()
    {
        ConsoleKeyInfo opcao = new ConsoleKeyInfo();
        
        Console.Clear();
        Console.WriteLine("Bem vindo Admim, o que desejas fazer ?");
        Console.WriteLine("1 - Acessar lista do banco de dados");

        
        opcao = Console.ReadKey();

        switch(opcao.Key)
        {
            case ConsoleKey.D1:
                BancoDeDados.GetUsuarios();
            break;
        }
    }
}