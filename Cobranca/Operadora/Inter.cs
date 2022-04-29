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
    public class Inter
    {
        private const string URL_BASE = "https://apis.bancointer.com.br/openbanking/v1/certificado/";        
        private const string URL_BOLETO = "boletos";
        private const string URL_TOKEN = "https://cdpj.partners.bancointer.com.br/oauth/v2/token";

        private Credenciais credenciais;

        internal Inter(Credenciais credenciais)
        {
            this.credenciais = credenciais;
        }

        public GenericResult<Usuario> Token()
        {
            var result = new GenericResult<Usuario>();
            try
            {
                if (string.IsNullOrEmpty(this.credenciais.client_id))
                {
                    result.Message = "client id não informado";
                    return result;
                }

                if (string.IsNullOrEmpty(this.credenciais.client_secret))
                {
                    result.Message = "client secret não informado";
                    return result;
                }

                var dados = new
                {
                    grant_type = "client_credentials",
                    client_id = this.credenciais.client_id,
                    client_secret = this.credenciais.client_secret,
                    scope = this.credenciais.scope
                };

                var json = JsonConvert.SerializeObject(dados);
                var client = new RestClient(URL_TOKEN);
                var request = new RestRequest(Method.POST);

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", json, ParameterType.RequestBody);                
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

        public GenericResult<Usuario> Emissao(Boleto boleto)
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
                var client = new RestClient(URL_BASE + URL_BOLETO);
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
