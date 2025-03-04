using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain.Inter
{
    public class InterRetornoErro
    {
        public string title { get; set; }
        public string detail { get; set; }
        public string timestamp { get; set; }
        public InterRetornoErroViolacoes violacoes { get; set; }
    }

    public class  InterRetornoErroViolacoes
    {
        public string razao { get; set; }
        public string propriedade { get; set; }
        public string valor { get; set; }
    }
}
