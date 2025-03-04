using Cobranca.Domain;
using Cobranca.Domain.Inter;
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
    public class Inter
    {
        private string URL_BASE = "https://cdpj.partners.bancointer.com.br";
        private const string URL_BASE_TESTE = "https://cdpj-sandbox.partners.uatinter.co";
        private const string SCOPE = "extrato.read boleto-cobranca.read boleto-cobranca.write pagamento-pix.write pagamento-pix.read";
        private Credenciais credenciais;

        internal Inter(Credenciais credenciais)
        {
            this.credenciais = credenciais;
            //if(credenciais.isTest)
            //{
            //    URL_BASE = URL_BASE_TESTE;
            //}
        }

        private string GetScope()
        {
            if(!string.IsNullOrEmpty(this.credenciais.scope))
            {
                return SCOPE;
            }
            return this.credenciais.scope;
        }

        private X509Certificate2Collection GetCertificado()
        {
            X509Certificate2Collection certificates = new X509Certificate2Collection();
            certificates.Import(credenciais.caminhoCertificado, credenciais.senhaCertificado, X509KeyStorageFlags.PersistKeySet);
            return certificates;        
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

                if (string.IsNullOrEmpty(this.credenciais.caminhoCertificado))
                {
                    result.Message = "certificado não informado";
                    return result;
                }
                                
                var client = new RestClient($"{URL_BASE}/oauth/v2/token");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.POST);                
                request.AddParameter("client_id", this.credenciais.client_id);
                request.AddParameter("client_secret", this.credenciais.client_secret);
                request.AddParameter("grant_type", "client_credentials");
                request.AddParameter("scope", GetScope());
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
        

        public GenericResult<InterPixPagamentoRetorno> PagamentoPix(string identificador, InterPixPagamento pagamento)
        {
            var result = new GenericResult<InterPixPagamentoRetorno>();
            try
            {
                var json = JsonConvert.SerializeObject(pagamento);

                var client = new RestClient($"{URL_BASE}/banking/v2/pix");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.POST);
                request.AddHeader("x-id-idempotente", identificador);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", "Bearer " + credenciais.token);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<InterPixPagamentoRetorno>(responseContent);
                    result.Success = true;
                }
                else
                {
                    result.Message = responseContent;
                }

                result.JSON = responseContent;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        public GenericResult<InterPixConsultaPagamentoRetorno> ConsultaPagamentoPix(string identificador)
        {
            var result = new GenericResult<InterPixConsultaPagamentoRetorno>();
            try
            {
                var client = new RestClient($"{URL_BASE}/banking/v2/pix/{identificador}");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.GET);                              
                request.AddHeader("Authorization", "Bearer " + credenciais.token);                
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<InterPixConsultaPagamentoRetorno>(responseContent);
                    result.Success = true;
                }
                //else if (restResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
                //{
                //    {
                //        "title":"Pix não encontrado.",
                //        "detail":"Pix não encontrado para a conta-corrente informada.",
                //        "timestamp":"2025-03-04T12:35:09.326739409-03:00"
                //    }
                //}
                else
                {                    
                    result.Message = responseContent;
                }

                result.JSON = responseContent;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }
            return result;
        }

        
    }
}
