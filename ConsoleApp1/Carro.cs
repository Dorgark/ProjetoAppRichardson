class Carro
{
    string nome;
    string placa;
    int ano;

    public Carro(string nome, string placa, int ano)
    {
        this.nome = nome;
        this.placa = placa;
        this.ano = ano;
    }

    public void AdicionarPlacaAleatoria()
    {
        Random random = new Random();
        string placaEscolhida = "";
        
        for(int i = 0; i < 3; i++)
        {
            
            char letraEscolhida = Convert.ToChar(random.Next(64,90));
        
            placaEscolhida += letraEscolhida;
        }

        for(int i = 0; i < 4; i++)
        {
            char numeroEscolhido = Convert.ToChar(random.Next(0,10));
            placaEscolhida += numeroEscolhido;
        }    
    }

    public void AdicionarNomeAleatorio()
    {
        Random random = new Random();

        string[] nomes = {"Fernando", "Eduardo", "Luiz", "Felipe", "Cassio"};
        string nomeEscolhido = nomes [random.Next(0, nomes.Length)];
    }

}