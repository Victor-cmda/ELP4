namespace ProjetoPessoaFuncionario.Class
{
    public class Chefe : Funcionario
    {
        protected double gratificacaoChefe = 0;

        public Chefe(string Nome, char Sexo, int Idade, int Matricula, double Salario, double gratProd, char Cargo, int numDep) : base(Nome, Sexo, Idade, Matricula, Salario, gratProd, Cargo, numDep)
        {
        }

        public double GratificacaoChefe
        {
            get => gratificacaoChefe;
            set => gratificacaoChefe = value;
        }

        public override double SalarioBruto()
        {
            return (base.SalarioBruto() + gratificacaoChefe);
        }
    }
}
