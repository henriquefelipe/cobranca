using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Boleto
{
    public class BoletoPagadorRetorno
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public decimal valor { get; set; }
        public decimal valor_taxa { get; set; }
        public decimal valor_acrescimo { get; set; }
        public decimal valor_liquido { get; set; }
        public string status { get; set; }
        public DateTime dataPagamento { get; set; }
        public DateTime dataRecebimento { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataEmissao { get; set; }
        public string clienteChave { get; set; }
        public string clienteNome { get; set; }
        public string clienteDocumento { get; set; }
        public string invoiceUrl { get; set; }
        public string pdfUrl { get; set; }
        public string descricao { get; set; }
    }
}
