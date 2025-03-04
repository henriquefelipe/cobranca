using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Utils
{
    public class GenericSimpleResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class GenericResult<TResult> : GenericSimpleResult
    {
        public TResult Result { get; set; }
        public string JSON { get; set; }
    }
}
