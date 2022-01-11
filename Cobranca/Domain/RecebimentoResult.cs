using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class RecebimentoResult
    {
        public string Chave { get; set; }
        public string QrCode { get; set; }
        public string ImagemQrCode { get; set; }
        public string JSON { get; set; }
    }
}
