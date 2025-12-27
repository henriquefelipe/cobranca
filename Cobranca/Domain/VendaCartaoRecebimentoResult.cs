using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Domain
{
    public class VendaCartaoRecebimentoResult
    {
        public string Identificador { get; set; }
        public string Status { get; set; }
        public string NSU { get; set; }
        public string CodigoAutorizacao { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorTaxa { get; set; }
        public decimal ValorTaxaAntecipacao { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal PercentualTaxa { get; set; }
        public decimal PercentualTaxaAntecipacao { get; set; }
        public int NumeroParcelas { get; set; }
        public DateTime DataHora { get; set; }
        public string ModalidadeTipo { get; set; }
        public string CartaoNumero { get; set; }
        public string Bandeira { get; set; }
        public string BandeiraCodigo { get; set; }
        public string ProdutoCodigo { get; set; }
        public string ProdutoDescricao { get; set; }       
        public string CapturaTipo { get; set; }
    }
}
