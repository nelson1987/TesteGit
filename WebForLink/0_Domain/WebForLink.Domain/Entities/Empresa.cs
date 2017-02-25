using System.Collections.Generic;

namespace WebForLink.Domain.Entities
{
    public class Empresa
    {
        protected Empresa()
        {
            Contatos = new List<Contato>();
            Contratantes = new List<Contratante>();
            Anexos = new List<Documento>();
        }

        public Empresa(string razaoSocial, string documento, TipoEmpresa tipo) : this()
        {
            RazaoSocial = razaoSocial;
            Documento = documento;
            Tipo = tipo;
        }

        public int Id { get; private set; }
        public string RazaoSocial { get; private set; }
        public string Documento { get; private set; }
        public TipoEmpresa Tipo { get; private set; }
        public StatusEmpresa Status { get; private set; }
        public List<Contratante> Contratantes { get; private set; }
        public List<Contato> Contatos { get; private set; }
        public List<Documento> Anexos { get; private set; }
        public List<Endereco> Enderecos { get; private set; }
        public Robo Robos { get; private set; }
        public List<Banco> Bancos { get; private set; }

        public void SetTipoEmpresa(TipoEmpresa tipoEmpresa)
        {
            Tipo = tipoEmpresa;
        }

        public void SetStatusEmpresa(StatusEmpresa statusEmpresa)
        {
            Status = statusEmpresa;
        }

        public void AdicionarContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public void AdicionarDocumento(Documento documento)
        {
            Anexos.Add(documento);
        }
    }
}