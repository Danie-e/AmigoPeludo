namespace AmigoPeludo.Models
{
    public class Endereco
    {

        private string _estado;
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _cidade;
        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private string _bairro;
        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _rua;
        public string rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        private int _numero;
        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _complemento;
        public string complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        public Endereco()
        {
        }
        public Endereco(string estado, string cidade, string bairro, string rua, int numero, string complemento)
        {
            _estado = estado;
            _cidade = cidade;
            _bairro = bairro;
            _rua = rua;
            _numero = numero;
            _complemento = complemento;
        }
    }
}
