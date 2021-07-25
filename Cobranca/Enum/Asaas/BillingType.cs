using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDigital.Enum.Asaas
{
    public class BillingType
    {
        public const string BOLETO = "BOLETO"; // Boleto Bancário
        public const string CREDIT_CARD = "CREDIT_CARD"; // Cartão de Crédito
        public const string UNDEFINED = "UNDEFINED"; // Perguntar ao Cliente
    }
}
