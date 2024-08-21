class Usuario
{
    public string nome;
    public string email;

    private string senha;
    private double cpf;
    private double numero;

    public Usuario(string nome, string email, string senha, double cpf, double numero)
    {
    this.nome = nome;
    this.email = email;
    this.senha = senha;
    this.cpf = cpf;
    this.numero = numero;
    }
}
