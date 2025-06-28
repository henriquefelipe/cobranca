using Cobranca.Domain;
using Cobranca.Domain.Boleto;
using Cobranca.Domain.Zoop;
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

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
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
    }
}
