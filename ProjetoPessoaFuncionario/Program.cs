using ProjetoPessoaFuncionario.Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de Funcionário");
        Console.WriteLine("Qual o tipo de funcionário? 1-Apoio 2- Chefe");
        var tipoFunc = Console.ReadLine();

        switch (tipoFunc)
        {
            case "1":
                Console.WriteLine("Escolhido Apoio");
                Apoio();
                break;
            case "2":
                Console.WriteLine("Escolhido Chefe");
                Chefe();
                break;
            default:
                Console.WriteLine("Escolha Inválida");
                break;
        }
    }

    public static void Apoio()
    {
        Apoio apoio = new Apoio();
        apoio.PecaDadosApoio();

        Console.WriteLine("\nDados do Funcionário:");
        Console.WriteLine($"Nome: {apoio.Nome}");
        Console.WriteLine($"Matrícula: {apoio.Matricula}");
        Console.WriteLine($"Salário: {apoio.Salario}");

        double salarioBruto = apoio.CalcSalBruto();
        double desconto = apoio.CalcDesc();
        double salarioLiquido = apoio.CalcSalLiq();
        double descIR = apoio.CalcIR();
        double descINSS = apoio.CalcINSS();
        double auxilioEducacao = apoio.CalcAuxilioEducacao();

        Console.WriteLine($"\nSalário Bruto: {salarioBruto}");
        Console.WriteLine($"Desconto: {desconto}");
        Console.WriteLine($"Auxilio Educação: {auxilioEducacao}");
        Console.WriteLine($"Imposto de Renda: {descIR}");
        Console.WriteLine($"INSS: {descINSS}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido + auxilioEducacao}");
    }
    public static void Chefe()
    {
        Chefe chefe = new Chefe();
        chefe.PecaDadosChefe();

        Console.WriteLine("\nDados do Funcionário:");
        Console.WriteLine($"Nome: {chefe.Nome}");
        Console.WriteLine($"Matrícula: {chefe.Matricula}");
        Console.WriteLine($"Salário: {chefe.Salario}");

        double salarioBruto = chefe.CalcSalBruto();
        double desconto = chefe.CalcDesc();
        double salarioLiquido = chefe.CalcSalLiq();
        double descIR = chefe.CalcIR();
        double descINSS = chefe.CalcINSS();
        double gratificacaoChefia = chefe.CalcGratificacao();

        Console.WriteLine($"\nSalário Bruto: {salarioBruto}");
        Console.WriteLine($"Desconto: {desconto}");
        Console.WriteLine($"Gratificação Chefia: {gratificacaoChefia}");
        Console.WriteLine($"Imposto de Renda: {descIR}");
        Console.WriteLine($"INSS: {descINSS}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido + gratificacaoChefia}");
    }
}