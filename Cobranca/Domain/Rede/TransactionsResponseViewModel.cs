using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Rede
{
    internal class TransactionsResponseViewModel
    {
        public ContentViewModel Content { get; set; }
        public CursorViewModel Cursor { get; set; }
    }

    public class ContentViewModel
    {
        public List<TransactionViewModel> Transactions { get; set; }
    }

    public class TransactionViewModel
    {
        public string Status { get; set; }
        public int CaptureTypeCode { get; set; }
        public decimal FlexAmount { get; set; }
        public long Nsu { get; set; }
        public string DeviceType { get; set; }
        public decimal FeeTotal { get; set; }
        public long SaleSummaryNumber { get; set; }
        public string SaleHour { get; set; }
        public string CaptureType { get; set; }
        public string Tid { get; set; }
        public decimal MdrAmount { get; set; }
        public int InstallmentQuantity { get; set; }
        public string Ard { get; set; }
        public decimal FlexFee { get; set; }
        public string Device { get; set; }
        public decimal MdrFee { get; set; }
        public decimal NetAmount { get; set; }
        public bool Flex { get; set; }
        public int AuthorizationCode { get; set; }
        public decimal BoardingFeeAmount { get; set; }
        public string CardNumber { get; set; }
        public DateTime MovementDate { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool Tokenized { get; set; }
        public DateTime SaleDate { get; set; }
        public int BrandCode { get; set; }
        public string OrderNumber { get; set; }
        public string StrAuthorizationCode { get; set; }

        public List<TrackingViewModel> Tracking { get; set; }
        public MerchantViewModel Merchant { get; set; }
        public ModalityViewModel Modality { get; set; }
    }

    public class TrackingViewModel
    {
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }

    public class MerchantViewModel
    {
        public string CompanyNumber { get; set; }
        public string CompanyName { get; set; }
        public string DocumentNumber { get; set; }
        public string TradeName { get; set; }
    }

    public class ModalityViewModel
    {
        public string Type { get; set; }
        public int Code { get; set; }
        public string Product { get; set; }
        public int ProductCode { get; set; }
    }

    public class CursorViewModel
    {
        public bool HasNextKey { get; set; }
    }

}
