namespace ProjetoPessoaFuncionario.Class
{
    public class Pessoas
    {
        protected string nome;
        protected char sexo;
        protected int idade;

        public Pessoas()
        {
            nome = "";
            sexo = ' ';
            idade = 0;
        }
        public Pessoas(string Nome, char Sexo, int Idade)
        {
            this.nome = Nome;
            this.sexo = Sexo;
            this.idade = Idade;
        }

        public string Nome
        {
            get => this.nome;
            set => nome = value;
        }
        public char Sexo
        {
            get => this.sexo;
            set => sexo = value;
        }
        public int Idade
        {
            get => this.idade;
            set => idade = value;
        }
    }
}
