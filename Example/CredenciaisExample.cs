using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class CredenciaisExample
    {
        public string InterClientId {  get; set; }
        public string InterClienteSecret { get; set; }
        public string InterCaminhoCertificado { get; set; }
        public string InterSenhaCertificado { get; set; }

        public string ItauClientId { get; set; }
        public string ItauClienteSecret { get; set; }
        public string ItauCaminhoCertificado { get; set; }
        public string ItauSenhaCertificado { get; set; }
        public string ItauAgencia { get; set; }
        public string ItauConta { get; set; }
        public string ItauDocumento { get; set; }

        public string ZoopToken { get; set; }
        public string ZoopMarketplaceId { get; set; }
        public string ZoopSellerId { get; set; }
    }
}
