using ProjetoPessoaFuncionario.Class;

public class Funcionario : Pessoas
{
    protected int matricula;
    protected double salarioBase;
    protected double gratProd;
    protected int numDep;
    protected char cargo;

    public Funcionario() : base()
    {
        matricula = 0;
        salarioBase = 0.0;
        gratProd = 0;
        cargo = ' ';
    }

    public Funcionario(string Nome, char Sexo, int Idade, int Matricula, double Salario, double gratProd, char Cargo, int numDep)
        : base(Nome, Sexo, Idade)
    {
        this.nome = Nome;
        this.idade = Idade;
        this.sexo = Sexo;
        this.matricula = Matricula;
        this.salarioBase = Salario;
        this.gratProd = gratProd;
        this.cargo = Cargo;
        this.numDep = numDep;
    }

    public int Matricula
    {
        get => this.matricula;
        set => matricula = value;
    }
    public double SalarioBase
    {
        get => this.salarioBase;
        set => salarioBase = value;
    }
    public int NumDep
    {
        get => this.numDep;
        set => numDep = value;
    }
    public double GratProd
    {
        get => this.gratProd;
        set => gratProd = value;
    }
    public char Cargo
    {
        get => this.cargo;
        set => cargo = value;
    }

    public virtual  double SalarioBruto()
    {
        return this.salarioBase + this.gratProd;
    }

    public double CalcINSS()
    {
        double salario = this.salarioBase;

        double descontoINSS = 0.0;

        if (salario <= 1100)
        {
            descontoINSS = salario * 0.075;
        }
        else if (salario <= 2203.48)
        {
            descontoINSS = salario * 0.09;
        }
        else if (salario <= 3305.22)
        {
            descontoINSS = salario * 0.12;
        }
        else if (salario <= 6433.57)
        {
            descontoINSS = salario * 0.14;
        }
        else
        {
            descontoINSS = 751.99;
        }

        return descontoINSS;
    }


    public double CalcIR()
    {
        double salario = this.salarioBase;

        double descontoIR = 0.0;

        if (salario <= 1903.98)
        {
            descontoIR = 0.0;
        }
        else if (salario <= 2826.65)
        {
            descontoIR = salario * 0.075 - 142.80;
        }
        else if (salario <= 3751.05)
        {
            descontoIR = salario * 0.15 - 354.80;
        }
        else if (salario <= 4664.68)
        {
            descontoIR = salario * 0.225 - 636.13;
        }
        else
        {
            descontoIR = salario * 0.275 - 869.36;
        }

        return descontoIR;
    }

    public double CalcDesc()
    {
        return (CalcINSS() + CalcIR());
    }

    public virtual double CalcSalLiq()
    {
        return (this.SalarioBruto() - this.CalcDesc());
    }
}