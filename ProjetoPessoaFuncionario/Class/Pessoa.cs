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
            get => this.Nome;
            set => Nome = value;
        }
        public string Endereco
        {
            get => this.Endereco;
            set => Endereco = value;
        }
        public string Sexo
        {
            get => this.Sexo;
            set => Sexo = value;
        }
        public string CPF
        {
            get => this.CPF;
            set => CPF = value;
        }
        public string Idade
        {
            get => this.Idade;
            set => Idade = value;
        }
        public string Celular
        {
            get => this.Celular;
            set => Celular = value;
        }
    }
}
