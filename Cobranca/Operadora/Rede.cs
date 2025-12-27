using Cobranca.Domain;
using Cobranca.Domain.Rede;
using Cobranca.Utils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cobranca.Operadora
{
    public class Rede
    {
        private string URL_BASE = "https://api.useredecloud.com.br";
        private const string URL_BASE_TESTE = "https://rl7-sandbox-api.useredecloud.com.br";
        private Credenciais credenciais;

        internal Rede(Credenciais credenciais)
        {
            this.credenciais = credenciais;
            if(credenciais.isTest)
            {
                URL_BASE = URL_BASE_TESTE;
            }
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

                var client = new RestClient($"{URL_BASE}/oauth2/token");               
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddHeader(
                                    "Authorization",
                                    "Basic " + Convert.ToBase64String(
                                        Encoding.UTF8.GetBytes(
                                            $"{credenciais.client_id}:{credenciais.client_secret}"
                                        )
                                    )
                                );                
                request.AddParameter("grant_type", "client_credentials");

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

        public GenericResult<TransactionsResponseViewModel> CartaoVenda(VendaCartaoRecebimentoFiltro filtro)
        {
            var result = new GenericResult<TransactionsResponseViewModel>();
            try
            {                

                var client = new RestClient($"{URL_BASE}/merchant-statement/v1/sales");               
                var request = new RestRequest(Method.GET);
                request.AddParameter("parentCompanyNumber", filtro.Subsidiaria);
                request.AddParameter("subsidiaries", filtro.Subsidiaria);
                request.AddParameter("startDate", filtro.Inicio.ToString("yyyy-MM-dd"));
                request.AddParameter("endDate", filtro.Fim.ToString("yyyy-MM-dd"));
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + credenciais.token);                
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                result.JSON = responseContent;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<TransactionsResponseViewModel>(responseContent);
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
