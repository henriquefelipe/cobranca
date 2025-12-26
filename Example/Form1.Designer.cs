
namespace Example
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarCobranca = new System.Windows.Forms.Button();
            this.btnStatusCobranca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOperadora = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.imgQrCode = new System.Windows.Forms.PictureBox();
            this.btnDevolucaoCobranca = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAsaas = new System.Windows.Forms.TabPage();
            this.txtAsaasChave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageInter = new System.Windows.Forms.TabPage();
            this.txtInterKey = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInterCertificado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInterScope = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInterToken = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInterGerarToken = new System.Windows.Forms.Button();
            this.txtInterClientSecret = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInterClientId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageGerenciaNet = new System.Windows.Forms.TabPage();
            this.txtGerenciaNetChave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGerenciaNetClientSECRET = new System.Windows.Forms.TextBox();
            this.txtGerenciaNetClientID = new System.Windows.Forms.TextBox();
            this.txtGerenciaNetCertificado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageZoop = new System.Windows.Forms.TabPage();
            this.txtZoopSellerId = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtZoopKey = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtZoopMarketplaceId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCNPJCPF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCobranca = new System.Windows.Forms.Button();
            this.txtClientes2023 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCLientes2023 = new System.Windows.Forms.Button();
            this.btnPagarPix = new System.Windows.Forms.Button();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPixChave = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnConsultaPix = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPageItau = new System.Windows.Forms.TabPage();
            this.txtItauCertificadoSenha = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtItauCertificadoCaminho = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtItauToken = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnItauGerarToken = new System.Windows.Forms.Button();
            this.txtItauClientSecret = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtItauClientID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtItauAgencia = new System.Windows.Forms.TextBox();
            this.txtItauConta = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtItauCNPJ = new System.Windows.Forms.TextBox();
            this.btnConsultarVariosPix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAsaas.SuspendLayout();
            this.tabPageInter.SuspendLayout();
            this.tabPageGerenciaNet.SuspendLayout();
            this.tabPageZoop.SuspendLayout();
            this.tabPageItau.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarCobranca
            // 
            this.btnGerarCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCobranca.Location = new System.Drawing.Point(40, 325);
            this.btnGerarCobranca.Name = "btnGerarCobranca";
            this.btnGerarCobranca.Size = new System.Drawing.Size(182, 33);
            this.btnGerarCobranca.TabIndex = 0;
            this.btnGerarCobranca.Text = "Gerar Cobrança";
            this.btnGerarCobranca.UseVisualStyleBackColor = true;
            this.btnGerarCobranca.Click += new System.EventHandler(this.btnGerarCobranca_Click);
            // 
            // btnStatusCobranca
            // 
            this.btnStatusCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusCobranca.Location = new System.Drawing.Point(425, 325);
            this.btnStatusCobranca.Name = "btnStatusCobranca";
            this.btnStatusCobranca.Size = new System.Drawing.Size(154, 33);
            this.btnStatusCobranca.TabIndex = 1;
            this.btnStatusCobranca.Text = "Status Cobrança";
            this.btnStatusCobranca.UseVisualStyleBackColor = true;
            this.btnStatusCobranca.Click += new System.EventHandler(this.btnStatusCobranca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // cboOperadora
            // 
            this.cboOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperadora.FormattingEnabled = true;
            this.cboOperadora.Location = new System.Drawing.Point(172, 219);
            this.cboOperadora.Name = "cboOperadora";
            this.cboOperadora.Size = new System.Drawing.Size(247, 28);
            this.cboOperadora.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(172, 276);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(173, 26);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "5,00";
            // 
            // imgQrCode
            // 
            this.imgQrCode.Location = new System.Drawing.Point(651, 433);
            this.imgQrCode.Name = "imgQrCode";
            this.imgQrCode.Size = new System.Drawing.Size(176, 211);
            this.imgQrCode.TabIndex = 6;
            this.imgQrCode.TabStop = false;
            // 
            // btnDevolucaoCobranca
            // 
            this.btnDevolucaoCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucaoCobranca.Location = new System.Drawing.Point(614, 325);
            this.btnDevolucaoCobranca.Name = "btnDevolucaoCobranca";
            this.btnDevolucaoCobranca.Size = new System.Drawing.Size(197, 33);
            this.btnDevolucaoCobranca.TabIndex = 7;
            this.btnDevolucaoCobranca.Text = "Devolução Cobrança";
            this.btnDevolucaoCobranca.UseVisualStyleBackColor = true;
            this.btnDevolucaoCobranca.Click += new System.EventHandler(this.btnDevolucaoCobranca_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAsaas);
            this.tabControl1.Controls.Add(this.tabPageInter);
            this.tabControl1.Controls.Add(this.tabPageGerenciaNet);
            this.tabControl1.Controls.Add(this.tabPageItau);
            this.tabControl1.Controls.Add(this.tabPageZoop);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 189);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageAsaas
            // 
            this.tabPageAsaas.Controls.Add(this.txtAsaasChave);
            this.tabPageAsaas.Controls.Add(this.label8);
            this.tabPageAsaas.Location = new System.Drawing.Point(4, 22);
            this.tabPageAsaas.Name = "tabPageAsaas";
            this.tabPageAsaas.Size = new System.Drawing.Size(801, 163);
            this.tabPageAsaas.TabIndex = 1;
            this.tabPageAsaas.Text = "Asaas";
            this.tabPageAsaas.UseVisualStyleBackColor = true;
            // 
            // txtAsaasChave
            // 
            this.txtAsaasChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaasChave.Location = new System.Drawing.Point(146, 19);
            this.txtAsaasChave.Name = "txtAsaasChave";
            this.txtAsaasChave.Size = new System.Drawing.Size(639, 26);
            this.txtAsaasChave.TabIndex = 17;
            this.txtAsaasChave.Text = "b7f9db5e7f5278b9daa2d378874fed46efc095b620dea4316f2df087ac35b661";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chave";
            // 
            // tabPageInter
            // 
            this.tabPageInter.Controls.Add(this.txtInterKey);
            this.tabPageInter.Controls.Add(this.label15);
            this.tabPageInter.Controls.Add(this.txtInterCertificado);
            this.tabPageInter.Controls.Add(this.label14);
            this.tabPageInter.Controls.Add(this.txtInterScope);
            this.tabPageInter.Controls.Add(this.label13);
            this.tabPageInter.Controls.Add(this.txtInterToken);
            this.tabPageInter.Controls.Add(this.label12);
            this.tabPageInter.Controls.Add(this.btnInterGerarToken);
            this.tabPageInter.Controls.Add(this.txtInterClientSecret);
            this.tabPageInter.Controls.Add(this.label11);
            this.tabPageInter.Controls.Add(this.txtInterClientId);
            this.tabPageInter.Controls.Add(this.label10);
            this.tabPageInter.Location = new System.Drawing.Point(4, 22);
            this.tabPageInter.Name = "tabPageInter";
            this.tabPageInter.Size = new System.Drawing.Size(801, 163);
            this.tabPageInter.TabIndex = 2;
            this.tabPageInter.Text = "Banco Inter";
            this.tabPageInter.UseVisualStyleBackColor = true;
            // 
            // txtInterKey
            // 
            this.txtInterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterKey.Location = new System.Drawing.Point(522, 80);
            this.txtInterKey.Name = "txtInterKey";
            this.txtInterKey.Size = new System.Drawing.Size(263, 26);
            this.txtInterKey.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(399, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Senha";
            // 
            // txtInterCertificado
            // 
            this.txtInterCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterCertificado.Location = new System.Drawing.Point(146, 80);
            this.txtInterCertificado.Name = "txtInterCertificado";
            this.txtInterCertificado.Size = new System.Drawing.Size(247, 26);
            this.txtInterCertificado.TabIndex = 27;
            this.txtInterCertificado.Text = "G:\\Google Drive\\Desenvolvimento\\Integrações\\Banco Inter\\Nova API\\Inter API_Certif" +
    "icado.crt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Certificado";
            // 
            // txtInterScope
            // 
            this.txtInterScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterScope.Location = new System.Drawing.Point(146, 48);
            this.txtInterScope.Name = "txtInterScope";
            this.txtInterScope.Size = new System.Drawing.Size(642, 26);
            this.txtInterScope.TabIndex = 25;
            this.txtInterScope.Text = "extrato.read boleto-cobranca.read boleto-cobranca.write pagamento-pix.write pagam" +
    "ento-pix.read";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Scope";
            // 
            // txtInterToken
            // 
            this.txtInterToken.Enabled = false;
            this.txtInterToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterToken.Location = new System.Drawing.Point(146, 117);
            this.txtInterToken.Name = "txtInterToken";
            this.txtInterToken.Size = new System.Drawing.Size(435, 26);
            this.txtInterToken.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Token";
            // 
            // btnInterGerarToken
            // 
            this.btnInterGerarToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterGerarToken.Location = new System.Drawing.Point(606, 117);
            this.btnInterGerarToken.Name = "btnInterGerarToken";
            this.btnInterGerarToken.Size = new System.Drawing.Size(182, 33);
            this.btnInterGerarToken.TabIndex = 16;
            this.btnInterGerarToken.Text = "Gerar Token";
            this.btnInterGerarToken.UseVisualStyleBackColor = true;
            this.btnInterGerarToken.Click += new System.EventHandler(this.btnInterGerarToken_Click);
            // 
            // txtInterClientSecret
            // 
            this.txtInterClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterClientSecret.Location = new System.Drawing.Point(522, 13);
            this.txtInterClientSecret.Name = "txtInterClientSecret";
            this.txtInterClientSecret.Size = new System.Drawing.Size(266, 26);
            this.txtInterClientSecret.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(399, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Client Secret";
            // 
            // txtInterClientId
            // 
            this.txtInterClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterClientId.Location = new System.Drawing.Point(146, 16);
            this.txtInterClientId.Name = "txtInterClientId";
            this.txtInterClientId.Size = new System.Drawing.Size(247, 26);
            this.txtInterClientId.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Client ID";
            // 
            // tabPageGerenciaNet
            // 
            this.tabPageGerenciaNet.Controls.Add(this.txtGerenciaNetChave);
            this.tabPageGerenciaNet.Controls.Add(this.label6);
            this.tabPageGerenciaNet.Controls.Add(this.txtGerenciaNetClientSECRET);
            this.tabPageGerenciaNet.Controls.Add(this.txtGerenciaNetClientID);
            this.tabPageGerenciaNet.Controls.Add(this.txtGerenciaNetCertificado);
            this.tabPageGerenciaNet.Controls.Add(this.label5);
            this.tabPageGerenciaNet.Controls.Add(this.label4);
            this.tabPageGerenciaNet.Controls.Add(this.label3);
            this.tabPageGerenciaNet.Location = new System.Drawing.Point(4, 22);
            this.tabPageGerenciaNet.Name = "tabPageGerenciaNet";
            this.tabPageGerenciaNet.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageGerenciaNet.Size = new System.Drawing.Size(801, 163);
            this.tabPageGerenciaNet.TabIndex = 0;
            this.tabPageGerenciaNet.Text = "GerenciaNet";
            this.tabPageGerenciaNet.UseVisualStyleBackColor = true;
            // 
            // txtGerenciaNetChave
            // 
            this.txtGerenciaNetChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetChave.Location = new System.Drawing.Point(146, 125);
            this.txtGerenciaNetChave.Name = "txtGerenciaNetChave";
            this.txtGerenciaNetChave.Size = new System.Drawing.Size(639, 26);
            this.txtGerenciaNetChave.TabIndex = 15;
            this.txtGerenciaNetChave.Text = "fb1ccee9-5e64-414c-bd8b-b3a2f7060100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chave";
            // 
            // txtGerenciaNetClientSECRET
            // 
            this.txtGerenciaNetClientSECRET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetClientSECRET.Location = new System.Drawing.Point(146, 90);
            this.txtGerenciaNetClientSECRET.Name = "txtGerenciaNetClientSECRET";
            this.txtGerenciaNetClientSECRET.Size = new System.Drawing.Size(639, 26);
            this.txtGerenciaNetClientSECRET.TabIndex = 13;
            this.txtGerenciaNetClientSECRET.Text = "Client_Secret_d96e22652c7c89fa335ae2cc913c5e221fdaab10";
            // 
            // txtGerenciaNetClientID
            // 
            this.txtGerenciaNetClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetClientID.Location = new System.Drawing.Point(146, 53);
            this.txtGerenciaNetClientID.Name = "txtGerenciaNetClientID";
            this.txtGerenciaNetClientID.Size = new System.Drawing.Size(639, 26);
            this.txtGerenciaNetClientID.TabIndex = 12;
            this.txtGerenciaNetClientID.Text = "Client_Id_066bc1dd146920d241ca0d89ae1d31535e5afd92";
            // 
            // txtGerenciaNetCertificado
            // 
            this.txtGerenciaNetCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetCertificado.Location = new System.Drawing.Point(146, 14);
            this.txtGerenciaNetCertificado.Name = "txtGerenciaNetCertificado";
            this.txtGerenciaNetCertificado.Size = new System.Drawing.Size(639, 26);
            this.txtGerenciaNetCertificado.TabIndex = 9;
            this.txtGerenciaNetCertificado.Text = "C:\\certificadoProducao.p12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Client_SECRET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Certificado";
            // 
            // tabPageZoop
            // 
            this.tabPageZoop.Controls.Add(this.txtZoopSellerId);
            this.tabPageZoop.Controls.Add(this.label21);
            this.tabPageZoop.Controls.Add(this.txtZoopKey);
            this.tabPageZoop.Controls.Add(this.label20);
            this.tabPageZoop.Controls.Add(this.txtZoopMarketplaceId);
            this.tabPageZoop.Controls.Add(this.label19);
            this.tabPageZoop.Location = new System.Drawing.Point(4, 22);
            this.tabPageZoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageZoop.Name = "tabPageZoop";
            this.tabPageZoop.Size = new System.Drawing.Size(801, 163);
            this.tabPageZoop.TabIndex = 3;
            this.tabPageZoop.Text = "Zoop";
            this.tabPageZoop.UseVisualStyleBackColor = true;
            // 
            // txtZoopSellerId
            // 
            this.txtZoopSellerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoopSellerId.Location = new System.Drawing.Point(155, 77);
            this.txtZoopSellerId.Name = "txtZoopSellerId";
            this.txtZoopSellerId.Size = new System.Drawing.Size(192, 26);
            this.txtZoopSellerId.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(695, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "Marketplace Id";
            // 
            // txtZoopKey
            // 
            this.txtZoopKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoopKey.Location = new System.Drawing.Point(380, 27);
            this.txtZoopKey.Name = "txtZoopKey";
            this.txtZoopKey.Size = new System.Drawing.Size(265, 26);
            this.txtZoopKey.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(669, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Token";
            // 
            // txtZoopMarketplaceId
            // 
            this.txtZoopMarketplaceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZoopMarketplaceId.Location = new System.Drawing.Point(368, 71);
            this.txtZoopMarketplaceId.Name = "txtZoopMarketplaceId";
            this.txtZoopMarketplaceId.Size = new System.Drawing.Size(342, 26);
            this.txtZoopMarketplaceId.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 26;
            this.label19.Text = "Seller Id";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(584, 219);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(247, 28);
            this.cboTipo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(40, 533);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(182, 33);
            this.btnBuscarCliente.TabIndex = 11;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCNPJCPF
            // 
            this.txtCNPJCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJCPF.Location = new System.Drawing.Point(452, 490);
            this.txtCNPJCPF.Name = "txtCNPJCPF";
            this.txtCNPJCPF.Size = new System.Drawing.Size(173, 26);
            this.txtCNPJCPF.TabIndex = 13;
            this.txtCNPJCPF.Text = "51608691071";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "CPF/CNPJ";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(237, 533);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(182, 33);
            this.btnCadastrarCliente.TabIndex = 14;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnBuscarCobranca
            // 
            this.btnBuscarCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCobranca.Location = new System.Drawing.Point(228, 325);
            this.btnBuscarCobranca.Name = "btnBuscarCobranca";
            this.btnBuscarCobranca.Size = new System.Drawing.Size(182, 33);
            this.btnBuscarCobranca.TabIndex = 15;
            this.btnBuscarCobranca.Text = "Buscar Cobrança";
            this.btnBuscarCobranca.UseVisualStyleBackColor = true;
            this.btnBuscarCobranca.Click += new System.EventHandler(this.btnBuscarCobranca_Click);
            // 
            // txtClientes2023
            // 
            this.txtClientes2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes2023.Location = new System.Drawing.Point(171, 586);
            this.txtClientes2023.Name = "txtClientes2023";
            this.txtClientes2023.Size = new System.Drawing.Size(173, 26);
            this.txtClientes2023.TabIndex = 16;
            this.txtClientes2023.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(58, 590);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Clientes 2023";
            // 
            // btnCLientes2023
            // 
            this.btnCLientes2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLientes2023.Location = new System.Drawing.Point(356, 583);
            this.btnCLientes2023.Name = "btnCLientes2023";
            this.btnCLientes2023.Size = new System.Drawing.Size(137, 33);
            this.btnCLientes2023.TabIndex = 18;
            this.btnCLientes2023.Text = "Buscar";
            this.btnCLientes2023.UseVisualStyleBackColor = true;
            this.btnCLientes2023.Click += new System.EventHandler(this.btnCLientes2023_Click);
            // 
            // btnPagarPix
            // 
            this.btnPagarPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarPix.Location = new System.Drawing.Point(40, 373);
            this.btnPagarPix.Name = "btnPagarPix";
            this.btnPagarPix.Size = new System.Drawing.Size(182, 33);
            this.btnPagarPix.TabIndex = 19;
            this.btnPagarPix.Text = "Pagar PIX";
            this.btnPagarPix.UseVisualStyleBackColor = true;
            this.btnPagarPix.Click += new System.EventHandler(this.btnPagarPix_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.Location = new System.Drawing.Point(150, 440);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(174, 26);
            this.txtIdentificador.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Identificador";
            // 
            // txtPixChave
            // 
            this.txtPixChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPixChave.Location = new System.Drawing.Point(452, 443);
            this.txtPixChave.Name = "txtPixChave";
            this.txtPixChave.Size = new System.Drawing.Size(174, 26);
            this.txtPixChave.TabIndex = 23;
            this.txtPixChave.Text = "85987704779";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(338, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Chave PIX";
            // 
            // btnConsultaPix
            // 
            this.btnConsultaPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPix.Location = new System.Drawing.Point(228, 373);
            this.btnConsultaPix.Name = "btnConsultaPix";
            this.btnConsultaPix.Size = new System.Drawing.Size(182, 33);
            this.btnConsultaPix.TabIndex = 24;
            this.btnConsultaPix.Text = "Consulta PIX";
            this.btnConsultaPix.UseVisualStyleBackColor = true;
            this.btnConsultaPix.Click += new System.EventHandler(this.btnConsultaPix_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(150, 490);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(173, 26);
            this.txtNomeCliente.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(36, 494);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "Nome";
            // 
            // tabPageItau
            // 
            this.tabPageItau.Controls.Add(this.txtItauCNPJ);
            this.tabPageItau.Controls.Add(this.label30);
            this.tabPageItau.Controls.Add(this.txtItauConta);
            this.tabPageItau.Controls.Add(this.label29);
            this.tabPageItau.Controls.Add(this.txtItauAgencia);
            this.tabPageItau.Controls.Add(this.label28);
            this.tabPageItau.Controls.Add(this.txtItauCertificadoSenha);
            this.tabPageItau.Controls.Add(this.label23);
            this.tabPageItau.Controls.Add(this.txtItauCertificadoCaminho);
            this.tabPageItau.Controls.Add(this.label24);
            this.tabPageItau.Controls.Add(this.txtItauToken);
            this.tabPageItau.Controls.Add(this.label25);
            this.tabPageItau.Controls.Add(this.btnItauGerarToken);
            this.tabPageItau.Controls.Add(this.txtItauClientSecret);
            this.tabPageItau.Controls.Add(this.label26);
            this.tabPageItau.Controls.Add(this.txtItauClientID);
            this.tabPageItau.Controls.Add(this.label27);
            this.tabPageItau.Location = new System.Drawing.Point(4, 22);
            this.tabPageItau.Name = "tabPageItau";
            this.tabPageItau.Size = new System.Drawing.Size(801, 163);
            this.tabPageItau.TabIndex = 4;
            this.tabPageItau.Text = "Itaú";
            this.tabPageItau.UseVisualStyleBackColor = true;
            // 
            // txtItauCertificadoSenha
            // 
            this.txtItauCertificadoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauCertificadoSenha.Location = new System.Drawing.Point(523, 45);
            this.txtItauCertificadoSenha.Name = "txtItauCertificadoSenha";
            this.txtItauCertificadoSenha.Size = new System.Drawing.Size(263, 26);
            this.txtItauCertificadoSenha.TabIndex = 40;
            this.txtItauCertificadoSenha.Text = "G:\\Google Drive\\Desenvolvimento\\Integrações\\Banco Inter\\Nova API\\Inter API_Chave." +
    "key";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(400, 48);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "Senha";
            // 
            // txtItauCertificadoCaminho
            // 
            this.txtItauCertificadoCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauCertificadoCaminho.Location = new System.Drawing.Point(147, 45);
            this.txtItauCertificadoCaminho.Name = "txtItauCertificadoCaminho";
            this.txtItauCertificadoCaminho.Size = new System.Drawing.Size(247, 26);
            this.txtItauCertificadoCaminho.TabIndex = 38;
            this.txtItauCertificadoCaminho.Text = "G:\\Google Drive\\Desenvolvimento\\Integrações\\Banco Inter\\Nova API\\Inter API_Certif" +
    "icado.crt";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(11, 45);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 20);
            this.label24.TabIndex = 37;
            this.label24.Text = "Certificado";
            // 
            // txtItauToken
            // 
            this.txtItauToken.Enabled = false;
            this.txtItauToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauToken.Location = new System.Drawing.Point(147, 117);
            this.txtItauToken.Name = "txtItauToken";
            this.txtItauToken.Size = new System.Drawing.Size(435, 26);
            this.txtItauToken.TabIndex = 36;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(11, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 20);
            this.label25.TabIndex = 35;
            this.label25.Text = "Token";
            // 
            // btnItauGerarToken
            // 
            this.btnItauGerarToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItauGerarToken.Location = new System.Drawing.Point(607, 117);
            this.btnItauGerarToken.Name = "btnItauGerarToken";
            this.btnItauGerarToken.Size = new System.Drawing.Size(182, 33);
            this.btnItauGerarToken.TabIndex = 30;
            this.btnItauGerarToken.Text = "Gerar Token";
            this.btnItauGerarToken.UseVisualStyleBackColor = true;
            this.btnItauGerarToken.Click += new System.EventHandler(this.btnItauGerarToken_Click);
            // 
            // txtItauClientSecret
            // 
            this.txtItauClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauClientSecret.Location = new System.Drawing.Point(523, 13);
            this.txtItauClientSecret.Name = "txtItauClientSecret";
            this.txtItauClientSecret.Size = new System.Drawing.Size(266, 26);
            this.txtItauClientSecret.TabIndex = 34;
            this.txtItauClientSecret.Text = "09bd71c3-3a3b-4ca3-abea-d6f470b0c2d6";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(400, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 20);
            this.label26.TabIndex = 33;
            this.label26.Text = "Client Secret";
            // 
            // txtItauClientID
            // 
            this.txtItauClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauClientID.Location = new System.Drawing.Point(147, 16);
            this.txtItauClientID.Name = "txtItauClientID";
            this.txtItauClientID.Size = new System.Drawing.Size(247, 26);
            this.txtItauClientID.TabIndex = 32;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(11, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 20);
            this.label27.TabIndex = 31;
            this.label27.Text = "Client ID";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(11, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 20);
            this.label28.TabIndex = 41;
            this.label28.Text = "Agencia";
            // 
            // txtItauAgencia
            // 
            this.txtItauAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauAgencia.Location = new System.Drawing.Point(149, 85);
            this.txtItauAgencia.Name = "txtItauAgencia";
            this.txtItauAgencia.Size = new System.Drawing.Size(148, 26);
            this.txtItauAgencia.TabIndex = 42;
            // 
            // txtItauConta
            // 
            this.txtItauConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauConta.Location = new System.Drawing.Point(399, 85);
            this.txtItauConta.Name = "txtItauConta";
            this.txtItauConta.Size = new System.Drawing.Size(148, 26);
            this.txtItauConta.TabIndex = 44;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(317, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 20);
            this.label29.TabIndex = 43;
            this.label29.Text = "Conta";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(554, 88);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 20);
            this.label30.TabIndex = 45;
            this.label30.Text = "CNPJ";
            // 
            // txtItauCNPJ
            // 
            this.txtItauCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItauCNPJ.Location = new System.Drawing.Point(638, 85);
            this.txtItauCNPJ.Name = "txtItauCNPJ";
            this.txtItauCNPJ.Size = new System.Drawing.Size(148, 26);
            this.txtItauCNPJ.TabIndex = 46;
            // 
            // btnConsultarVariosPix
            // 
            this.btnConsultarVariosPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVariosPix.Location = new System.Drawing.Point(425, 373);
            this.btnConsultarVariosPix.Name = "btnConsultarVariosPix";
            this.btnConsultarVariosPix.Size = new System.Drawing.Size(182, 33);
            this.btnConsultarVariosPix.TabIndex = 27;
            this.btnConsultarVariosPix.Text = "Consulta Vários PIX";
            this.btnConsultarVariosPix.UseVisualStyleBackColor = true;
            this.btnConsultarVariosPix.Click += new System.EventHandler(this.btnConsultarVariosPix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 647);
            this.Controls.Add(this.btnConsultarVariosPix);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnConsultaPix);
            this.Controls.Add(this.txtPixChave);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPagarPix);
            this.Controls.Add(this.btnCLientes2023);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtClientes2023);
            this.Controls.Add(this.btnBuscarCobranca);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtCNPJCPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDevolucaoCobranca);
            this.Controls.Add(this.imgQrCode);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cboOperadora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatusCobranca);
            this.Controls.Add(this.btnGerarCobranca);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo de Cobrança";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAsaas.ResumeLayout(false);
            this.tabPageAsaas.PerformLayout();
            this.tabPageInter.ResumeLayout(false);
            this.tabPageInter.PerformLayout();
            this.tabPageGerenciaNet.ResumeLayout(false);
            this.tabPageGerenciaNet.PerformLayout();
            this.tabPageZoop.ResumeLayout(false);
            this.tabPageZoop.PerformLayout();
            this.tabPageItau.ResumeLayout(false);
            this.tabPageItau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarCobranca;
        private System.Windows.Forms.Button btnStatusCobranca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOperadora;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.PictureBox imgQrCode;
        private System.Windows.Forms.Button btnDevolucaoCobranca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGerenciaNet;
        private System.Windows.Forms.TextBox txtGerenciaNetClientSECRET;
        private System.Windows.Forms.TextBox txtGerenciaNetClientID;
        private System.Windows.Forms.TextBox txtGerenciaNetCertificado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGerenciaNetChave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageAsaas;
        private System.Windows.Forms.TabPage tabPageInter;
        private System.Windows.Forms.TextBox txtAsaasChave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCNPJCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnBuscarCobranca;
        private System.Windows.Forms.TextBox txtInterClientSecret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInterClientId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInterToken;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInterGerarToken;
        private System.Windows.Forms.TextBox txtInterScope;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInterCertificado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtInterKey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClientes2023;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCLientes2023;
        private System.Windows.Forms.Button btnPagarPix;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPixChave;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnConsultaPix;
        private System.Windows.Forms.TabPage tabPageZoop;
        private System.Windows.Forms.TextBox txtZoopKey;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtZoopMarketplaceId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtZoopSellerId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPageItau;
        private System.Windows.Forms.TextBox txtItauCertificadoSenha;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtItauCertificadoCaminho;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtItauToken;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnItauGerarToken;
        private System.Windows.Forms.TextBox txtItauClientSecret;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtItauClientID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtItauCNPJ;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtItauConta;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtItauAgencia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnConsultarVariosPix;
    }
}

