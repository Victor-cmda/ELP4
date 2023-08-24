namespace ProjetoPessoaFuncionario
{
    public class Interfaces
    {
        public Interfaces()
        {

        }

        public void PecaDadosFuncionario(ref string nome, ref char sexo, ref int idade, ref int matricula,
            ref double salBase, ref double gratProd, ref int numDep, ref char cargo, ref double gratChefia)
        {
            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Sexo (M/F): ");
            char.TryParse(Console.ReadLine(), out sexo);

            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            Console.Write("Matrícula: ");
            int.TryParse(Console.ReadLine(), out matricula);

            Console.Write("Salário Base: ");
            double.TryParse(Console.ReadLine(), out salBase);

            Console.Write("Gratificação de Produtividade: ");
            double.TryParse(Console.ReadLine(), out gratProd);

            Console.Write("Número de Dependentes: ");
            int.TryParse(Console.ReadLine(), out numDep);

            Console.Write("Cargo: ");
            char.TryParse(Console.ReadLine(), out cargo);

            if (cargo == 'C')
            {
                Console.Write("Gratificação de Chefia: ");
                double.TryParse(Console.ReadLine(), out gratChefia);
            }


        }
        public void PecaDadosEmpresa(ref string razaoSocial, ref string cnpj, ref int numFunc)
        {
            Console.Write("Razão Social: ");
            razaoSocial = Console.ReadLine();

            Console.Write("CNPJ: ");
            cnpj = Console.ReadLine();

            Console.Write("Número de Funcionários: ");
            int.TryParse(Console.ReadLine(), out numFunc);
        }

        public void DemonstrativoEmpresa(string nome, double salBruto, double desc, double salLiquido)
        {
            Console.WriteLine($"Nome {nome} Sal. Bruto= {salBruto} Descontos= {desc} Sal. Liquido= {salLiquido}");
        }
        public void DemonstrativoFuncionario(string nome, double salBruto, double desconto, double salLiquido)
        {
            Console.WriteLine($"Nome {nome} Sal. Bruto= {salBruto} Desconto= {desconto} Salário Liq.= {salLiquido}");
        }
    }
}
