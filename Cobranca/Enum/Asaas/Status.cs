using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Enum.Asaas
{
    public class Status
    {
        public const string PENDING = "PENDING"; //Aguardando pagamento
        public const string RECEIVED = "RECEIVED"; //Recebida (saldo já creditado na conta)
        public const string CONFIRMED = "CONFIRMED"; //Pagamento confirmado (saldo ainda não creditado)
        public const string OVERDUE = "OVERDUE"; //Vencida
        public const string REFUNDED = "REFUNDED"; //Estornada
        public const string RECEIVED_IN_CASH = "RECEIVED_IN_CASH"; //Recebida em dinheiro (não gera saldo na conta)
        public const string REFUND_REQUESTED = "REFUND_REQUESTED"; //Estorno Solicitado
        public const string CHARGEBACK_REQUESTED = "CHARGEBACK_REQUESTED"; //Recebido chargeback
        public const string CHARGEBACK_DISPUTE = "CHARGEBACK_DISPUTE"; //Em disputa de chargeback (caso sejam apresentados documentos para contestação)
        public const string AWAITING_CHARGEBACK_REVERSAL = "AWAITING_CHARGEBACK_REVERSAL"; //Disputa vencida, aguardando repasse da adquirente
        public const string DUNNING_REQUESTED = "DUNNING_REQUESTED"; //Em processo de recuperação
        public const string DUNNING_RECEIVED = "DUNNING_RECEIVED"; //Recuperada
        public const string AWAITING_RISK_ANALYSIS = "AWAITING_RISK_ANALYSIS";  // Pagamento em análise 
    }
}
