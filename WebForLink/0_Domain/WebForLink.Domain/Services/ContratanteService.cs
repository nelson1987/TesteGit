using System;
using System.Collections.Generic;
using WebForLink.Domain.Entities;
using WebForLink.Domain.Entities.Categorias;
using WebForLink.Domain.Entities.Status;
using WebForLink.Domain.Entities.Tipos;
using WebForLink.Domain.Interfaces;
using WebForLink.Domain.ValueObject;

namespace WebForLink.Domain.Services
{
    public class ContratanteService : IContratanteService
    {
        public ContratanteService()
        {
            _contratante = new ClienteAncora("Samarco");
        }

        private Contratante _contratante { get; set; }

        //public void IncluirCategoria(CategoriaEmpresa categoria)
        //{
        //    _contratante.AdicionarCategoria(categoria);
        //    throw new NotImplementedException();
        //}

        public void IncluirFornecedor(Fornecedor empresa)
        {
            _contratante.AdicionarEmpresa(empresa);
        }

        public void IncluirPerfil(Perfil perfil)
        {
            _contratante.AdicionarPerfil(perfil);
        }

        public void IncluirPapel(Papel papel)
        {
            _contratante.AdicionarPapel(papel);
        }

        public void IncluirDocumento(Documento documento)
        {
            _contratante.IncluirDocumento(documento);
        }

        public void IncluirCliente(Cliente empresa)
        {
            _contratante.IncluirCliente(empresa);
        }

        public void IncluirFabricante(Fabricante empresa)
        {
            _contratante.IncluirFabricante(empresa);
        }

        public void IncluirCategoria(CategoriaEmpresa categoria)
        {
            _contratante.IncluirCategoria(categoria);
        }

        public void IncluirCategoria(CategoriaEmpresa categoria, List<Documento> documentos)
        {
            throw new NotImplementedException();
        }

        public void IncluirUsuario(Usuario usuario)
        {
            _contratante.AdicionarUsuario(usuario);
        }

        public void IncluirCompartilhamento(Compartilhamento compartilhamento, FichaCompartilhada ficha,
            List<Email> emails)
        {
            throw new NotImplementedException();
        }

        public void IncluirContato(Contato contato)
        {
            throw new NotImplementedException();
        }

        public void IncluirBanco(Banco banco)
        {
            _contratante.IncluirBanco(banco);
        }

        public void IncluirImportacao(Importacao importacao)
        {
            _contratante.IncluirImportacao(importacao);
        }


        public void IncluirSolicitacao(Solicitacao solicitacao)
        {
            throw new NotImplementedException();
        }

        public void IncluirStatusEmpresa(StatusEmpresa status)
        {
            throw new NotImplementedException();
        }

        public void IncluirPreCadastro(PreCadastro empresa)
        {
            throw new NotImplementedException();
        }

        public void IncluirEmpresa(Empresa empresa)
        {
            _contratante.AdicionarEmpresa(empresa);
        }
    }
}