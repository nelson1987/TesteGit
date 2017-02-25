using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class Documento
    {
        protected Documento()
        {
            Arquivos = new List<Arquivo>();
        }

        public Documento(string nome)
            : this()
        {
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public List<Arquivo> Arquivos { get; private set; }
        public Empresa Empresa { get; private set; }

        public void AdicionarArquivo(Arquivo file)
        {
            Arquivos.Add(file);
        }
    }
}