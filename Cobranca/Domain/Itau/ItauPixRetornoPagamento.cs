using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Itau
{
    public class ItauPixRetornoPagamento
    {
        public string status_pagamento { get; set; }
        public string cod_pagamento { get; set; }
        public string numero_lote { get; set; }
        public string numero_lancamento { get; set; }       
    }

    public class ItauPixRetornoPagamentoRecebedor
    {
        public string banco { get; set; }
        public string ispb { get; set; }
        public string documento { get; set; }
        public string nome { get; set; }
        public string tipo_conta { get; set; }
        public string tipo_pessoa { get; set; }
    }
}
