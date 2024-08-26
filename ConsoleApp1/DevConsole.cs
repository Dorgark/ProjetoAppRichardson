using System.Runtime.CompilerServices;

public class DevConsole
{
    BancoDeDados banco = new BancoDeDados();
    public void AccessDev()
    {
        
        
        //Console.Clear();
        Console.WriteLine("Bem vindo Admim, o que desejas fazer ?");
        Console.WriteLine("1 - Acessar lista do banco de dados");

        
        int opcao;
        
        opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1:
                banco.GetUsuarios();
            break;
        }
    }
}