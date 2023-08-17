using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Apoio : Funcionario
    {
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