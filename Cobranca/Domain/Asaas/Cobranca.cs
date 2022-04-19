using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Asaas
{
    public class Cobranca
    {
        [JsonProperty("object")]
        public string objecto { get; set; }
        public string id { get; set; }
        public string dateCreated { get; set; }
        public string customer { get; set; }
        public string paymentLink { get; set; }
        public decimal value { get; set; }
        public decimal netValue { get; set; }
        public decimal? originalValue { get; set; }
        public decimal? interestValue { get; set; }
        public string description { get; set; }
        public string billingType { get; set; }
        public string status { get; set; }
        public string dueDate { get; set; }
        public string originalDueDate { get; set; }
        public string confirmedDate { get; set; }
        public string paymentDate { get; set; }
        public string clientPaymentDate { get; set; }
        public string invoiceUrl { get; set; }
        public string invoiceNumber { get; set; }
        public string externalReference { get; set; }
        public bool deleted { get; set; }
        public bool anticipated { get; set; }
        public string creditDate { get; set; }
        public string estimatedCreditDate { get; set; }
        public string transactionReceiptUrl { get; set; }
        public string bankSlipUrl { get; set; }
        public string lastInvoiceViewedDate { get; set; }
        public string lastBankSlipViewedDate { get; set; }
        public Cobranca_discount discount { get; set; }
        public Cobranca_fine fine { get; set; }
        public Cobranca_interest interest { get; set; }
        public bool postalService { get; set; }
        public string nossoNumero { get; set; }
    }

    public class Cobranca_discount
    {
        public decimal value { get; set; }
        public string limitDate { get; set; }
        public int dueDateLimitDays { get; set; }

        public string type { get; set; }
    }

    public class Cobranca_fine
    {
        public decimal value { get; set; }
        public string type { get; set; }
    }

    public class Cobranca_interest
    {
        public decimal value { get; set; }
        public string type { get; set; }
    }

}
