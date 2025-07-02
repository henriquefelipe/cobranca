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
        public string UrlLink { get; set; }
        public string UrlBoleto { get; set; }
        public string NossoNumero { get; set; }
        public string Numero { get; set; }
        public string CodigoBarras { get; set; }
        public string LinhaDigitavel { get; set; }
        public string Base64 { get; set; }
        public string CopiaECola { get; set; }
    }
}
