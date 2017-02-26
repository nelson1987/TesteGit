using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class FichaCadastral
    {
        protected FichaCadastral()
        {
            Contatos = new List<Contato>();
            Anexos = new List<Documento>();
            Enderecos = new List<Endereco>();
            Bancos = new List<Banco>();
            Servicos = new List<Servico>();
            Materiais = new List<Material>();
        }

        public int Id { get; private set; }
        //public Contratante Contratante { get; private set; }
        public Robo Robos { get; private set; }
        public List<Contato> Contatos { get; private set; }
        public List<Documento> Anexos { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public List<Banco> Bancos { get; private set; }
        public List<Servico> Servicos { get; private set; }
        public List<Material> Materiais { get; private set; }
    }
}