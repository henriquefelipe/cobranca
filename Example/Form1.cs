using Cobranca.Domain;
using Cobranca.Domain.Boleto;
using Cobranca.Service;
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
            credenciais.isTest = true;            

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

            return new Credenciais();
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

            return credenciais;
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
            pagador.telefone = "08000 012455245";


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

            //Recebimento
            var parametros = string.Format("paymentDate%5Bge%5D={0}&paymentDate%5Ble%5D={1}", 
                    DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));

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
            cobrancaService.Autenticar();
        }
    }
}

