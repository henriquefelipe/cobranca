
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
            this.tabPageInter = new System.Windows.Forms.TabPage();
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
            this.txtAsaasChave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgQrCode)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAsaas.SuspendLayout();
            this.tabPageGerenciaNet.SuspendLayout();
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
            this.btnStatusCobranca.Location = new System.Drawing.Point(341, 325);
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
            this.label1.Location = new System.Drawing.Point(36, 227);
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
            this.txtValor.Text = "0,01";
            // 
            // imgQrCode
            // 
            this.imgQrCode.Location = new System.Drawing.Point(274, 364);
            this.imgQrCode.Name = "imgQrCode";
            this.imgQrCode.Size = new System.Drawing.Size(314, 271);
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
            // tabPageInter
            // 
            this.tabPageInter.Location = new System.Drawing.Point(4, 22);
            this.tabPageInter.Name = "tabPageInter";
            this.tabPageInter.Size = new System.Drawing.Size(801, 163);
            this.tabPageInter.TabIndex = 2;
            this.tabPageInter.Text = "Banco Inter";
            this.tabPageInter.UseVisualStyleBackColor = true;
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
            this.tabPageGerenciaNet.Padding = new System.Windows.Forms.Padding(3);
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
            // txtAsaasChave
            // 
            this.txtAsaasChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaasChave.Location = new System.Drawing.Point(146, 19);
            this.txtAsaasChave.Name = "txtAsaasChave";
            this.txtAsaasChave.Size = new System.Drawing.Size(639, 26);
            this.txtAsaasChave.TabIndex = 17;
            this.txtAsaasChave.Text = "bc49ff43e4786b4fb4f4c6fb5c896f166c176136ef58764c05a4c86aa2d7d69f";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 647);
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
    }
}

