using System;

namespace ProjetoPessoaFuncionario.Class
{
    public class Empresa
    {
        protected string razaoSocial;
        protected string cnpj;
        protected int nrfuncionarios;

        public Empresa()
        {
            razaoSocial = "";
            cnpj = "";
            nrfuncionarios = 0;
        }

        public Empresa(string RazaoSocial, string CNPJ, int NrFuncionarios)
        {
            razaoSocial = RazaoSocial;
            cnpj = CNPJ;
            nrfuncionarios = NrFuncionarios;
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

        public int NrFuncionarios
        {
            get => this.nrfuncionarios;
            set => nrfuncionarios = value;
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
