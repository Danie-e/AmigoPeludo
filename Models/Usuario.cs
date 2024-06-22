namespace AmigoPeludo.Models
{
    public class Usuario
    {
        private int _id;
        public int id { get => _id; set => _id = value; }
        public string _nome;
        public string nome { get => _nome; set=> _nome =value; }
        public DateTime _dataNascimento;
        public DateTime dataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string _senha;
        public string senha { get=> _senha; set=> _senha=value; }
        public Usuario()
        {

        }
    }
}
