using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Rede
{
    public class ReceivablesResponseViewModel
    {
        public ReceivablesContentViewModel Content { get; set; }
    }

    public class ReceivablesContentViewModel
    {
        public List<ReceivableViewModel> Receivables { get; set; }
    }

    public class ReceivableViewModel
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CompanyNumber { get; set; }
        public string Type { get; set; }
        public string CompanyName { get; set; }
    }

}
