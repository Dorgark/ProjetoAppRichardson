public class Usuario
{
    public string nome;
    private string senha;
    private int id;

    public Usuario (string nome, string senha)
    {
        Random valor = new Random();
        this.id = valor.Next();
        this.nome = nome;
        this.senha = senha;
        
    }

    public void CriarPerfil(BancoDeDados banco)
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome de perfil");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua senha");
        string senha = Console.ReadLine();
        banco.AdicionarUsuarioBanco(new Usuario[] {new Usuario(nome, senha)});
    }
}