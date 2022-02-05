using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class Credenciais
    {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string caminhoCertificado { get; set; }
        public string chave { get; set; }
        public Enum.Operadora operadora { get; set; }
        public Enum.Tipo tipo { get; set; }
        public bool isTest { get; set; }
    }
}
