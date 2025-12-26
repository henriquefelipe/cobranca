using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Itau
{
    public  class ItauPagador
    {
        public ItauPagador()
        {
            tipo_conta = "C";
            tipo_pessoa = "J";  
            modulo_sispag = "Fornecedores";
        }

        public string tipo_conta { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string tipo_pessoa { get; set; }
        public string documento { get; set; }
        public string modulo_sispag { get; set; }
    }
}
