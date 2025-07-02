using Cobranca.Domain;
using Cobranca.Domain.Boleto;
using Cobranca.Domain.Zoop;
using Cobranca.Enum;
using Cobranca.Enum.Zoop;
using Cobranca.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Operadora
{
    public class Zoop
    {
        private const string URL_BASE = "https://api.zoop.ws/v1/marketplaces/";

        private Credenciais credenciais;

        public Zoop(Credenciais credenciais)
        {
            this.credenciais = credenciais;            
        }

        public GenericResult<BoletoPagadorRetorno> Comprador(BoletoPagador pagador)
        {
            var result = new GenericResult<BoletoPagadorRetorno>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.client_id))
                {
                    result.Message = "marketplace id não informado";
                    return result;
                }

                var address = new CompradorEndereco
                {
                    line1 = pagador.endereco,
                    line2 = pagador.complemento,
                    neighborhood = pagador.bairro,
                    city = pagador.cidade,
                    state = pagador.uf,
                    postal_code = pagador.cep,
                    country_code = "BR"
                };

                var dados = new Comprador
                {
                    first_name = pagador.nome,
                    email = pagador.email,
                    phone_number = pagador.telefone,
                    taxpayer_id = pagador.cnpjcpf,                    
                    address = address,                    
                };

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var json = JsonConvert.SerializeObject(dados);
                var client = new RestClient($"{URL_BASE}{credenciais.client_id}/buyers");
                var request = new RestRequest(Method.POST);

                request.AddHeader("accept", "application/json");
                request.AddHeader("content-Type", "application/json");
                request.AddHeader("authorization", "Basic " + credenciais.token);
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var customer = JsonConvert.DeserializeObject<CompradorRetorno>(responseContent);
                    result.Result = new BoletoPagadorRetorno();
                    result.Result.id = customer.id;
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Não autorizado, token inválido";
                }
                else
                {
                    if (!string.IsNullOrEmpty(responseContent))
                        result.Message = responseContent;
                    else
                    {
                        if (restResponse.ErrorException != null)
                            result.Message = restResponse.ErrorException.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<CompradorRetorno> CompradorPorCpfCnpj(string cpfcnpj)
        {
            var result = new GenericResult<CompradorRetorno>();
            result.Result = new CompradorRetorno();

            try
            {
                if (string.IsNullOrEmpty(this.credenciais.client_id))
                {
                    result.Message = "Marketplace id não informado";
                    return result;
                }

                var parametros = $"?taxpayer_id={cpfcnpj}";
                if(cpfcnpj.Length > 11)
                    parametros = $"?ein={cpfcnpj}";


                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                var client = new RestClient($"{URL_BASE}{credenciais.client_id}/buyers/search{parametros}");
                var request = new RestRequest(Method.GET);

                request.AddHeader("accept", "application/json");
                request.AddHeader("authorization", "Basic " + credenciais.token);
                request.AddHeader("Content-Type", "application/json");

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<CompradorRetorno>(responseContent);                    
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Não autorizado";
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    result.Message = "Não encontrado";
                }
                else
                {
                    if (!string.IsNullOrEmpty(responseContent))
                        result.Message = responseContent;
                    else
                    {
                        if (restResponse.ErrorException != null)
                            result.Message = restResponse.ErrorException.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<TransacaoRetorno> Boleto(Boleto boleto)
        {
            var result = new GenericResult<TransacaoRetorno>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.client_id))
                {
                    result.Message = "marketplace id não informado";
                    return result;
                }

                if (string.IsNullOrEmpty(this.credenciais.seller_id))
                {
                    result.Message = "marketplace id não informado";
                    return result;
                }

                var dados = new Transacao();                
                dados.on_behalf_of = this.credenciais.seller_id;
                dados.description = boleto.descricao;
                dados.currency = "BRL";
                dados.amount = (int)(boleto.valor * 100);
                dados.customer = boleto.pagador.codigo;
                dados.reference_id = boleto.externalReference;

                dados.payment_method = new TransacaoPaymentMethod();
                dados.payment_method.due_at = boleto.vencimento.ToString("yyyy-MM-dd");
                
                if(boleto.limitePagamento != null)
                {
                    dados.payment_method.payment_limit_at = boleto.limitePagamento.Value.ToString("yyyy-MM-dd");
                }

                dados.payment_method.billing_message_list = new List<TransacaoPaymentMethodBillitMessageList>();
                dados.payment_method.billing_message_list.AddRange(boleto.mensagens.Select(s => new TransacaoPaymentMethodBillitMessageList { message = s}));

                if(boleto.descontoValor > 0)
                {                    
                    dados.payment_method.discount = new TransacaoPaymentMethodDiscount
                    {
                        mode = boleto.descontoTipo == (byte)TipoValor.Porcentagem ? PaymenMethodMode.PERCENTAGE : PaymenMethodMode.FIXED,
                        value = ((int)(boleto.descontoValor * 100)).ToString(),
                        limit_at = boleto.emissao.AddDays(boleto.descontoDias).ToString("yyyy-MM-dd") 
                    };
                }

                if(boleto.multaValor > 0)
                {
                    dados.payment_method.late_fee = new TransacaoPaymentMethodLateFee
                    {
                        mode = boleto.multaTipo == (byte)TipoValor.Porcentagem ? PaymenMethodMode.PERCENTAGE : PaymenMethodMode.FIXED,
                        value = ((int)(boleto.multaValor * 100)).ToString(),
                        start_at = boleto.emissao.AddDays(boleto.multaDias).ToString("yyyy-MM-dd")
                    };
                }

                if (boleto.jurosValor > 0)
                {
                    dados.payment_method.interest = new TransacaoPaymentMethodInterest
                    {
                        mode = boleto.jurosTipo == (byte)TipoValor.Porcentagem ? PaymenMethodMode.PERCENTAGE : PaymenMethodMode.FIXED,
                        value = ((int)(boleto.jurosValor * 100)).ToString(),
                        start_at = boleto.emissao.AddDays(boleto.jurosDias).ToString("yyyy-MM-dd")
                    };
                }


                var json = JsonConvert.SerializeObject(dados);

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new RestClient($"{URL_BASE}{credenciais.client_id}/transactions");
                var request = new RestRequest(Method.POST);
                request.AddHeader("authorization", "Basic " + this.credenciais.token);
                request.AddHeader("accept", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse response = client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<TransacaoRetorno>(response.Content);
                    result.Success = true;                    
                }
                else
                {
                    try
                    {
                        var retorno = JsonConvert.DeserializeObject<ErrorResult>(response.Content);
                        result.Message = retorno.error.message;
                    }
                    catch
                    {
                        result.Message = response.StatusDescription + " - " + response.Content;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
