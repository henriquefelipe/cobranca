using Cobranca.Domain;
using Cobranca.Domain.Inter;
using Cobranca.Domain.Itau;
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
    public class Itau
    {
        private string URL_BASE = "https://api.itau.com.br/sispag";
        private const string URL_BASE_STS = "https://sts.itau.com.br/api";
        private Credenciais credenciais;
        private const string FLOW_ID = "1";
        private const string CORRELATION_ID = "2";

        internal Itau(Credenciais credenciais)
        {
            this.credenciais = credenciais;
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

                var client = new RestClient($"{URL_BASE_STS}/oauth/token");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddHeader("x-itau-flowID", FLOW_ID);
                request.AddHeader("x-itau-correlationID", CORRELATION_ID);
                request.AddParameter("client_id", this.credenciais.client_id);
                request.AddParameter("client_secret", this.credenciais.client_secret);
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

        public GenericResult<ItauPixRetornoPagamento> PagamentoPix(ItauPixPagamento pagamento)
        {
            var result = new GenericResult<ItauPixRetornoPagamento>();
            try
            {
                if (string.IsNullOrEmpty(pagamento.referencia_empresa))
                {
                    pagamento.referencia_empresa = "REF.: ";
                }
                else
                {
                    if (pagamento.referencia_empresa.Length > 20)
                    {
                        pagamento.referencia_empresa = pagamento.referencia_empresa.Substring(0, 19);
                    }
                }

                var json = JsonConvert.SerializeObject(pagamento);

                var client = new RestClient($"{URL_BASE}/v1/transferencias");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.POST);
                request.AddHeader("x-itau-apikey", credenciais.client_id);
                request.AddHeader("x-itau-flowID", FLOW_ID);
                request.AddHeader("x-itau-correlationID", CORRELATION_ID);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + credenciais.token);
                request.AddParameter("application/json", json, ParameterType.RequestBody);
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<ItauPixRetornoPagamento>(responseContent);
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

        public GenericResult<ItauPixRetornoConsultaPagamento> ConsultaPagamentoPix(string identificador)
        {
            var result = new GenericResult<ItauPixRetornoConsultaPagamento>();
            try
            {                
                var client = new RestClient($"{URL_BASE}/v1/pagamentos_sispag/{identificador}");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-itau-apikey", credenciais.client_id);
                request.AddHeader("x-itau-flowID", FLOW_ID);
                request.AddHeader("x-itau-correlationID", CORRELATION_ID);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + credenciais.token);
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<ItauPixRetornoConsultaPagamento>(responseContent);
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

        public GenericResult<ItauPixRetornoConsultaPagamentos> ConsultaPagamentosPix(DateTime inicio, DateTime fim)
        {
            var result = new GenericResult<ItauPixRetornoConsultaPagamentos>();
            try
            {
                var parametrosBasico = $"agencia_operacao={credenciais.agencia}&conta_operacao={credenciais.conta}&cnpj_empresa={credenciais.cnpjcpf}";
                var parametros = $"&data_inicial={inicio:yyyy-MM-dd}&data_final={fim:yyyy-MM-dd}&tipo_lista=Detalhada";

                var client = new RestClient($"{URL_BASE}/v1/pagamentos_sispag?{parametrosBasico}{parametros}");
                client.ClientCertificates = GetCertificado();
                client.Proxy = new WebProxy();
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-itau-apikey", credenciais.client_id);
                request.AddHeader("x-itau-flowID", FLOW_ID);
                request.AddHeader("x-itau-correlationID", CORRELATION_ID);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "Bearer " + credenciais.token);
                IRestResponse restResponse = client.Execute(request);
                string responseContent = restResponse.Content;
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result.Result = JsonConvert.DeserializeObject<ItauPixRetornoConsultaPagamentos>(responseContent);
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
    }
}
