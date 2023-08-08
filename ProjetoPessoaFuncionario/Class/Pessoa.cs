namespace ProjetoPessoaFuncionario.Class
{
    public class Pessoas
    {
        protected string nome;
        protected string endereco;
        protected char sexo;
        protected string cpf;
        protected int idade;
        protected string celular;

        public Pessoas()
        {
            nome = "";
            endereco = "";
            sexo = ' ';
            cpf = "";
            idade = 0;
            celular = "";
        }
        public Pessoas(string Nome, string Endereco, char Sexo, string CPF, int Idade, string Celular)
        {
            this.nome = Nome;
            this.endereco = Endereco;
            this.sexo = Sexo;
            this.cpf = CPF;
            this.idade = Idade;
            this.celular = Celular;
        }

        public string Nome
        {
            get => this.nome;
            set => nome = value;
        }
        public string Endereco
        {
            get => this.endereco;
            set => endereco = value;
        }
        public char Sexo
        {
            get => this.sexo;
            set => sexo = value;
        }
        public string CPF
        {
            get => this.cpf;
            set => cpf = value;
        }
        public int Idade
        {
            get => this.idade;
            set => idade = value;
        }
        public string Celular
        {
            get => this.celular;
            set => celular = value;
        }
    }
}
