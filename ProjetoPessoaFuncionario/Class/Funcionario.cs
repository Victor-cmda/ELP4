using ProjetoPessoaFuncionario.Class;

public class Funcionario : Pessoas
{
    protected string matricula;
    protected double salario;
    protected int nrdependente;
    protected string escolaridade;

    public Funcionario()
    {
        matricula = "";
        salario = 0.0;
        nrdependente = 0;
        escolaridade = "";
    }

    public Funcionario(string Nome, string Endereco, char Sexo, string CPF, int Idade, string Celular, string Matricula, double Salario, int NrDependente, string Escolaridade)
        : base(Nome, Endereco, Sexo, CPF, Idade, Celular)
    {
        this.matricula = Matricula;
        this.salario = Salario;
        this.nrdependente = NrDependente;
        this.escolaridade = Escolaridade;
    }

    public string Matricula
    {
        get => this.Matricula;
        set => Matricula = value;
    }
    public double Salario
    {
        get => this.Salario;
        set => Salario = value;
    }
    public int NrDependente
    {
        get => this.NrDependente;
        set => NrDependente = value;
    }
    public string Escolaridade
    {
        get => this.Escolaridade;
        set => Escolaridade = value;
    }
}