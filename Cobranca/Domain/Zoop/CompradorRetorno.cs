using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Zoop
{
    public class CompradorRetorno : Comprador
    {
        public string id { get; set; }
        public string status { get; set; }
        public string resource { get; set; }
        public decimal account_balance { get; set; }
        public decimal current_balance { get; set; }
        public string description { get; set; }
    }
}
