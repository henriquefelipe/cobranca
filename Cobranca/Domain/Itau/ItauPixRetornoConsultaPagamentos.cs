using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Itau
{
    public class ItauPixRetornoConsultaPagamentos
    {

        public ItauPixRetornoConsultaPagamentosData data { get; set; }
        public ItauPixRetornoConsultaPagamentosPagination pagination { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentosData
    {
        public ItauPixRetornoConsultaPagamentosData()
        {
            itens = new List<ItauPixRetornoConsultaPagamentosDataItem>();
        }


        public decimal total { get; set; }
        public List<ItauPixRetornoConsultaPagamentosDataItem> itens { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentosDataItem
    {
        public string id_pagamento { get; set; }
        public string status { get; set; }
        public string nome_favorecido { get; set; }
        public string cpf_cnpj { get; set; }
        public string tipo_pagamento { get; set; }
        public string referencia_empresa { get; set; }
        public DateTime data_pagamento { get; set; }
        public decimal valor_pagamento { get; set; }
        public string numero_lote { get; set; }
        public string numero_lancamento { get; set; }
    }

    public class ItauPixRetornoConsultaPagamentosPagination
    {
        public int page { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public int pageSize { get; set; }
    }
}
