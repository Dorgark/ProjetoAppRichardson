using System.Net.Mail;

class Usuario
{
    public string nome;
    private string senha;
    private int id;

    public Usuario (string nome, string senha, int id)
    {
        this.nome = nome;
        this.senha = senha;
        this.id = id;
    }

    public void CriarPerfil()
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome de perfil");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua senha");
        senha = Console.ReadLine();
    }
}