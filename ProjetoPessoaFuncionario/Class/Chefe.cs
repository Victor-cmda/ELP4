namespace ProjetoPessoaFuncionario.Class
{
    public class Chefe : Funcionario
    {
        protected string departamento;
        protected double gratificacaoChefe;

        public Chefe()
        {
            departamento = "";
            gratificacaoChefe = 0.0;
        }

        public Chefe(string Nome, string Endereco, char Sexo, string CPF, int Idade, string Celular, string Matricula,
            double Salario, int NrDependente, string Escolaridade, string Departamento, double GratificacaoChefe)
            : base(Nome, Endereco, Sexo, CPF, Idade, Celular, Matricula, Salario, NrDependente, Escolaridade)
        {
            this.departamento = Departamento;
            this.gratificacaoChefe = GratificacaoChefe;
        }

        public string Departamento
        {
            get => this.Departamento;
            set => Departamento = value;
        }

        public double GratificacaoChefe
        {
            get => this.GratificacaoChefe;
            set => GratificacaoChefe = value;
        }
    }
}
