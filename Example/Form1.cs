using Cobranca.Domain;
using Cobranca.Domain.Asaas;
using Cobranca.Domain.Boleto;
using Cobranca.Operadora;
using Cobranca.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public string _id { get; set; }
        public string _id2 { get; set; }
        public string _idCancelamento { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOperadora.DataSource = Enum.GetValues(typeof(Cobranca.Enum.Operadora));
            cboTipo.DataSource = Enum.GetValues(typeof(Cobranca.Enum.Tipo));

            var caminhoArquivo = "C:\\Cobranca.json";
            if (File.Exists(caminhoArquivo))
            {
                var conteudo = File.ReadAllText(caminhoArquivo);
                var objeto = JsonConvert.DeserializeObject<CredenciaisExample> (conteudo);
                if(objeto != null)
                {
                    txtInterCertificado.Text = objeto.InterCaminhoCertificado;
                    txtInterClientId.Text = objeto.InterClientId;
                    txtInterClientSecret.Text = objeto.InterClienteSecret;
                    txtInterKey.Text = objeto.InterSenhaCertificado;

                    txtZoopKey.Text = objeto.ZoopToken;
                    txtZoopMarketplaceId.Text = objeto.ZoopMarketplaceId;                    
                }
            }
        }

        public Credenciais GetCredenciaisGerenciaNet()
        {
            var credenciais = new Credenciais();
            credenciais.operadora = Cobranca.Enum.Operadora.GerenciaNet;
            credenciais.tipo = (Cobranca.Enum.Tipo)cboTipo.SelectedItem;
            credenciais.caminhoCertificado = txtGerenciaNetCertificado.Text;
            credenciais.client_id = txtGerenciaNetClientID.Text;
            credenciais.client_secret = txtGerenciaNetClientSECRET.Text;
            credenciais.chave = txtGerenciaNetChave.Text;

            return credenciais;
        }

        public Credenciais GetCredenciaisAsaas()
        {
            var credenciais = new Credenciais();
            credenciais.operadora = Cobranca.Enum.Operadora.Asaas;
            credenciais.tipo = (Cobranca.Enum.Tipo)cboTipo.SelectedItem;            
            credenciais.chave = txtAsaasChave.Text;
            credenciais.isTest = false;            

            return credenciais;
        }

        public Credenciais GetCredenciaisBancoInter()
        {
            var credenciais = new Credenciais();
            credenciais.operadora = Cobranca.Enum.Operadora.BancoInter;
            credenciais.tipo = (Cobranca.Enum.Tipo)cboTipo.SelectedItem;
            credenciais.client_id = txtInterClientId.Text;
            credenciais.client_secret = txtInterClientSecret.Text;
            credenciais.isTest = true;
            credenciais.scope = txtInterScope.Text;
            credenciais.caminhoCertificado = txtInterCertificado.Text;
            credenciais.senhaCertificado = txtInterKey.Text;
            credenciais.token = txtInterToken.Text;

            return credenciais;
        }

        public Credenciais GetCredenciaisZoop()
        {
            var credenciais = new Credenciais();
            credenciais.operadora = Cobranca.Enum.Operadora.Zoop;
            credenciais.tipo = (Cobranca.Enum.Tipo)cboTipo.SelectedItem;
            credenciais.client_id = txtZoopMarketplaceId.Text;      
            credenciais.token = txtZoopKey.Text;           
            
            return credenciais;
        }

        public Credenciais GetCredenciais()
        {
            var operadora = (Cobranca.Enum.Operadora)cboOperadora.SelectedItem;            
            if (operadora == Cobranca.Enum.Operadora.GerenciaNet)
                return GetCredenciaisGerenciaNet();
            else if (operadora == Cobranca.Enum.Operadora.Asaas)
                return GetCredenciaisAsaas();
            else if (operadora == Cobranca.Enum.Operadora.BancoInter)
                return GetCredenciaisBancoInter();
            else if (operadora == Cobranca.Enum.Operadora.Zoop)
                return GetCredenciaisZoop();

            return new Credenciais();
        }

        

        private void btnGerarCobranca_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();

            if (credenciais.tipo == Cobranca.Enum.Tipo.PIX)
            {
                _id = Guid.NewGuid().ToString("N");

                var recebimento = new Recebimento();
                recebimento.Id = _id;
                //cobranca.DevedorNome = "Consumidor Final";
                //cobranca.DevedorCpf = "72088500030";
                recebimento.SolicitacaoPagador = "IzzyWay Tecnologia";
                recebimento.Valor = Convert.ToDecimal(txtValor.Text);

                var cobrancaService = new CobrancaService(credenciais);
                var result = cobrancaService.CobrarPix(recebimento);
                if (!result.Success)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                var base64 = result.Result.ImagemQrCode.Replace("data:image/png;base64,", "");
                var pic = Convert.FromBase64String(base64);
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    imgQrCode.Image = Image.FromStream(ms);
                }
            }
            else if (credenciais.tipo == Cobranca.Enum.Tipo.Boleto)
            {
                var boleto = new Boleto();
                boleto.pagador = new BoletoPagador();
                boleto.pagador.codigo = "cus_000004856726";
                boleto.pagador.cnpjcpf = "24537333030";
                boleto.pagador.nome = "Fulano da Silva";
                boleto.vencimento = DateTime.Now.AddDays(2);
                boleto.valor = Convert.ToDecimal(txtValor.Text);
                boleto.multaValor = 2;
                boleto.jurosValor = 2;
                boleto.mensagens.Add("RECEBER ATÉ 10 DIAS ÚTEIS APÓS VENCIDO");
                boleto.mensagens.Add("PROTESTAR NO DÉCIMO DIA APÓS VENCIDO");

                var cobrancaService = new CobrancaService(credenciais);
                var result = cobrancaService.CobrarBoleto(boleto);
                if (result.Success)
                {
                    MessageBox.Show("Criado com sucesso");
                    return;
                }
                else
                {
                    MessageBox.Show(result.Message);
                    return;
                }
            }
        }

        private void btnStatusCobranca_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_id))
            {
                MessageBox.Show("Nenhuma cobrança gerada");
                return;
            }
            
            var credenciais = GetCredenciais();

            var carteiraDigitalService = new CobrancaService(credenciais);
            var result = carteiraDigitalService.StatusPix(_id);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show("Recebido");

            _id2 = result.Result.Chave;
        }

        private void btnDevolucaoCobranca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_id))
            {
                MessageBox.Show("Nenhuma cobrança gerada");
                return;
            }

            if (string.IsNullOrEmpty(_id2))
            {
                MessageBox.Show("Status não verificado da cobrança");
                return;
            }

            var credenciais = GetCredenciais();

            var valor = Convert.ToDecimal(txtValor.Text);

            var carteiraDigitalService = new CobrancaService(credenciais);
            var result = carteiraDigitalService.DevolucaoPix(_id, _id2, valor);
            if (result.Success)
            {
                MessageBox.Show("Devolvido com sucesso");
                return;
            }

            _idCancelamento = result.Result.Chave;
            MessageBox.Show(result.Message);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();
            var cobrancaService = new CobrancaService(credenciais);
            var result = cobrancaService.CobrarBoletoBuscarCliente(txtCNPJCPF.Text);
            if (result.Success)
            {
                MessageBox.Show("Cadastro existe");
            }
            else 
            {
                MessageBox.Show(result.Message);               
            }                        
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();

            var pagador = new BoletoPagador();
            pagador.nome = "Henrique";
            pagador.cnpjcpf = "00393389324";
            pagador.cep = "60532-670";
            pagador.numero = "38";
            pagador.telefone = "85987704779";
            pagador.endereco = "Rua 1 de Maio";
            pagador.bairro = "Parangaba";
            pagador.cidade = "Fortaleza";
            pagador.uf = "CE";


            var cobrancaService = new CobrancaService(credenciais);
            var result = cobrancaService.CobrarBoletoCadastrarCliente(pagador);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
        }

        private void btnBuscarCobranca_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();
            var cobrancaService = new CobrancaService(credenciais);

            var data = Convert.ToDateTime("22/12/2023");

            //Recebimento
            var parametros = string.Format("paymentDate%5Bge%5D={0}&paymentDate%5Ble%5D={1}",
                    data.ToString("yyyy-MM-dd"), data.ToString("yyyy-MM-dd"));

            //Vencimento
            //var parametros = string.Format("dueDate%5Bge%5D={0}&dueDate%5Ble%5D={1}",
            //        DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));

            var result = cobrancaService.CobrarBoletoListar(parametros, true);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
                return;
            }
        }

        private void btnInterGerarToken_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();
            var cobrancaService = new CobrancaService(credenciais);
            var result = cobrancaService.Autenticar();
            if(result.Success)
            {
                txtInterToken.Text = result.Result.access_token;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnCLientes2023_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();
            var cobrancaService = new CobrancaService(credenciais);

            var dataInicio = Convert.ToDateTime("01/01/2023");
            var dataFim = Convert.ToDateTime("31/12/2023");
            var offset = 0;
            var limit = 100;

            var asaas = new Asaas(credenciais);
            var resultado = asaas.CustomerAll(offset, limit);

            var listaClientes = new List<Customer>();

            var qtdeClientes = 0;
            foreach(var item in resultado.Result.data)
            {
                if (item.dateCreated.CompareTo(dataInicio) >= 0 && item.dateCreated.CompareTo(dataFim) <= 0)
                {
                    listaClientes.Add(item);
                }
            }

            offset++;
            var qtdePaginas = resultado.Result.totalCount / 100;
            if ((qtdePaginas * 100) < resultado.Result.totalCount)
                qtdePaginas++;
            for (var i = offset; i < qtdePaginas; i++)
            {
                var resultadoLaco = asaas.CustomerAll(offset, limit);                
                foreach (var item in resultadoLaco.Result.data)
                {
                    if (item.dateCreated.CompareTo(dataInicio) >= 0 && item.dateCreated.CompareTo(dataFim) <= 0)
                    {
                        listaClientes.Add(item);
                    }
                }

                offset++;
            }

            //txtClientes2023.Text = qtdeClientes.ToString();

            StringBuilder sb = new StringBuilder();

            var clientes = listaClientes.OrderBy(o => o.name).GroupBy(g => g.name);
            foreach (var item in clientes)
            {
                sb.AppendLine($"{item.Key}");
            }

            var arquivo = "Clientes0" + DateTime.Now.ToString("ssmmddMMyyyy") + ".txt";
            File.WriteAllText(@"C:\\IzzyWay\RH\" + arquivo, sb.ToString());
        }

        private void btnPagarPix_Click(object sender, EventArgs e)
        {
            txtIdentificador.Text = Guid.NewGuid().ToString();

            var credenciais = GetCredenciais();                     
            var cobrancaService = new CobrancaService(credenciais);

            var pagamentoPix = new PagamentoPix();
            pagamentoPix.Valor = Convert.ToDecimal(txtValor.Text);
            pagamentoPix.Chave = txtPixChave.Text;
            pagamentoPix.Identificador = txtIdentificador.Text;

            var result = cobrancaService.PagamentoPix(pagamentoPix);
            if(result.Success)
            {
                txtIdentificador.Text = result.Result.Identificador;
            }
        }

        private void btnConsultaPix_Click(object sender, EventArgs e)
        {
            var credenciais = GetCredenciais();
            var cobrancaService = new CobrancaService(credenciais);

            var consultaPagamentoPix = new ConsultaPagamentoPix();
            consultaPagamentoPix.Identificador = txtIdentificador.Text;

            cobrancaService.ConsultaPagamentoPix(consultaPagamentoPix);
        }
    }
}

