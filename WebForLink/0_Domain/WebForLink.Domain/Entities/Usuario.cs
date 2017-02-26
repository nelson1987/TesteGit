using System;
using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class Usuario
    {
        private Usuario()
        {
            Perfis = new List<Perfil>();
        }

        public Usuario(string login) : this()
        {
            Login = login;
        }

        public Usuario(string login, Aplicacao aplicacao, Contratante contratante)
            : this(login)
        {
            Aplicacao = aplicacao;
            Contratante = contratante;
        }

        public int Id { get; private set; }
        public string Login { get; private set; }
        public Contratante Contratante { get; private set; }
        public Aplicacao Aplicacao { get; private set; }

        public List<Perfil> Perfis { get; set; }

        //public List<Empresa> VisualizarFornecedores
        //{
        //    get
        //    {
        //        if (Contratante == null)
        //            throw new Exception("O usuário deve ter um contratante atrelado a ele.");

        //        return Contratante
        //            .EmpresasCadastradas
        //            .ToList();
        //    }
        //}

        //public List<Empresa> VisualizarFornecedoresCadastrados
        //{
        //    get
        //    {
        //        if (Contratante == null)
        //            throw new Exception("O usuário deve ter um contratante atrelado a ele.");

        //        return Contratante
        //            .EmpresasCadastradas
        //            .Where(x => x.Status == new StatusEmpresa("Ativo"))
        //            .ToList();
        //    }
        //}

        public void ContratadoPor(Contratante contratante)
        {
            Contratante = contratante;
        }

        public void AdicionarPerfil(Perfil administrador)
        {
            if (Aplicacao.TemEssePerfil(administrador))
                Perfis.Add(administrador);
        }
    }
}