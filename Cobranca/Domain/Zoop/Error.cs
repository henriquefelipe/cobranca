using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Zoop
{
    public class ErrorResult
    {
        public ErrorEResult error { get; set; }        
    }

    public class ErrorEResult
    {
        public string status { get; set; }
        public int status_code { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string message { get; set; }
    }
}
