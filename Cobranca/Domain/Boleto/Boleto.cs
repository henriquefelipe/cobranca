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
        public DateTime? limitePagamento { get; set; }
        public decimal valor { get; set; }
        public BoletoPagador pagador { get; set; }
        public List<string> mensagens { get; set; }
        public bool postalService { get; set; }

        public decimal descontoValor { get; set; }
        public short descontoDias { get; set; }
        public byte descontoTipo { get; set; }

        public short multaDias { get; set; }
        public byte multaTipo { get; set; }
        public decimal multaValor { get; set; }

        public short jurosDias { get; set; }
        public byte jurosTipo { get; set; }
        public decimal jurosValor { get; set; }


    }
}
