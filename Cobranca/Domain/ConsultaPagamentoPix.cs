using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class ConsultaPagamentoPix
    {
        public string Identificador { get; set; }

        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
    }
}
