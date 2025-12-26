using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Itau
{
    public class ItauPixRetornoConsultaPagamento
    {
        public ItauPixRetornoConsultaPagamentoData data { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentoData
    {
        public ItauPixRetornoConsultaPagamentoDataDadosDebito dados_debito { get; set; }
        public ItauPixRetornoConsultaPagamentoDataDadosPagamento dados_pagamento { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentoDataDadosDebito
    {
        public string numero_agencia_debito { get; set; }
        public string numero_conta_debito { get; set; }
        public string nome_empresa_debito { get; set; }
        public string cnpj_debito { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentoDataDadosPagamento
    {
        public string id_pagamento { get; set; }
        public string cod_tipo_pessoa { get; set; }
        public string cpf_cnpj_favorecido { get; set; }
        public string nome_banco_favorecido { get; set; }
        public string nome_favorecido { get; set; }
        public decimal valor_pagamento { get; set; }
        public string numero_lote { get; set; }
        public string numero_lancamento { get; set; }
        public string referencia_empresa { get; set; }
        public DateTime data_pagamento { get; set; }
        public string status { get; set; }
        public string identificacao_comprovante { get; set; }
        public string codigo_isbp { get; set; }
        public string tipo_pagamento { get; set; }
        public string tipo_pagamento_descricao { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentoDataHistorico
    {
        public string status { get; set; }
        public DateTime data { get; set; }
        public string cod_operador { get; set; }
    }
}
