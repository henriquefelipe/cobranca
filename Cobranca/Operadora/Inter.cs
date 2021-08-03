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
        //private const string URL_CUSTOMERS = "customers";

        private Credenciais credenciais;

        internal Inter(Credenciais credenciais)
        {
            this.credenciais = credenciais;
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
