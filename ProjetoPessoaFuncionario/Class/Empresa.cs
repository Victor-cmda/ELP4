using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Empresa
    {
        protected string razaoSocial;
        protected string cnpj;
        protected int numFuncionarios;

        protected double totalSalBruto = 0;
        protected double totalSalLiquido = 0;
        protected double totalDesc = 0;
        protected double totalInss = 0;
        protected double totalIr = 0;

        public Empresa()
        {
            razaoSocial = "";
            cnpj = "";
            numFuncionarios = 0;
            totalSalBruto = 0;
            totalSalLiquido = 0;
            totalDesc = 0;
            totalInss = 0;
            totalIr = 0;
        }

        public Empresa(string RazaoSocial, string CNPJ, int NumFuncionarios, double TotalSalBruto, double TotalSalLiquido, double TotalDesc, double TotalINSS, double TotalIR)
        {
            this.razaoSocial = RazaoSocial;
            this.cnpj = CNPJ;
            this.numFuncionarios = NumFuncionarios;
            totalSalBruto = TotalSalBruto;
            totalSalLiquido = TotalSalBruto;
            totalDesc = TotalDesc;
            totalIr = TotalIR;
            totalInss = TotalINSS;
        }

        public string RazaoSocial
        {
            get => this.razaoSocial;
            set => razaoSocial = value;
        }

        public string CNPJ
        {
            get => this.cnpj;
            set => cnpj = value;
        }

        public int NumFuncionarios
        {
            get => this.numFuncionarios;
            set => numFuncionarios = value;
        }

        public double TotalSalBruto()
        {
            //realizar calculo de total salário bruto de todos funcionários
            return 1;
        }

        public double TotalSalLiq()
        {
            //realizar calculo de total salário liquido de todos funcionários
            return 1;
        }

        public double TotalDescIR()
        {
            //realizar calculo de total salário liquido de todos funcionários
            return 1;
        }

        public double TotalDescINSS()
        {
            //realizar calculo de total de INSS de todos funcionários
            return 1;
        }

        public double ProcessaFolha()
        {
            //realizar calculo de total de INSS de todos funcionários
            return 1;
        }
    }
}
