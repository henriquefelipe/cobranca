using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Asaas
{
    public class CustomerResult
    {
        public CustomerResult()
        {
            data = new List<Customer>();
        }

        public bool hasMore { get; set; }
        public int totalCount { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public List<Customer> data { get; set; }
    }
}
