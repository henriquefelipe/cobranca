using Cobranca.Domain;
using Cobranca.Domain.Boleto;
using Cobranca.Enum.Asaas;
using Cobranca.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Operadora
{
    public class Asaas
    {
        private const string URL_BASE = "https://www.asaas.com/api/v3/";        
        private const string URL_PAYMENTS = "payments";
        private const string URL_CUSTOMERS = "customers";

        private Credenciais credenciais;

        internal Asaas(Credenciais credenciais)
        {
            this.credenciais = credenciais;
        }

        public GenericResult<Usuario> Payments(Boleto boleto)
        {
            var result = new GenericResult<Usuario>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }               

                var dados = new
                {
                    customer =  boleto.pagador.codigo,
                    billingType = BillingType.BOLETO,
                    dueDate = boleto.vencimento.ToString("yyyy-MM-dd"),
                    value = 100.00,
                    description = boleto.descricao,
                    externalReference = boleto.externalReference,
                    discount = new {                        
                        value = 10.00,
                        dueDateLimitDays = 0
                    },
                    fine = new {
                        value = 1.00
                    },
                    interest = new {
                        value = 2.00
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
                    result.Result = JsonConvert.DeserializeObject<Usuario>(responseContent);
                    result.Success = true;
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

        public GenericResult<Usuario> Customers(BoletoPagador pagador)
        {
            var result = new GenericResult<Usuario>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.chave))
                {
                    result.Message = "chave não informado";
                    return result;
                }

                var dados = new
                {
                    name = "Marcelo Almeida",
                    email = "marcelo.almeida@gmail.com",
                    phone = "4738010919",
                    mobilePhone = "4799376637",
                    cpfCnpj = "24971563792",
                    postalCode = "01310-000",
                    address = "Av. Paulista",
                    addressNumber = "150",
                    complement = "Sala 201",
                    province = "Centro",
                    externalReference = "12987382",
                    notificationDisabled = false,
                    additionalEmails = "marcelo.almeida2@gmail.com,marcelo.almeida3@gmail.com",
                    municipalInscription = "46683695908",
                    stateInscription = "646681195275",
                    observations = "ótimo pagador, nenhum problema até o momento"
                };

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
                    result.Result = JsonConvert.DeserializeObject<Usuario>(responseContent);
                    result.Success = true;
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
