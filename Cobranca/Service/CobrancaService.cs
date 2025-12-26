using Cobranca.Domain;
using Cobranca.Domain.Boleto;
using Cobranca.Domain.Inter;
using Cobranca.Domain.Itau;
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

        public GenericResult<Usuario> Autenticar()
        {
            var result = new GenericResult<Usuario>();
            if (this.credenciais.operadora == Enum.Operadora.BancoInter)
            {
                var inter = new Inter(credenciais);
                return inter.Token();
            }
            else if (this.credenciais.operadora == Enum.Operadora.Itau)
            {
                var inter = new Itau(credenciais);
                return inter.Token();
            }

            return result;
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
                if (asaasResult.Success)
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
            else if (this.credenciais.operadora == Enum.Operadora.Zoop)
            {
                var zoop = new Zoop(credenciais);

                if (string.IsNullOrEmpty(boleto.pagador.codigo))
                {
                    var resultadoComprador = zoop.CompradorPorCpfCnpj(boleto.pagador.cnpjcpf);
                    if (resultadoComprador.Success)
                    {
                        boleto.pagador.codigo = resultadoComprador.Result.id;                       
                    }
                    else
                    {
                        var resultadoCompradorCriando = zoop.Comprador(boleto.pagador);
                        if (resultadoCompradorCriando.Success)
                        {
                            boleto.pagador.codigo = resultadoCompradorCriando.Result.id;
                        }
                        else
                        {
                            result.Message = resultadoComprador.Message;
                            return result;
                        }
                    }
                }

                var resultBoleto = zoop.Boleto(boleto);
                if (resultBoleto.Success)
                {                    
                    result.Result = new RecebimentoResult
                    {
                        Chave = resultBoleto.Result.id,
                        CopiaECola = resultBoleto.Result.payment_method.emv,                        
                        NossoNumero = resultBoleto.Result.payment_method.digitable_line,
                        LinhaDigitavel = resultBoleto.Result.payment_method.digitable_line,
                        Base64 = resultBoleto.Result.payment_method.base64,
                        CodigoBarras = resultBoleto.Result.payment_method.barcode,                        
                    };

                    result.Success = true;
                }
                else
                {
                    result.Message = resultBoleto.Message;
                    return result;
                }
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
            else if (this.credenciais.operadora == Enum.Operadora.Zoop)
            {
                var zoop = new Zoop(credenciais);
                var resultado = zoop.Comprador(pagador);
                if (resultado.Success)
                {
                    result.Success = true;
                    result.Result.codigo = resultado.Result.id;
                }
                else
                    result.Message = resultado.Message;
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
            else if (this.credenciais.operadora == Enum.Operadora.Zoop)
            {
                var zoop = new Zoop(credenciais);
                var resultado = zoop.CompradorPorCpfCnpj(cpfcnpj);
                if (resultado.Success)
                {
                    var cliente = new BoletoPagadorRetorno
                    {
                        codigo = resultado.Result.id
                    };
                    result.Result.Add(cliente);
                    result.Success = true;
                }
                else
                {
                    result.Message = resultado.Message;
                }
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

                        var valorOriginal = item.value;
                        if (item.originalValue != null && item.originalValue > 0)
                            valorOriginal = item.originalValue.Value;

                        result.Result.Add(new BoletoPagadorRetorno
                        {
                            clienteChave = item.customer,
                            dataPagamento = Convert.ToDateTime(item.clientPaymentDate),
                            dataVencimento = Convert.ToDateTime(item.dueDate),
                            dataRecebimento = Convert.ToDateTime(item.confirmedDate),
                            dataEmissao = Convert.ToDateTime(item.dateCreated),
                            id = item.id,
                            invoiceUrl = item.invoiceUrl,
                            pdfUrl = item.bankSlipUrl,
                            valor = valorOriginal,
                            valor_taxa = item.value - item.netValue,
                            valor_acrescimo = item.interestValue ?? 0,
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

        public GenericResult<PagamentoPixResult> PagamentoPix(PagamentoPix pagamentoPix)
        {
            var result = new GenericResult<PagamentoPixResult>();
            result.Result = new PagamentoPixResult();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                result.Message = "PIX não implementado para o asaas";
            }
            else if (this.credenciais.operadora == Enum.Operadora.BancoInter)
            {
                var identificador = pagamentoPix.Identificador;
                if (string.IsNullOrEmpty(identificador))
                {
                    identificador = Guid.NewGuid().ToString();
                }

                var service = new Inter(this.credenciais);
                if (string.IsNullOrEmpty(credenciais.token))
                {
                    var resultToken = service.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }
                }

                if (pagamentoPix.Valor == 0)
                {
                    result.Message = "Valor não pode ser igual a zero";
                    return result;
                }

                var pagamento = new InterPixPagamento()
                {
                    destinatario = new InterDestinatario
                    {
                        tipo = "CHAVE",
                        chave = pagamentoPix.Chave
                    },
                    valor = pagamentoPix.Valor,
                };

                var resultPagamento = service.PagamentoPix(identificador, pagamento);
                if (!resultPagamento.Success)
                {
                    result.Message = "Pix: " + resultPagamento.Message;
                    return result;
                }

                result.Result.Identificador = resultPagamento.Result.codigoSolicitacao;
                result.Result.Status = resultPagamento.Result.tipoRetorno;
                result.JSON = resultPagamento.JSON;
                result.Success = true;
            }
            else if (this.credenciais.operadora == Enum.Operadora.Itau)
            {
                var identificador = pagamentoPix.Identificador;
                if (string.IsNullOrEmpty(identificador))
                {
                    identificador = Guid.NewGuid().ToString();
                }

                var service = new Itau(this.credenciais);
                if (string.IsNullOrEmpty(credenciais.token))
                {
                    var resultToken = service.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }
                }

                if (pagamentoPix.Valor == 0)
                {
                    result.Message = "Valor não pode ser igual a zero";
                    return result;
                }

                var pagador = new ItauPagador();
                pagador.agencia = credenciais.agencia;
                pagador.conta = credenciais.conta;
                pagador.documento = credenciais.cnpjcpf;

                var pagamento = new ItauPixPagamento()
                {
                    chave = pagamentoPix.Chave,
                    valor_pagamento = pagamentoPix.Valor,
                    data_pagamento = pagamentoPix.DataPagamento == null ? DateTime.Now.ToString("yyyy-MM-dd") : pagamentoPix.DataPagamento.Value.ToString("yyyy-MM-dd"),
                    identificacao_comprovante = identificador,
                    informacoes_entre_usuarios = "Pagamento via API",
                    referencia_empresa = "REF-" + pagamentoPix.IdentificadorPequeno,
                    pagador = pagador
                };

                var resultPagamento = service.PagamentoPix(pagamento);
                if (!resultPagamento.Success)
                {
                    result.Message = "Pix: " + resultPagamento.Message;
                    return result;
                }

                result.Result.Identificador = resultPagamento.Result.cod_pagamento;
                result.Result.Status = resultPagamento.Result.status_pagamento;
                result.JSON = resultPagamento.JSON;
                result.Success = true;
            }
           

            return result;
        }

        public GenericResult<ConsultaPagamentoPixResult> ConsultaPagamentoPix(ConsultaPagamentoPix consultaPagamentoPix)
        {
            var result = new GenericResult<ConsultaPagamentoPixResult>();
            result.Result = new ConsultaPagamentoPixResult();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                result.Message = "PIX não implementado para o asaas";
            }
            else if (this.credenciais.operadora == Enum.Operadora.BancoInter)
            {
                var service = new Inter(this.credenciais);
                if (string.IsNullOrEmpty(credenciais.token))
                {
                    var resultToken = service.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }
                }

                var resultConsultaPagamento = service.ConsultaPagamentoPix(consultaPagamentoPix.Identificador);
                if (!resultConsultaPagamento.Success)
                {
                    result.Message = "Pix: " + resultConsultaPagamento.Message;
                    return result;
                }

                //result.Result.Status = resultConsultaPagamento.Result.;
                //result.Result.Status = resultConsultaPagamento.Result.tipoRetorno;
                result.JSON = resultConsultaPagamento.JSON;
                result.Success = true;
            }
            else if (this.credenciais.operadora == Enum.Operadora.Itau)
            {
                var service = new Itau(this.credenciais);
                if (string.IsNullOrEmpty(credenciais.token))
                {
                    var resultToken = service.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }
                }

                var resultConsultaPagamento = service.ConsultaPagamentoPix(consultaPagamentoPix.Identificador);
                if (!resultConsultaPagamento.Success)
                {
                    result.Message = "Pix: " + resultConsultaPagamento.Message;
                    return result;
                }
                
                result.Result.Status = resultConsultaPagamento.Result.data.dados_pagamento.status;
                result.JSON = resultConsultaPagamento.JSON;
                result.Success = true;
            }

            return result;
        }

        public GenericResult<List<ConsultaPagamentoPixResult>> ConsultaPagamentosPix(ConsultaPagamentoPix consultaPagamentoPix)
        {
            var result = new GenericResult<List<ConsultaPagamentoPixResult>>();
            result.Result = new List<ConsultaPagamentoPixResult>();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                result.Message = "PIX não implementado para o asaas";
            }
            else if (this.credenciais.operadora == Enum.Operadora.BancoInter)
            {
                //var service = new Inter(this.credenciais);
                //if (string.IsNullOrEmpty(credenciais.token))
                //{
                //    var resultToken = service.Token();
                //    if (!resultToken.Success)
                //    {
                //        result.Message = "Token: " + resultToken.Message;
                //        return result;
                //    }
                //}

                //var resultConsultaPagamento = service.ConsultaPagamentoPix(consultaPagamentoPix.Identificador);
                //if (!resultConsultaPagamento.Success)
                //{
                //    result.Message = "Pix: " + resultConsultaPagamento.Message;
                //    return result;
                //}

                //result.Result.Status = resultConsultaPagamento.Result.;
                //result.Result.Status = resultConsultaPagamento.Result.tipoRetorno;
                //result.JSON = resultConsultaPagamento.JSON;
                result.Success = true;
            }
            else if (this.credenciais.operadora == Enum.Operadora.Itau)
            {
                var service = new Itau(this.credenciais);
                if (string.IsNullOrEmpty(credenciais.token))
                {
                    var resultToken = service.Token();
                    if (!resultToken.Success)
                    {
                        result.Message = "Token: " + resultToken.Message;
                        return result;
                    }
                }

                if (consultaPagamentoPix.Inicio == null || consultaPagamentoPix.Fim == null)
                {
                    consultaPagamentoPix.Inicio = DateTime.Now;
                    consultaPagamentoPix.Fim = DateTime.Now;
                }

                var resultConsultaPagamento = service.ConsultaPagamentosPix(consultaPagamentoPix.Inicio.Value, consultaPagamentoPix.Fim.Value);
                if (!resultConsultaPagamento.Success)
                {
                    result.Message = "Pix: " + resultConsultaPagamento.Message;
                    return result;
                }

                result.Result = resultConsultaPagamento.Result.data.itens.Select(p => new ConsultaPagamentoPixResult
                {
                    IdentificadorPagamento = p.id_pagamento,
                    Status = p.status
                }).ToList();

                result.JSON = resultConsultaPagamento.JSON;
                result.Success = true;
            }

            return result;
        }
        #endregion

        #region Clientes

        public GenericResult<List<BoletoPagadorRetorno>> BuscarClienteTodos(int offset = 0, int limit = 100)
        {
            var result = new GenericResult<List<BoletoPagadorRetorno>>();
            result.Result = new List<BoletoPagadorRetorno>();

            if (this.credenciais.operadora == Enum.Operadora.Asaas)
            {
                var asaas = new Asaas(credenciais);
                var resultado = asaas.CustomerAll(offset, limit);
                if (resultado.Success)
                {

                    result.Success = true;
                }
                else
                {
                    result.Message = resultado.Message;
                }
            }
            else if (this.credenciais.operadora == Enum.Operadora.GerenciaNet)
            {
                result.Message = "Metodo não implementado para o gerencianet";
            }
            else if (this.credenciais.operadora == Enum.Operadora.BancoInter)
            {
                result.Message = "Metodo não implementado para o banco inter";
            }
            else if (this.credenciais.operadora == Enum.Operadora.Zoop)
            {
                result.Message = "Metodo não implementado para o zoop";
            }

            return result;
        }

        #endregion
    }
}
