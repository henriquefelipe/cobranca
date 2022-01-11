using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Boleto
{
    public class BoletoPagador
    {
        public byte tipoPessoa { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cnpjcpf { get; set; }
        public string telefone { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string observacao { get; set; }
    }
}
