namespace WebForLink.Domain.Entities
{
    public class Fornecedor : Empresa
    {
        public Fornecedor(string razaoSocial, string documento, TipoEmpresa tipo)
            : base(razaoSocial, documento, tipo)
        {
        }
    }

    public class Cliente : Empresa
    {
        public Cliente(string razaoSocial, string documento, TipoEmpresa tipo)
            : base(razaoSocial, documento, tipo)
        {
        }
    }

    public class Fabricante : Empresa
    {
        public Fabricante(string razaoSocial, string documento)
            : base(razaoSocial, documento, new TipoEmpresa("Pessoa Jurídica"))
        {
        }
    }
}