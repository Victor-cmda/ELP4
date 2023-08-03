using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Apoio : Funcionario
    {
        protected string tarefa;
        protected double auxilioEducacao;

        public Apoio()
        {
            tarefa = "";
            auxilioEducacao = 0.0;
        }

        public Apoio(string Nome, string Endereco, char Sexo, string CPF, int Idade, string Celular, string Matricula,
            double Salario, int NrDependente, string Escolaridade, string Tarefa, double AuxilioEducacao)
            : base(Nome, Endereco, Sexo, CPF, Idade, Celular, Matricula, Salario, NrDependente, Escolaridade)
        {
            this.tarefa = Tarefa;
            this.auxilioEducacao = AuxilioEducacao;
        }

        public string Tarefa
        {
            get => this.Tarefa;
            set => Tarefa = value;
        }

        public double AuxilioEducacao
        {
            get => this.AuxilioEducacao;
            set => AuxilioEducacao = value;
        }
    }
}
