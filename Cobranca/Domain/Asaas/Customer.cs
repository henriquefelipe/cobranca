using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Asaas
{
    public class Customer
    {
        public string id { get; set; }
        public DateTime dateCreated { get; set; }
        public string codigo { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string mobilePhone { get; set; }
        public string cpfCnpj { get; set; }
        public string postalCode { get; set; }
        public string address { get; set; }
        public string addressNumber { get; set; }
        public string complement { get; set; }
        public string province { get; set; }
        public string externalReference { get; set; }
        public bool notificationDisabled { get; set; }
        public string additionalEmails { get; set; }
        public string municipalInscription { get; set; }
        public string stateInscription { get; set; }
        public string observations { get; set; }
        public string personType { get; set; } // "FISICA"
    }
}
