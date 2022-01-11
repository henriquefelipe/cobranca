using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class QrCodeResponse
    {
        public string qrcode { get; set; }
        public string imagemQrcode { get; set; }
        public string json { get; set; }
    }
}
