using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class Credenciais
    {
        public string token { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string caminhoCertificado { get; set; }
        public string senhaCertificado { get; set; }
        public string caminhoKey { get; set; }
        public string chave { get; set; }
        public Enum.Operadora operadora { get; set; }
        public Enum.Tipo tipo { get; set; }
        public bool isTest { get; set; }
        public string scope { get; set; }        
        public string seller_id { get; set; } // Identificador do seller responsável pela venda, usado para transações Zoop.
        public string agencia { get; set; }
        public string conta { get; set; }
        public string cnpjcpf { get; set; }
    }
}
