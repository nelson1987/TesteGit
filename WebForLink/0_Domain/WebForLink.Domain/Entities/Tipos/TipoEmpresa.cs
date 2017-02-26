using System.Collections.Generic;

namespace WebForLink.Domain.Entities.Tipos
{
    public abstract class TipoEmpresa
    {
        private TipoEmpresa()
        {
        }

        protected TipoEmpresa(string nome)
            : this()
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Contratante> Contratantes { get; private set; }
    }

    public class EmpressaPessoaJuridica : TipoEmpresa
    {
        public EmpressaPessoaJuridica()
            : base("Pessoa Jurídica")
        {
        }
    }

    public class EmpressaPessoaFisica : TipoEmpresa
    {
        public EmpressaPessoaFisica()
            : base("Pessoa Física")
        {
        }
    }

    public class EmpresaEstrangeira : TipoEmpresa
    {
        public EmpresaEstrangeira()
            : base("Estrangeira")
        {
        }
    }
}