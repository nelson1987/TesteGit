using System.Collections.Generic;

namespace WebForLink.Domain.Entities.Tipos
{
    public abstract class TipoContratante
    {
        private TipoContratante()
        {
        }

        protected TipoContratante(string nome)
            : this()
        {
            Nome = nome;
        }
        /*
        protected TipoContratante(int id, string nome)
            : this(nome)
        {
            Id = id;
            Nome = nome;
        }
        */
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Contratante> Contratantes { get; private set; }
    }

    /// <summary>
    /// Cliente Âncora
    /// </summary>
    public class ClienteContratante : TipoContratante
    {
        public ClienteContratante()
            : base("Cliente Âncora")
        {
        }
    }
    /// <summary>
    /// Fornecedor Individual
    /// </summary>
    public class FornecedorContratante : TipoContratante
    {
        public FornecedorContratante()
            : base("Fornecedor Individual")
        {
        }

    }
    /// <summary>
    /// Fabricante Âncora
    /// </summary>
    public class FabricanteContratante : TipoContratante
    {
        public FabricanteContratante()
            : base("Fabricante")
        {
        }

    }
}