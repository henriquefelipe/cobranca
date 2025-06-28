using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Zoop
{
    public class Comprador
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }

        /// <summary>
        /// CPF/CNPJ do comprador
        /// </summary>
        public string taxpayer_id { get; set; }
        public string birthdate { get; set; }      
        
        public CompradorEndereco address { get; set; }
    }

    public class CompradorEndereco
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string line3 { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country_code { get; set; } = "BR";
    }
}
