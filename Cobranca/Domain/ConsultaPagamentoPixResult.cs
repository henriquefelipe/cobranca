using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class ConsultaPagamentoPixResult
    {
        public string Status { get; set; }
        public string IdentificadorPagamento { get; set; }
    }    
}
