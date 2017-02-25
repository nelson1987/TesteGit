using System;
using System.Collections.Generic;
using System.Linq;

namespace WebForLink.Domain.Entities
{
    public class Usuario
    {
        protected Usuario()
        {

        }
        public Usuario(string login)
        {
            Login = login;
        }

        public Usuario(string login, Contratante contratante)
            : this(login)
        {
            this.Contratante = contratante;
        }

        public int Id { get; private set; }

        public string Login { get; private set; }
        public Contratante Contratante { get; private set; }
        public Aplicacao Aplicacao { get; private set; }

        public List<Empresa> VisualizarFornecedores
        {
            get
            {
                if (Contratante == null)
                    throw new Exception("O usuário deve ter um contratante atrelado a ele.");

                return Contratante
                    .EmpresasCadastradas
                    .ToList();
            }
        }

        public List<Empresa> VisualizarFornecedoresCadastrados
        {
            get
            {
                if (Contratante == null)
                    throw new Exception("O usuário deve ter um contratante atrelado a ele.");

                return Contratante
                    .EmpresasCadastradas
                    .Where(x => x.Status == new StatusEmpresa("Ativo"))
                    .ToList();
            }
        }

        public void ContratadoPor(Contratante contratante)
        {
            Contratante = contratante;
        }
    }
}