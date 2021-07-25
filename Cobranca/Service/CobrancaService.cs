using Cobranca.Domain;
using Cobranca.Enum;
using Cobranca.Operadora;
using Cobranca.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Service
{
    public class CobrancaService
    {
        private Credenciais credenciais;

        public CobrancaService(Credenciais credenciais)
        {
            this.credenciais = credenciais;
        }

        public GenericResult<RecebimentoResult> Cobrar(Recebimento cobranca)
        {
            var result = new GenericResult<RecebimentoResult>();
            result.Result = new RecebimentoResult();

            if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                if (this.credenciais.tipo == Enum.Tipo.Boleto)
                {
                    throw new ArgumentException("Boleto não implementado");
                }
                else if (this.credenciais.tipo == Enum.Tipo.PIX)
                {
                    var gerenciaNet = new GerenciaNet(this.credenciais);
                    var resultToken = gerenciaNet.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }

                    if (string.IsNullOrEmpty(cobranca.Id))
                    {
                        cobranca.Id = Guid.NewGuid().ToString("N");
                    }

                    var pagamento = new Pagamento()
                    {
                        calendario = new calendario
                        {
                            expiracao = 3600
                        },
                        valor = new valor
                        {
                            original = Util.GetValorFormatado(cobranca.Valor)
                        },
                        chave = this.credenciais.chave,
                        solicitacaoPagador = cobranca.SolicitacaoPagador
                    };

                    if (!string.IsNullOrEmpty(cobranca.DevedorCpf) && !string.IsNullOrEmpty(cobranca.DevedorNome))
                    {
                        pagamento.devedor = new devedor
                        {
                            cpf = cobranca.DevedorCpf,
                            nome = cobranca.DevedorNome
                        };
                    }

                    var resultCob = gerenciaNet.PixCob(resultToken.Result.access_token, pagamento, cobranca.Id);
                    if (!resultCob.Success)
                    {
                        result.Message = "Cob: " + resultCob.Message;
                        return result;
                    }

                    var resultLoc = gerenciaNet.PixLoc(resultToken.Result.access_token, resultCob.Result);
                    if (!resultCob.Success)
                    {
                        result.Message = "Loc: " + resultCob.Message;
                        return result;
                    }

                    result.Result.Chave = cobranca.Id;
                    result.Result.ImagemQrCode = resultLoc.Result.imagemQrcode;
                    result.Result.QrCode = resultLoc.Result.qrcode;
                    result.Success = true;
                }
            }

            return result;
        }

        public GenericResult<RecebimentoStatusResult> Status(string idCob)
        {
            var result = new GenericResult<RecebimentoStatusResult>();
            result.Result = new RecebimentoStatusResult();

            if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                var gerenciaNet = new GerenciaNet(this.credenciais);
                var resultToken = gerenciaNet.Token();
                if (!resultToken.Success)
                {
                    result.Message = "Token: " + resultToken.Message;
                    return result;
                }

                var resultStatus = gerenciaNet.PixCobStatus(resultToken.Result.access_token, idCob);
                if (!resultStatus.Success)
                {
                    result.Message = "CobStatus: " + resultToken.Message;
                    return result;
                }


                if (resultStatus.Result.status == GerenciaNetStatus.CONCLUIDA)
                {
                    var pix = resultStatus.Result.pix.FirstOrDefault();
                    if (pix != null)
                    {
                        result.Result.Chave = pix.endToEndId;
                        result.Success = true;
                    }
                    else
                    {
                        result.Message = "CobStatus: Não encontrado o pix";
                        return result;
                    }
                }
                else
                {
                    result.Message = "CobStatus: " + resultStatus.Result.status;
                    return result;
                }
            }

            return result;
        }

        public GenericResult<DevolucaoResult> Devolucao(string idCob, string idStatusEnd, decimal valor)
        {
            var result = new GenericResult<DevolucaoResult>();
            result.Result = new DevolucaoResult();

            if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                var gerenciaNet = new GerenciaNet(this.credenciais);
                var resultToken = gerenciaNet.Token();
                if (!resultToken.Success)
                {
                    result.Message = "Token: " + resultToken.Message;
                    return result;
                }

                var resultDevolucao = gerenciaNet.PixDevolucao(resultToken.Result.access_token, idCob, idStatusEnd, valor);
                if (!resultDevolucao.Success)
                {
                    result.Message = "Devolução: " + resultToken.Message;
                    return result;
                }

                if (resultDevolucao.Result.status == GerenciaNetStatus.EM_PROCESSAMENTO)
                {
                    result.Result.Chave = resultDevolucao.Result.rtrId;
                    result.Success = true;
                }
                else
                {
                    result.Message = "Devolução: " + resultDevolucao.Result.status;
                    return result;
                }
            }

            return result;
        }
    }
}
