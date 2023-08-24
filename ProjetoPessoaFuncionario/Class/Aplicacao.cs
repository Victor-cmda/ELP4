namespace ProjetoPessoaFuncionario.Class
{
    public class Aplicacao
    {
        protected Interfaces aInter;
        protected Empresa aEmpresa;

        string razaoSocial = "", cnpj = "";
        int numFunc = 0;

        public Aplicacao()
        {
            aInter = new Interfaces();
            aEmpresa = new Empresa();
        }

        public void Executar()
        {
            

            aInter.PecaDadosEmpresa(ref razaoSocial, ref cnpj, ref numFunc);
            //aEmpresa = new Empresa(razaoSocial, cnpj, numFunc);
            aEmpresa.RazaoSocial = razaoSocial;
            aEmpresa.CNPJ = cnpj;
            aEmpresa.NumFuncionarios = numFunc;

            aEmpresa.ProcessaFolha(aInter);
        }
    }
}
