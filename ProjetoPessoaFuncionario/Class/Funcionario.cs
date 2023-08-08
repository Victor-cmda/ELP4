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
        get => this.matricula;
        set => matricula = value;
    }
    public double Salario
    {
        get => this.salario;
        set => salario = value;
    }
    public int NrDependente
    {
        get => this.nrdependente;
        set => nrdependente = value;
    }
    public string Escolaridade
    {
        get => this.escolaridade;
        set => escolaridade = value;
    }
    public double CalcSalBruto()
    {
        //realizar calculo de salário bruto
        return this.salario;
    }
    public double CalcINSS()
    {
        double salario = this.salario;

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
        double salario = this.salario;

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
        var inss = CalcINSS();
        var ir = CalcIR();

        return inss + ir;
    }

    public double CalcSalLiq()
    {
        var calcDesc = CalcDesc();
        return this.salario - calcDesc;
    }

    public double CalcAuxilioEducacao()
    {
        return this.nrdependente * 100;
    }

    public double CalcGratificacao()
    {
        
        return this.salario * 0.10;
    }
}