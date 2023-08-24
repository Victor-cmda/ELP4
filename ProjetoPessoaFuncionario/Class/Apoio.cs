using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Apoio : Funcionario
    {
        public Apoio(string Nome, char Sexo, int Idade, int Matricula, double Salario, double gratProd, char Cargo, int numDep) : base(Nome, Sexo, Idade, Matricula, Salario, gratProd, Cargo, numDep)
        {
        }

        public double CalcAuxilioEducacao()
        {
            var numDep = this.numDep;
            var aux = 0.0;

            if (numDep >= 5)
                aux = 5 * 60;
            else
                aux = numDep * 60;

            return aux;
        }

        public override double CalcSalLiq()
        {
            return (base.CalcSalLiq() + CalcAuxilioEducacao());
        }
    }
}