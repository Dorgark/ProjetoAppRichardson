public class BancoDeDados
{
    public List<Usuario> usuarios = new List<Usuario>();

    public List<Usuario> GetUsuarios()
    {
        return this.usuarios;
    }
    public void AdicionarUsuarioBanco(Usuario[] usuario)
    {
        foreach (Usuario user in usuario)
        {
            this.usuarios.Add(user);
            Console.WriteLine("");
            Console.WriteLine("Press ESC to leave");
        }
    }
}