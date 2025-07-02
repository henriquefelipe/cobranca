using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Zoop
{
    public class TransacaoRetorno
    {
        public string id { get; set; }
        public string resource { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        public string original_amount { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
        public string payment_type { get; set; }
        public string transaction_number { get; set; }
        public string gateway_authorizer { get; set; }
        public object app_transaction_uid { get; set; }
        public object refunds { get; set; }
        public object rewards { get; set; }
        public object discounts { get; set; }
        public object pre_authorization { get; set; }
        public object sales_receipt { get; set; }
        public string on_behalf_of { get; set; }
        public object customer { get; set; }
        public string statement_descriptor { get; set; }
        public TransacaoRetornoPaymentMethodViewModel payment_method { get; set; }
        public object source { get; set; }
        public TransacaoRetornoPointOfSaleViewModel point_of_sale { get; set; }
        public object installment_plan { get; set; }
        public bool refunded { get; set; }
        public bool voided { get; set; }
        public bool captured { get; set; }
        public string fees { get; set; }
        public object fee_details { get; set; }
        public object location_latitude { get; set; }
        public object location_longitude { get; set; }
        public string uri { get; set; }        
        public DateTime expected_on { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object payment_authorization { get; set; }        
        public string json { get; set; }
    }

    public class TransacaoRetornoPaymentMethodViewModel
    {
        public string id { get; set; }
        public string provider { get; set; }
        public string version { get; set; }
        public string type { get; set; }
        public bool reusable { get; set; }
        public bool allow_update { get; set; }
        public string expiration_date { get; set; }
        public string document_number { get; set; }
        //public QeloPIXRetornoKeyViewModel key { get; set; }
        public string pix_link { get; set; }
        public string barcode { get; set; }
        public string digitable_line { get; set; }
        public string emv { get; set; }
        public string base64 { get; set; }
        public TransacaoRetornoQrCodeViewModel qr_code { get; set; }
    }

    public class TransacaoRetornoPointOfSaleViewModel
    {
        public string entry_mode { get; set; }
        public object identification_number { get; set; }
    }

    public class TransacaoRetornoQrCodeViewModel
    {
        public string emv { get; set; }
    }
}
