using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Asaas
{
    public class CobrancaResult
    {
        public CobrancaResult()
        {
            data = new List<Cobranca>();
        }

        public bool hasMore { get; set; }
        public int totalCount { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public List<Cobranca> data { get; set; }
    }
}
