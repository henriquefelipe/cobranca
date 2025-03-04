using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class PagamentoPix
    {
        public string Identificador { get; set; }
        public decimal Valor {  get; set; }
        public string Chave { get; set; }
    }
}
