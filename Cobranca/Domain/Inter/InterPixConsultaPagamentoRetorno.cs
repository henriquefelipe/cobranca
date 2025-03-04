using System.Collections.Generic;

namespace Cobranca.Domain.Inter
{
    public class InterPixConsultaPagamentoRetorno
    {
        public InterPixConsultaPagamentoRetorno()
        {
            historico = new List<InterPixConsultaPagamentoHistoricoRetorno>();
        }

        public InterPixConsultaPagamentoPixRetorno transacaoPix { get; set; }
        public List<InterPixConsultaPagamentoHistoricoRetorno> historico { get; set; }
    }

    public class InterPixConsultaPagamentoPixRetorno
    {
        public string contaCorrente { get; set; }
        public InterPixConsultaPagamentoPixRecebedorRetorno recebedor { get; set; }

        //public List<PixConsultaPagamentoPixErroRetorno> erros { get; set; }
        public string endToEnd { get; set; }
        public decimal valor { get; set; }
        public string status { get; set; }
        public string dataHoraMovimento { get; set; }
        public string dataHoraSolicitacao { get; set; }
        public string chave { get; set; }
        public string codigoSolicitacao { get; set; }
    }

    public class InterPixConsultaPagamentoPixRecebedorRetorno
    {
        public string cpfCnpj { get; set; }
        public string nome { get; set; }
    }

    public class InterPixConsultaPagamentoPixErroRetorno
    {

    }

    public class InterPixConsultaPagamentoHistoricoRetorno
    {
        public string status { get; set; }
        public string dataHoraEvento { get; set; }

    }
}
