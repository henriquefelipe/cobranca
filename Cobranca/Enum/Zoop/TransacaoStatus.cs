using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Enum.Zoop
{
    public class TransacaoStatus
    {
        public const string PENDING = "pending";
        public const string APPROVED = "approved";
        public const string REFUNDED = "refunded";
        public const string REFUND_PENDING = "refund_pending";
        public const string CANCELED = "cancelled";
        public const string SUCCEEDED = "succeeded";
    }
}
