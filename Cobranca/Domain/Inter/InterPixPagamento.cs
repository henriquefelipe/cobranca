using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Inter
{
    public class InterPixPagamento
    {
        public decimal valor { get; set; }
        public string descricao { get; set; }
        public InterDestinatario destinatario { get; set; }
    }
}
