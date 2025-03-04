
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
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAsaas.SuspendLayout();
            this.tabPageInter.SuspendLayout();
            this.tabPageGerenciaNet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarCobranca
            // 
            this.btnGerarCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCobranca.Location = new System.Drawing.Point(53, 400);
            this.btnGerarCobranca.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerarCobranca.Name = "btnGerarCobranca";
            this.btnGerarCobranca.Size = new System.Drawing.Size(243, 41);
            this.btnGerarCobranca.TabIndex = 0;
            this.btnGerarCobranca.Text = "Gerar Cobrança";
            this.btnGerarCobranca.UseVisualStyleBackColor = true;
            this.btnGerarCobranca.Click += new System.EventHandler(this.btnGerarCobranca_Click);
            // 
            // btnStatusCobranca
            // 
            this.btnStatusCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusCobranca.Location = new System.Drawing.Point(567, 400);
            this.btnStatusCobranca.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatusCobranca.Name = "btnStatusCobranca";
            this.btnStatusCobranca.Size = new System.Drawing.Size(205, 41);
            this.btnStatusCobranca.TabIndex = 1;
            this.btnStatusCobranca.Text = "Status Cobrança";
            this.btnStatusCobranca.UseVisualStyleBackColor = true;
            this.btnStatusCobranca.Click += new System.EventHandler(this.btnStatusCobranca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // cboOperadora
            // 
            this.cboOperadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperadora.FormattingEnabled = true;
            this.cboOperadora.Location = new System.Drawing.Point(229, 270);
            this.cboOperadora.Margin = new System.Windows.Forms.Padding(4);
            this.cboOperadora.Name = "cboOperadora";
            this.cboOperadora.Size = new System.Drawing.Size(328, 33);
            this.cboOperadora.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(229, 340);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(229, 30);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "5,00";
            // 
            // imgQrCode
            // 
            this.imgQrCode.Location = new System.Drawing.Point(868, 533);
            this.imgQrCode.Margin = new System.Windows.Forms.Padding(4);
            this.imgQrCode.Name = "imgQrCode";
            this.imgQrCode.Size = new System.Drawing.Size(235, 260);
            this.imgQrCode.TabIndex = 6;
            this.imgQrCode.TabStop = false;
            // 
            // btnDevolucaoCobranca
            // 
            this.btnDevolucaoCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucaoCobranca.Location = new System.Drawing.Point(819, 400);
            this.btnDevolucaoCobranca.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevolucaoCobranca.Name = "btnDevolucaoCobranca";
            this.btnDevolucaoCobranca.Size = new System.Drawing.Size(263, 41);
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
            this.tabControl1.Location = new System.Drawing.Point(29, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 233);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPageAsaas
            // 
            this.tabPageAsaas.Controls.Add(this.txtAsaasChave);
            this.tabPageAsaas.Controls.Add(this.label8);
            this.tabPageAsaas.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsaas.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAsaas.Name = "tabPageAsaas";
            this.tabPageAsaas.Size = new System.Drawing.Size(1071, 204);
            this.tabPageAsaas.TabIndex = 1;
            this.tabPageAsaas.Text = "Asaas";
            this.tabPageAsaas.UseVisualStyleBackColor = true;
            // 
            // txtAsaasChave
            // 
            this.txtAsaasChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaasChave.Location = new System.Drawing.Point(195, 23);
            this.txtAsaasChave.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsaasChave.Name = "txtAsaasChave";
            this.txtAsaasChave.Size = new System.Drawing.Size(851, 30);
            this.txtAsaasChave.TabIndex = 17;
            this.txtAsaasChave.Text = "b7f9db5e7f5278b9daa2d378874fed46efc095b620dea4316f2df087ac35b661";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
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
            this.tabPageInter.Location = new System.Drawing.Point(4, 25);
            this.tabPageInter.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageInter.Name = "tabPageInter";
            this.tabPageInter.Size = new System.Drawing.Size(1071, 204);
            this.tabPageInter.TabIndex = 2;
            this.tabPageInter.Text = "Banco Inter";
            this.tabPageInter.UseVisualStyleBackColor = true;
            // 
            // txtInterKey
            // 
            this.txtInterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterKey.Location = new System.Drawing.Point(696, 98);
            this.txtInterKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterKey.Name = "txtInterKey";
            this.txtInterKey.Size = new System.Drawing.Size(349, 30);
            this.txtInterKey.TabIndex = 29;
            this.txtInterKey.Text = "G:\\Google Drive\\Desenvolvimento\\Integrações\\Banco Inter\\Nova API\\Inter API_Chave." +
    "key";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(532, 102);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 31);
            this.label15.TabIndex = 28;
            this.label15.Text = "Senha";
            // 
            // txtInterCertificado
            // 
            this.txtInterCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterCertificado.Location = new System.Drawing.Point(195, 98);
            this.txtInterCertificado.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterCertificado.Name = "txtInterCertificado";
            this.txtInterCertificado.Size = new System.Drawing.Size(328, 30);
            this.txtInterCertificado.TabIndex = 27;
            this.txtInterCertificado.Text = "G:\\Google Drive\\Desenvolvimento\\Integrações\\Banco Inter\\Nova API\\Inter API_Certif" +
    "icado.crt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Certificado";
            // 
            // txtInterScope
            // 
            this.txtInterScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterScope.Location = new System.Drawing.Point(195, 59);
            this.txtInterScope.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterScope.Name = "txtInterScope";
            this.txtInterScope.Size = new System.Drawing.Size(855, 30);
            this.txtInterScope.TabIndex = 25;
            this.txtInterScope.Text = "extrato.read boleto-cobranca.read boleto-cobranca.write pagamento-pix.write pagam" +
    "ento-pix.read";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Scope";
            // 
            // txtInterToken
            // 
            this.txtInterToken.Enabled = false;
            this.txtInterToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterToken.Location = new System.Drawing.Point(195, 144);
            this.txtInterToken.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterToken.Name = "txtInterToken";
            this.txtInterToken.Size = new System.Drawing.Size(579, 30);
            this.txtInterToken.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Token";
            // 
            // btnInterGerarToken
            // 
            this.btnInterGerarToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterGerarToken.Location = new System.Drawing.Point(808, 144);
            this.btnInterGerarToken.Margin = new System.Windows.Forms.Padding(4);
            this.btnInterGerarToken.Name = "btnInterGerarToken";
            this.btnInterGerarToken.Size = new System.Drawing.Size(243, 41);
            this.btnInterGerarToken.TabIndex = 16;
            this.btnInterGerarToken.Text = "Gerar Token";
            this.btnInterGerarToken.UseVisualStyleBackColor = true;
            this.btnInterGerarToken.Click += new System.EventHandler(this.btnInterGerarToken_Click);
            // 
            // txtInterClientSecret
            // 
            this.txtInterClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterClientSecret.Location = new System.Drawing.Point(696, 16);
            this.txtInterClientSecret.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterClientSecret.Name = "txtInterClientSecret";
            this.txtInterClientSecret.Size = new System.Drawing.Size(353, 30);
            this.txtInterClientSecret.TabIndex = 21;
            this.txtInterClientSecret.Text = "09bd71c3-3a3b-4ca3-abea-d6f470b0c2d6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(532, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Client Secret";
            // 
            // txtInterClientId
            // 
            this.txtInterClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterClientId.Location = new System.Drawing.Point(195, 20);
            this.txtInterClientId.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterClientId.Name = "txtInterClientId";
            this.txtInterClientId.Size = new System.Drawing.Size(328, 30);
            this.txtInterClientId.TabIndex = 19;
            this.txtInterClientId.Text = "b5418546-9857-4b3c-9f0d-9eb90e2619db";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
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
            this.tabPageGerenciaNet.Location = new System.Drawing.Point(4, 25);
            this.tabPageGerenciaNet.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGerenciaNet.Name = "tabPageGerenciaNet";
            this.tabPageGerenciaNet.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGerenciaNet.Size = new System.Drawing.Size(1071, 204);
            this.tabPageGerenciaNet.TabIndex = 0;
            this.tabPageGerenciaNet.Text = "GerenciaNet";
            this.tabPageGerenciaNet.UseVisualStyleBackColor = true;
            // 
            // txtGerenciaNetChave
            // 
            this.txtGerenciaNetChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetChave.Location = new System.Drawing.Point(195, 154);
            this.txtGerenciaNetChave.Margin = new System.Windows.Forms.Padding(4);
            this.txtGerenciaNetChave.Name = "txtGerenciaNetChave";
            this.txtGerenciaNetChave.Size = new System.Drawing.Size(851, 30);
            this.txtGerenciaNetChave.TabIndex = 15;
            this.txtGerenciaNetChave.Text = "fb1ccee9-5e64-414c-bd8b-b3a2f7060100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chave";
            // 
            // txtGerenciaNetClientSECRET
            // 
            this.txtGerenciaNetClientSECRET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetClientSECRET.Location = new System.Drawing.Point(195, 111);
            this.txtGerenciaNetClientSECRET.Margin = new System.Windows.Forms.Padding(4);
            this.txtGerenciaNetClientSECRET.Name = "txtGerenciaNetClientSECRET";
            this.txtGerenciaNetClientSECRET.Size = new System.Drawing.Size(851, 30);
            this.txtGerenciaNetClientSECRET.TabIndex = 13;
            this.txtGerenciaNetClientSECRET.Text = "Client_Secret_d96e22652c7c89fa335ae2cc913c5e221fdaab10";
            // 
            // txtGerenciaNetClientID
            // 
            this.txtGerenciaNetClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetClientID.Location = new System.Drawing.Point(195, 65);
            this.txtGerenciaNetClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtGerenciaNetClientID.Name = "txtGerenciaNetClientID";
            this.txtGerenciaNetClientID.Size = new System.Drawing.Size(851, 30);
            this.txtGerenciaNetClientID.TabIndex = 12;
            this.txtGerenciaNetClientID.Text = "Client_Id_066bc1dd146920d241ca0d89ae1d31535e5afd92";
            // 
            // txtGerenciaNetCertificado
            // 
            this.txtGerenciaNetCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerenciaNetCertificado.Location = new System.Drawing.Point(195, 17);
            this.txtGerenciaNetCertificado.Margin = new System.Windows.Forms.Padding(4);
            this.txtGerenciaNetCertificado.Name = "txtGerenciaNetCertificado";
            this.txtGerenciaNetCertificado.Size = new System.Drawing.Size(851, 30);
            this.txtGerenciaNetCertificado.TabIndex = 9;
            this.txtGerenciaNetCertificado.Text = "C:\\certificadoProducao.p12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Client_SECRET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Certificado";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(779, 270);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(328, 33);
            this.cboTipo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tipo";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(53, 656);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(243, 41);
            this.btnBuscarCliente.TabIndex = 11;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCNPJCPF
            // 
            this.txtCNPJCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJCPF.Location = new System.Drawing.Point(200, 603);
            this.txtCNPJCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNPJCPF.Name = "txtCNPJCPF";
            this.txtCNPJCPF.Size = new System.Drawing.Size(229, 30);
            this.txtCNPJCPF.TabIndex = 13;
            this.txtCNPJCPF.Text = "51608691071";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 606);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "CPF/CNPJ";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(316, 656);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(243, 41);
            this.btnCadastrarCliente.TabIndex = 14;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnBuscarCobranca
            // 
            this.btnBuscarCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCobranca.Location = new System.Drawing.Point(304, 400);
            this.btnBuscarCobranca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCobranca.Name = "btnBuscarCobranca";
            this.btnBuscarCobranca.Size = new System.Drawing.Size(243, 41);
            this.btnBuscarCobranca.TabIndex = 15;
            this.btnBuscarCobranca.Text = "Buscar Cobrança";
            this.btnBuscarCobranca.UseVisualStyleBackColor = true;
            this.btnBuscarCobranca.Click += new System.EventHandler(this.btnBuscarCobranca_Click);
            // 
            // txtClientes2023
            // 
            this.txtClientes2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientes2023.Location = new System.Drawing.Point(228, 721);
            this.txtClientes2023.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientes2023.Name = "txtClientes2023";
            this.txtClientes2023.Size = new System.Drawing.Size(229, 30);
            this.txtClientes2023.TabIndex = 16;
            this.txtClientes2023.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(77, 726);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Clientes 2023";
            // 
            // btnCLientes2023
            // 
            this.btnCLientes2023.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLientes2023.Location = new System.Drawing.Point(475, 718);
            this.btnCLientes2023.Margin = new System.Windows.Forms.Padding(4);
            this.btnCLientes2023.Name = "btnCLientes2023";
            this.btnCLientes2023.Size = new System.Drawing.Size(183, 41);
            this.btnCLientes2023.TabIndex = 18;
            this.btnCLientes2023.Text = "Buscar";
            this.btnCLientes2023.UseVisualStyleBackColor = true;
            this.btnCLientes2023.Click += new System.EventHandler(this.btnCLientes2023_Click);
            // 
            // btnPagarPix
            // 
            this.btnPagarPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarPix.Location = new System.Drawing.Point(53, 459);
            this.btnPagarPix.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagarPix.Name = "btnPagarPix";
            this.btnPagarPix.Size = new System.Drawing.Size(243, 41);
            this.btnPagarPix.TabIndex = 19;
            this.btnPagarPix.Text = "Pagar PIX";
            this.btnPagarPix.UseVisualStyleBackColor = true;
            this.btnPagarPix.Click += new System.EventHandler(this.btnPagarPix_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.Location = new System.Drawing.Point(200, 542);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(230, 30);
            this.txtIdentificador.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 545);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 25);
            this.label17.TabIndex = 20;
            this.label17.Text = "Identificador";
            // 
            // txtPixChave
            // 
            this.txtPixChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPixChave.Location = new System.Drawing.Point(602, 545);
            this.txtPixChave.Margin = new System.Windows.Forms.Padding(4);
            this.txtPixChave.Name = "txtPixChave";
            this.txtPixChave.Size = new System.Drawing.Size(230, 30);
            this.txtPixChave.TabIndex = 23;
            this.txtPixChave.Text = "85987704779";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(450, 548);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 31);
            this.label18.TabIndex = 22;
            this.label18.Text = "Chave PIX";
            // 
            // btnConsultaPix
            // 
            this.btnConsultaPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaPix.Location = new System.Drawing.Point(304, 459);
            this.btnConsultaPix.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaPix.Name = "btnConsultaPix";
            this.btnConsultaPix.Size = new System.Drawing.Size(243, 41);
            this.btnConsultaPix.TabIndex = 24;
            this.btnConsultaPix.Text = "Consulta PIX";
            this.btnConsultaPix.UseVisualStyleBackColor = true;
            this.btnConsultaPix.Click += new System.EventHandler(this.btnConsultaPix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 796);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

