namespace ProjetoPessoaFuncionario.Class
{
    public class Chefe : Funcionario
    {
        protected double gratificacaoChefe = 0;

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
