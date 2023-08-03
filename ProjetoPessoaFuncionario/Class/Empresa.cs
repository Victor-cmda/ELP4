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
            get => this.CNPJ;
            set => CNPJ = value;
        }

        public int NrFuncionarios
        {
            get => this.NrFuncionarios;
            set => NrFuncionarios = value;
        }
    }
}
