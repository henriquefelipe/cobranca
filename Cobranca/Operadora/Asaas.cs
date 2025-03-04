using Cobranca.Domain;
using Cobranca.Domain.Asaas;
using Cobranca.Domain.Boleto;
using Cobranca.Enum.Asaas;
using Cobranca.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Operadora
{
    public class Asaas
    {
        private string URL_BASE = "https://www.asaas.com/api/v3/"; // PRODUÇÃO
        private const string URL_BASE_HOM = "https://sandbox.asaas.com/api/v3/"; // HOMOLOGAÇÃO
        private const string URL_PAYMENTS = "payments";
        private const string URL_CUSTOMERS = "customers";

        private Credenciais credenciais;

        //internal Asaas(Credenciais credenciais)
        //{
        //    this.credenciais = credenciais;
        //    if (credenciais.isTest)
        //        URL_BASE = URL_BASE_HOM;
        //}

        public Asaas(Credenciais credenciais)
        {
            this.credenciais = credenciais;
            if (credenciais.isTest)
                URL_BASE = URL_BASE_HOM;
        }

        public GenericResult<Domain.Asaas.Cobranca> Payments(Boleto boleto)
        {
            var result = new GenericResult<Domain.Asaas.Cobranca>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }            
                
                if(string.IsNullOrEmpty(boleto.pagador.codigo))
                {
                    result.Message = "Informe o código do pagador";
                    return result;
                }

                var tipoValorDesconto = boleto.descontoTipo == (byte)Enum.TipoValor.Fixo ? TipoDesconto.FIXED : TipoDesconto.PERCENTAGE;

                var dados = new
                {
                    customer =  boleto.pagador.codigo,
                    billingType = BillingType.BOLETO,
                    dueDate = boleto.vencimento.ToString("yyyy-MM-dd"),
                    value = boleto.valor,
                    description = boleto.descricao,
                    externalReference = boleto.externalReference,
                    discount = new {                        
                        value = boleto.descontoValor,
                        dueDateLimitDays = boleto.descontoDias,
                        type = tipoValorDesconto
                    },
                    fine = new {
                        value = boleto.multaValor  // multa -> aqui é percentual
                    },
                    interest = new {
                        value = boleto.jurosValor  // juros -> aqui é percentual
                    },
                    postalService = boleto.postalService
                };

                var json = JsonConvert.SerializeObject(dados);
                var client = new RestClient(URL_BASE + URL_PAYMENTS);
                var request = new RestRequest(Method.POST);
                
                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<Domain.Asaas.Cobranca>(responseContent);
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Unauthorized: Token inválido";
                }
                else
                {
                    try
                    {
                        var errors = JsonConvert.DeserializeObject<ErrorsResult>(responseContent);
                        StringBuilder message = new StringBuilder();
                        foreach(var item in errors.errors)
                        {
                            message.AppendLine(item.description);
                        }

                        result.Message = message.ToString();
                    }
                    catch
                    {
                        result.Message = responseContent;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<CobrancaResult> PaymentsFilters(string parametros)
        {
            var result = new GenericResult<CobrancaResult>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new RestClient(string.Format("{0}{1}?{2}", URL_BASE, URL_PAYMENTS, parametros));
                var request = new RestRequest(Method.GET);

                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");                

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<CobrancaResult>(responseContent);
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Token inválido";
                }
                else
                {
                    result.Message = responseContent;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<BoletoPagadorRetorno> Customers(BoletoPagador pagador)
        {
            var result = new GenericResult<BoletoPagadorRetorno>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                var dados = new
                {
                    name = pagador.nome,
                    email = pagador.email,
                    phone = pagador.telefone,
                    mobilePhone = pagador.telefone,
                    cpfCnpj = pagador.cnpjcpf,
                    postalCode = pagador.cep,
                    address = pagador.endereco,
                    addressNumber = pagador.numero,
                    complement = pagador.complemento,
                    province = pagador.bairro,
                    externalReference = pagador.codigo,
                    notificationDisabled = false,
                    //additionalEmails = "henrique@izzyway.com.br,comercial@izzyway.com.br",
                    //municipalInscription = "46683695908",
                    //stateInscription = "646681195275",
                    observations = pagador.observacao
                };

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var json = JsonConvert.SerializeObject(dados);
                var client = new RestClient(URL_BASE + URL_CUSTOMERS);
                var request = new RestRequest(Method.POST);

                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", json, ParameterType.RequestBody);

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var customer = JsonConvert.DeserializeObject<Customer>(responseContent);
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

        public GenericResult<List<Customer>> CustomersByCpfCnpj(string cpfcnpj)
        {
            var result = new GenericResult<List<Customer>>();
            result.Result = new List<Customer>();

            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new RestClient(string.Format("{0}{1}?cpfCnpj={2}", URL_BASE, URL_CUSTOMERS, cpfcnpj));
                var request = new RestRequest(Method.GET);

                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");                

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var customers = JsonConvert.DeserializeObject<CustomerResult>(responseContent);
                    foreach (var customer in customers.data)
                    {
                        result.Result.Add(new Customer { id = customer.id, name = customer.name });
                    }
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Não autorizado";
                }
                else
                {
                    if(!string.IsNullOrEmpty(responseContent))
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

        public GenericResult<Customer> CustomerById(string id)
        {
            var result = new GenericResult<Customer>();

            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new RestClient(string.Format("{0}{1}/{2}", URL_BASE, URL_CUSTOMERS, id));
                var request = new RestRequest(Method.GET);

                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<Customer>(responseContent);                   
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Não autorizado";
                }
                else
                {
                    result.Message = responseContent;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<CustomerResult> CustomerAll(int offset = 0, int limit = 100)
        {
            var result = new GenericResult<CustomerResult>();

            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                var parametros = $"offset={offset}&limit={limit}";

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var client = new RestClient(string.Format("{0}{1}?{2}", URL_BASE, URL_CUSTOMERS, parametros));
                var request = new RestRequest(Method.GET);

                request.AddHeader("access_token", this.credenciais.chave);
                request.AddHeader("Content-Type", "application/json");

                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<CustomerResult>(responseContent);
                    result.Success = true;
                }
                else if (restResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    result.Message = "Não autorizado";
                }
                else
                {
                    result.Message = responseContent;
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
