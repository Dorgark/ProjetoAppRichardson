using System.Reflection.Metadata.Ecma335;

public class BancoDeDados
{
    public List<Usuario> usuarios = new List<Usuario>();

    public List<Usuario> GetUsuarios()
    {
        string ListaDeUsuarios = return this.usuarios;
    }
    public void AdicionarUsuarioBanco(Usuario[] usuario)
    {
        foreach (Usuario user in usuario)
        {
            this.usuarios.Add(user);
        }
    }
}