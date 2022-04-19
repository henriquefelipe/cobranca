using Cobranca.Domain;
using Cobranca.Domain.Boleto;
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

        #region Boleto
        public GenericResult<RecebimentoResult> CobrarBoleto(Boleto boleto)
        {
            var result = new GenericResult<RecebimentoResult>();
            result.Result = new RecebimentoResult();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                var asaas = new Asaas(credenciais);
                var asaasResult = asaas.Payments(boleto);
                if(asaasResult.Success)
                {
                    result.Result = new RecebimentoResult
                    {
                        Chave = asaasResult.Result.id,
                        UrlLink = asaasResult.Result.invoiceUrl,
                        UrlBoleto = asaasResult.Result.bankSlipUrl,
                        NossoNumero = asaasResult.Result.nossoNumero,
                        Numero = asaasResult.Result.invoiceNumber
                    };
                    result.Success = true;
                }
                else
                {
                    result.Message = asaasResult.Message;
                }
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                result.Message = "Boleto não implementado para o gerencianet";
            }

            return result;
        }

        public GenericResult<BoletoPagadorRetorno> CobrarBoletoCadastrarCliente(BoletoPagador pagador)
        {
            var result = new GenericResult<BoletoPagadorRetorno>();
            result.Result = new BoletoPagadorRetorno();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                var asaas = new Asaas(credenciais);
                var resultado = asaas.Customers(pagador);
                if (resultado.Success)
                {
                    result.Success = true;
                    result.Result.codigo = resultado.Result.id;
                }
                else
                    result.Message = resultado.Message;
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                result.Message = "Boleto não implementado para o gerencianet";
            }

            return result;
        }

        public GenericResult<List<BoletoPagadorRetorno>> CobrarBoletoBuscarCliente(string cpfcnpj)
        {
            var result = new GenericResult<List<BoletoPagadorRetorno>>();
            result.Result = new List<BoletoPagadorRetorno>();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                var asaas = new Asaas(credenciais);
                var resultado = asaas.CustomersByCpfCnpj(cpfcnpj);
                if (resultado.Success)
                {
                    foreach (var item in resultado.Result)
                    {
                        var cliente = new BoletoPagadorRetorno
                        { 
                            codigo = item.id
                        };
                        result.Result.Add(cliente);
                    }
                    result.Success = true;
                }
                else
                {
                    result.Message = resultado.Message;
                }
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                result.Message = "Boleto não implementado para o gerencianet";
            }

            return result;
        }

        public GenericResult<List<BoletoPagadorRetorno>> CobrarBoletoListar(string parametros, bool trazarInformacoesCliente = false)
        {
            var result = new GenericResult<List<BoletoPagadorRetorno>>();
            result.Result = new List<BoletoPagadorRetorno>();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                var asaas = new Asaas(credenciais);
                var resultado = asaas.PaymentsFilters(parametros);
                if (resultado.Success)
                {                    
                    foreach (var item in resultado.Result.data)
                    {
                        string clienteNome = "";
                        string clienteDocumento = "";
                        if (trazarInformacoesCliente)
                        {
                            var resultCustomer = asaas.CustomerById(item.customer);
                            if (resultCustomer.Success)
                            {
                                clienteNome = resultCustomer.Result.name;
                                clienteDocumento = resultCustomer.Result.cpfCnpj;
                            }
                        }

                        result.Result.Add(new BoletoPagadorRetorno
                        {
                            clienteChave = item.customer,
                            dataPagamento = Convert.ToDateTime(item.clientPaymentDate),
                            dataVencimento = Convert.ToDateTime(item.dueDate),
                            dataRecebimento = Convert.ToDateTime(item.confirmedDate),
                            id = item.id,
                            invoiceUrl = item.invoiceUrl,
                            pdfUrl = item.bankSlipUrl,
                            valor = item.value,
                            valor_taxa = item.value - item.netValue, 
                            valor_liquido = item.netValue,
                            descricao = item.description,
                            status = item.status,
                            clienteNome = clienteNome,
                            clienteDocumento = clienteDocumento
                        });
                    }
                    result.Success = true;
                }
                else
                {
                    result.Message = resultado.Message;
                }
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                result.Message = "Boleto não implementado para o gerencianet";
            }

            return result;
        }


        #endregion

        #region PIX
        public GenericResult<RecebimentoResult> CobrarPix(Recebimento cobranca)
        {
            var result = new GenericResult<RecebimentoResult>();
            result.Result = new RecebimentoResult();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                result.Message = "PIX não implementado para o asaas";
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
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

                result.Result.JSON = resultCob.Result.json;

                var resultLoc = gerenciaNet.PixLoc(resultToken.Result.access_token, resultCob.Result);
                if (!resultCob.Success)
                {
                    result.Message = "Loc: " + resultCob.Message;
                    return result;
                }

                result.Result.JSON += resultLoc.Result.json;

                result.Result.Chave = cobranca.Id;
                result.Result.ImagemQrCode = resultLoc.Result.imagemQrcode;
                result.Result.QrCode = resultLoc.Result.qrcode;
                result.Success = true;
            }

            
            return result;
        }

        public GenericResult<RecebimentoStatusResult> StatusPix(string idCob)
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

                result.Result.JSON = resultStatus.Result.json;

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

        public GenericResult<DevolucaoResult> DevolucaoPix(string idCob, string idStatusEnd, decimal valor)
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

                result.Result.JSON = resultDevolucao.Result.json;

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

        #endregion
    }
}
