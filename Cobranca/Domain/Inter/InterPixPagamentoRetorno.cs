using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Inter
{
    public class InterPixPagamentoRetorno
    {
        public string tipoRetorno { get; set; } //APROVACAO
        public string codigoSolicitacao { get; set; }
        public string dataPagamento { get; set; }
        public string dataOperacao { get; set; }
    }
}
