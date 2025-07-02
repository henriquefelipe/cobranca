using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Zoop
{
    public class Transacao
    {
        public string payment_type { get; set; } = "bolepix";

        /// <summary>
        /// Identificador do seller responsável pela venda.
        /// </summary>
        public string on_behalf_of { get; set; }
        public string description { get; set; }
        public string currency { get; set; }
        public int amount { get; set; }
        public string customer { get; set; }
        public string reference_id { get; set; }
        public TransacaoPaymentMethod payment_method { get; set; }
    }

    public class TransacaoPaymentMethod
    {
        /// <summary>
        /// Data de vencimento no formato AAAA-MM-DD"
        /// </summary>
        public string due_at { get; set; }

        /// <summary>
        /// Data limite para pagamento no formato AAAA-MM-DD"
        /// </summary>
        public string payment_limit_at { get; set; }

        public List<TransacaoPaymentMethodBillitMessageList> billing_message_list { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TransacaoPaymentMethodInterest interest { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TransacaoPaymentMethodLateFee late_fee { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TransacaoPaymentMethodDiscount discount { get; set; }
    }

    public class TransacaoPaymentMethodBillitMessageList
    {
        public string message { get; set; }
    }

    public class TransacaoPaymentMethodInterest
    {
        /// <summary>
        /// Configurações do tipo de juro, se percentual ou valor fixo. Enviar na requisição o valor “PERCENTAGE” ou “FIXED”
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        /// Configuração da frequência em que o juro será cobrado, diário, mensal e anual. Enviar os valores “DAILY” ou “MONTHLY” or ANNUALLY
        /// </summary>
        public string frequency { get; set; }

        /// <summary>
        /// Caso seja porcentagem, enviar neste campo a porcentagem de juro a ser cobrada. Caso seja valor fixo, enviar neste campo o valor a ser cobrado de juros.
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Data para o início da cobrança do juro no formato AAAA-MM-DD
        /// </summary>
        public string start_at { get; set; }
    }

    public class TransacaoPaymentMethodLateFee
    {
        /// <summary>
        /// Configurações do tipo de multa, se percentual ou valor fixo. Enviar na requisição o valor “PERCENTAGE” ou “FIXED”
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        /// Caso seja porcentagem, enviar neste campo a porcentagem de multa a ser cobrada. Caso seja valor fixo, enviar neste campo o valor a ser cobrado de multa
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Data para o início da cobrança da multa no formato AAAA-MM-DD
        /// </summary>
        public string start_at { get; set; }
    }

    public class TransacaoPaymentMethodDiscount
    {
        /// <summary>
        /// Configurações do tipo de multa, se percentual ou valor fixo. Enviar na requisição o valor “PERCENTAGE” ou “FIXED”
        /// </summary>
        public string mode { get; set; }

        /// <summary>
        /// Caso seja porcentagem, enviar neste campo a porcentagem de multa a ser cobrada. Caso seja valor fixo, enviar neste campo o valor a ser cobrado de multa
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// Data limite para ser aplicado o desconto no formato AAAA-MM-DD
        /// </summary>
        public string limit_at { get; set; }
    }
}
