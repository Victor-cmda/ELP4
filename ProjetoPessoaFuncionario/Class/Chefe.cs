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
            get => this.departamento;
            set => departamento = value;
        }

        public double GratificacaoChefe
        {
            get => this.gratificacaoChefe;
            set => gratificacaoChefe = value;
        }

        public void PecaDadosChefe()
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

            //Console.Write("Gratificação: ");
            //double gratificacaoChefe;
            //if (double.TryParse(Console.ReadLine(), out gratificacaoChefe))
            //{
            //    GratificacaoChefe = gratificacaoChefe;
            //}
            //else
            //{
            //    Console.WriteLine("Gratificação inválido.");
            //}

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
