using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Asaas
{
    public class ErrorsResult
    {
        public ErrorsResult()
        {
            errors = new List<ErrorsMessageResult>();
        }

        public List<ErrorsMessageResult> errors { get; set; }
    }

    public class ErrorsMessageResult
    {
        public string code { get; set; }
        public string description { get; set; }
    }
}

