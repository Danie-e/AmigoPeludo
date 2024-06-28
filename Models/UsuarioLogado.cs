namespace AmigoPeludo.Models
{
    public sealed class UsuarioLogado:Usuario
    {
        private UsuarioLogado() { }

        private static UsuarioLogado instance = null;
        public  static UsuarioLogado getInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioLogado();
            }
            return instance;
        }
     
        public void EntrarPerfil(Usuario usuario)
        {
            instance.id = usuario.id;
            instance.nome = usuario.nome;
            instance.dataNascimento = usuario.dataNascimento;
            instance.senha = usuario.senha;
        }
    }
}
