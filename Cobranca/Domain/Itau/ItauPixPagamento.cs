using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Itau
{
    public class ItauPixPagamento
    {
        public decimal valor_pagamento { get; set; }
        public string data_pagamento { get; set; }
        public string chave { get; set; }
        public string referencia_empresa { get; set; }
        public string identificacao_comprovante { get; set; }
        public string informacoes_entre_usuarios { get; set; }        
        public ItauPagador pagador { get; set; }
    }


}
