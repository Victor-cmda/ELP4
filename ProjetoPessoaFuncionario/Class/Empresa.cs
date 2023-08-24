using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Empresa
    {
        protected string razaoSocial;
        protected string cnpj;
        protected int numFuncionarios;

        Funcionario oFunc;
        protected double totalSalBruto = 0;
        protected double totalSalLiquido = 0;
        protected double totalInss = 0;
        protected double totalIr = 0;

        public Empresa()
        {
            razaoSocial = "";
            cnpj = "";
            numFuncionarios = 0;
            totalSalBruto = 0;
            totalSalLiquido = 0;
            totalInss = 0;
            totalIr = 0;
        }

        public Empresa(string RazaoSocial, string CNPJ, int NumFuncionarios)
        {
            this.razaoSocial = RazaoSocial;
            this.cnpj = CNPJ;
            this.numFuncionarios = NumFuncionarios;
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

        public void ProcessaFolha(Interfaces aInter)
        {
            string nome = "";
            char sexo = ' ';
            int idade = 0;
            int matricula = 0;
            double salBase = 0;
            double gratProd = 0;
            int numDep = 0;
            char cargo = ' ';
            double gratChefia = 0;

            int conta = 0;

            while (conta <= numFuncionarios)
            {
                aInter.PecaDadosFuncionario(ref nome, ref sexo, ref idade, ref matricula, ref salBase, ref gratProd, ref numDep, ref cargo, ref gratChefia);
                if (cargo == 'F')
                {
                    oFunc = new Funcionario(nome, sexo, idade, matricula, salBase, gratProd, cargo, numDep);
                }
                else if (cargo == 'A')
                    {
                    oFunc = new Apoio(nome, sexo, idade, matricula, salBase, gratProd, cargo, numDep);
                }
                else if (cargo == 'C')
                {
                    oFunc = new Chefe(nome, sexo, idade, matricula, salBase, gratProd, cargo, numDep);
                }
                totalSalBruto += oFunc.SalarioBruto();
                totalInss += oFunc.CalcINSS();
                totalIr += oFunc.CalcIR();
                totalSalLiquido += oFunc.CalcSalLiq();
                aInter.DemonstrativoFuncionario(oFunc.Nome,oFunc.SalarioBruto(),oFunc.CalcDesc(),oFunc.CalcSalLiq());
                aInter.DemonstrativoEmpresa(razaoSocial, totalSalBruto, CalcDesc(), totalSalLiquido);
                conta++;
            }


        }

        private double CalcDesc()
        {
            return (totalInss + totalIr);
        }
    }
}
