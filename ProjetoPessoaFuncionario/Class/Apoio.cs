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
            get => this.tarefa;
            set => tarefa = value;
        }

        public double AuxilioEducacao
        {
            get => this.auxilioEducacao;
            set => auxilioEducacao = value;
        }

        public void PecaDadosApoio()
        {
            Console.WriteLine("Informe os dados do funcionário:");

            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("Endereço: ");
            Endereco = Console.ReadLine();

            Console.Write("Sexo: ");
            char sexo;
            if (char.TryParse(Console.ReadLine(), out sexo))
            {
                Sexo = sexo;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
            }

            Console.Write("CPF: ");
            CPF = Console.ReadLine().ToString();

            Console.Write("Idade: ");
            int idade;
            if (int.TryParse(Console.ReadLine(), out idade))
            {
                Idade = idade;
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }

            Console.Write("Celular: ");
            Celular = Console.ReadLine();

            Console.Write("Matrícula: ");
            Matricula = Console.ReadLine();

            Console.Write("Quantidade de Dependentes: ");
            int nrdependete;
            if (int.TryParse(Console.ReadLine(), out nrdependete))
            {
                NrDependente = nrdependete;
            }
            else
            {
                Console.WriteLine("Salário inválido.");
            }

            Console.Write("Salário: ");
            double salario;
            if (double.TryParse(Console.ReadLine(), out salario))
            {
                Salario = salario;
            }
            else
            {
                Console.WriteLine("Salário inválido.");
            }

            Console.WriteLine("Dados do funcionário foram coletados.");
        }
    }
}
