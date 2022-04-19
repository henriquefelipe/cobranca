using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Boleto
{
    public class Boleto
    {
        public Boleto()
        {
            mensagens = new List<string>();
        }

        public string descricao { get; set; }
        public string externalReference { get; set; }
        public DateTime emissao { get; set; }
        public DateTime vencimento { get; set; }
        public decimal valor { get; set; }
        public BoletoPagador pagador { get; set; }
        public List<string> mensagens { get; set; }
        public bool postalService { get; set; }

        public decimal descontoValor { get; set; }
        public short descontoDias { get; set; }
        public decimal multaValor { get; set; }
    }
}
