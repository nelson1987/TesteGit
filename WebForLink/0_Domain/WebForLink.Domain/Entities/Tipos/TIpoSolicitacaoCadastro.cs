using System;

namespace WebForLink.Domain.Entities.Tipos
{
    public class TipoSolicitacaoCadastro : Solicitacao
    {
        public TipoSolicitacaoCadastro(Usuario criador, Empresa solicitado)
            : base(criador, solicitado)
        {
            var tipoDeEmpresa = "Empresa";
            if (solicitado.Tipo != null)
                if (!string.IsNullOrEmpty(solicitado.Tipo.Nome))
                    tipoDeEmpresa = solicitado.Tipo.Nome;
            SetTipo(new TipoSolicitacao(String.Format("Cadastro de {0}", tipoDeEmpresa)));
        }
    }
}