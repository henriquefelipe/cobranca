using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Enum.Itau
{
    public class PagamentoStatus
    {
        public const string PENDENTE_DE_AUTORIZACAO = "Pendente de autorização";
        public const string PENDENTE_DE_EFETIVACAO = "Pendente de efetivacao";
        public const string AUTORIZADO = "Autorizado";
        public const string EFETUADO = "Efetuado";
        public const string NAO_EFETUADO = "Não Efetuado";
        public const string PENDENTE_DE_ALTERACAO_EXCLUSAO = "Pendente de alteração/exclusão";
        public const string REJEITADO_EM_ARQUIVO = "Rejeitado em arquivo";        
    }
}
