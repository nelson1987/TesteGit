namespace WebForLink.Domain.Entities.Categorias
{
    public class CategoriaEmpresa
    {
        protected CategoriaEmpresa()
        {
        }

        public CategoriaEmpresa(string codigo, string descricao)
            : this()
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public CategoriaEmpresa(int id, string codigo, string descricao)
            : this(codigo, descricao)
        {
            Id = id;
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public CategoriaEmpresa CategoriaPai { get; private set; }
        public CategoriaEmpresaCh CategoriaCh { get; private set; }
        public Contratante Contratante { get; private set; }
    }
}