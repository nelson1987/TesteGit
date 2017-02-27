using System.Collections.Generic;
using WebForLink.Domain.Entities.Tipos;

namespace WebForLink.Domain.Entities
{
    public class Fornecedor : Empresa
    {
        public Fornecedor(string razaoSocial, string documento, TipoEmpresa tipo)
            : base(razaoSocial, documento, tipo)
        {
            Clientes = new List<Cliente>();
            Fabricantes = new List<Fabricante>();
        }

        public List<Cliente> Clientes { get; private set; }
        public List<Fabricante> Fabricantes { get; private set; }

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void AdicionarFabricante(Fabricante Fabricante)
        {
            Fabricantes.Add(Fabricante);
        }
    }

    public class Cliente : Empresa
    {
        public Cliente(string razaoSocial, string documento, TipoEmpresa tipo)
            : base(razaoSocial, documento, tipo)
        {
            Fornecedores = new List<Fornecedor>();
            Fabricantes = new List<Fabricante>();
        }

        public List<Fornecedor> Fornecedores { get; private set; }
        public List<Fabricante> Fabricantes { get; private set; }

        public void AdicionarFabricante(Fabricante Fabricante)
        {
            Fabricantes.Add(Fabricante);
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }
    }

    public class Fabricante : Empresa
    {
        public Fabricante(string razaoSocial, string documento)
            : base(razaoSocial, documento, new EmpressaPessoaJuridica())
        {
            Clientes = new List<Cliente>();
            Fornecedores = new List<Fornecedor>();
        }

        public List<Cliente> Clientes { get; private set; }
        public List<Fornecedor> Fornecedores { get; private set; }

        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }
    }
}