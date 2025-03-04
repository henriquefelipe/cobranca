﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class Pagamento
    {
        public calendario calendario { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public devedor devedor { get; set; }
        public valor valor { get; set; }
        public string chave { get; set; }
        public string solicitacaoPagador { get; set; }
    }
    
    public class calendario
    {
        public int expiracao { get; set; }
    }

    public class devedor
    {
        public string cpf { get; set; }
        public string nome { get; set; }
    }

    public class valor
    {
        public string original { get; set; }
    }
}
