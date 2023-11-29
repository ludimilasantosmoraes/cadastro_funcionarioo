namespace Cadastro_Empresa
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cpf_tx = new System.Windows.Forms.MaskedTextBox();
            this.cnpj_tx = new System.Windows.Forms.MaskedTextBox();
            this.razaoSocial_tx = new System.Windows.Forms.TextBox();
            this.nomeFantasia_tx = new System.Windows.Forms.TextBox();
            this.situacaoCadastral_tx = new System.Windows.Forms.ComboBox();
            this.dataInicio_tx = new System.Windows.Forms.DateTimePicker();
            this.telefone_tx = new System.Windows.Forms.MaskedTextBox();
            this.capitalSocial_tx = new System.Windows.Forms.TextBox();
            this.nomeP_tx = new System.Windows.Forms.TextBox();
            this.naturezaJuridica_tx = new System.Windows.Forms.ComboBox();
            this.estado_tx = new System.Windows.Forms.ComboBox();
            this.endereco_tx = new System.Windows.Forms.TextBox();
            this.cidade_tx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.matriz_tx = new System.Windows.Forms.RadioButton();
            this.filial_tx = new System.Windows.Forms.RadioButton();
            this.grande_tx = new System.Windows.Forms.RadioButton();
            this.pequeno_tx = new System.Windows.Forms.RadioButton();
            this.medio_tx = new System.Windows.Forms.RadioButton();
            this.real_tx = new System.Windows.Forms.RadioButton();
            this.lucroP_tx = new System.Windows.Forms.RadioButton();
            this.simplesN_tx = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(831, 499);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cpf_tx
            // 
            this.cpf_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cpf_tx.Location = new System.Drawing.Point(583, 266);
            this.cpf_tx.Mask = "000,000,000-00";
            this.cpf_tx.Name = "cpf_tx";
            this.cpf_tx.Size = new System.Drawing.Size(173, 20);
            this.cpf_tx.TabIndex = 1;
            // 
            // cnpj_tx
            // 
            this.cnpj_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cnpj_tx.Location = new System.Drawing.Point(283, 145);
            this.cnpj_tx.Mask = "00,000,000/0001-00";
            this.cnpj_tx.Name = "cnpj_tx";
            this.cnpj_tx.Size = new System.Drawing.Size(180, 20);
            this.cnpj_tx.TabIndex = 2;
            // 
            // razaoSocial_tx
            // 
            this.razaoSocial_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.razaoSocial_tx.Location = new System.Drawing.Point(283, 70);
            this.razaoSocial_tx.Name = "razaoSocial_tx";
            this.razaoSocial_tx.Size = new System.Drawing.Size(519, 20);
            this.razaoSocial_tx.TabIndex = 3;
            // 
            // nomeFantasia_tx
            // 
            this.nomeFantasia_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeFantasia_tx.Location = new System.Drawing.Point(283, 107);
            this.nomeFantasia_tx.Name = "nomeFantasia_tx";
            this.nomeFantasia_tx.Size = new System.Drawing.Size(519, 20);
            this.nomeFantasia_tx.TabIndex = 4;
            this.nomeFantasia_tx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // situacaoCadastral_tx
            // 
            this.situacaoCadastral_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.situacaoCadastral_tx.FormattingEnabled = true;
            this.situacaoCadastral_tx.Items.AddRange(new object[] {
            "Ativa",
            "Nula ",
            "Suspensa ",
            "Inapta",
            "Baixada"});
            this.situacaoCadastral_tx.Location = new System.Drawing.Point(283, 187);
            this.situacaoCadastral_tx.Name = "situacaoCadastral_tx";
            this.situacaoCadastral_tx.Size = new System.Drawing.Size(180, 21);
            this.situacaoCadastral_tx.TabIndex = 5;
            // 
            // dataInicio_tx
            // 
            this.dataInicio_tx.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dataInicio_tx.Location = new System.Drawing.Point(595, 355);
            this.dataInicio_tx.Name = "dataInicio_tx";
            this.dataInicio_tx.Size = new System.Drawing.Size(217, 20);
            this.dataInicio_tx.TabIndex = 6;
            // 
            // telefone_tx
            // 
            this.telefone_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone_tx.Location = new System.Drawing.Point(583, 145);
            this.telefone_tx.Mask = "(00) 00000-0000";
            this.telefone_tx.Name = "telefone_tx";
            this.telefone_tx.Size = new System.Drawing.Size(173, 20);
            this.telefone_tx.TabIndex = 7;
            // 
            // capitalSocial_tx
            // 
            this.capitalSocial_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.capitalSocial_tx.Location = new System.Drawing.Point(601, 308);
            this.capitalSocial_tx.Name = "capitalSocial_tx";
            this.capitalSocial_tx.Size = new System.Drawing.Size(132, 20);
            this.capitalSocial_tx.TabIndex = 8;
            // 
            // nomeP_tx
            // 
            this.nomeP_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeP_tx.Location = new System.Drawing.Point(293, 266);
            this.nomeP_tx.Name = "nomeP_tx";
            this.nomeP_tx.Size = new System.Drawing.Size(239, 20);
            this.nomeP_tx.TabIndex = 9;
            // 
            // naturezaJuridica_tx
            // 
            this.naturezaJuridica_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.naturezaJuridica_tx.FormattingEnabled = true;
            this.naturezaJuridica_tx.Items.AddRange(new object[] {
            "EL - Empresário Individual",
            "MEI - Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.naturezaJuridica_tx.Location = new System.Drawing.Point(293, 307);
            this.naturezaJuridica_tx.Name = "naturezaJuridica_tx";
            this.naturezaJuridica_tx.Size = new System.Drawing.Size(170, 21);
            this.naturezaJuridica_tx.TabIndex = 10;
            // 
            // estado_tx
            // 
            this.estado_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estado_tx.FormattingEnabled = true;
            this.estado_tx.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia - BA",
            "Ceará - CE",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO",
            "Distrito Federal - DF"});
            this.estado_tx.Location = new System.Drawing.Point(115, 358);
            this.estado_tx.Name = "estado_tx";
            this.estado_tx.Size = new System.Drawing.Size(180, 21);
            this.estado_tx.TabIndex = 11;
            // 
            // endereco_tx
            // 
            this.endereco_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.endereco_tx.Location = new System.Drawing.Point(142, 460);
            this.endereco_tx.Name = "endereco_tx";
            this.endereco_tx.Size = new System.Drawing.Size(435, 20);
            this.endereco_tx.TabIndex = 12;
            // 
            // cidade_tx
            // 
            this.cidade_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cidade_tx.Location = new System.Drawing.Point(115, 405);
            this.cidade_tx.Name = "cidade_tx";
            this.cidade_tx.Size = new System.Drawing.Size(300, 20);
            this.cidade_tx.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(693, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // matriz_tx
            // 
            this.matriz_tx.AutoSize = true;
            this.matriz_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.matriz_tx.Location = new System.Drawing.Point(3, 3);
            this.matriz_tx.Name = "matriz_tx";
            this.matriz_tx.Size = new System.Drawing.Size(52, 17);
            this.matriz_tx.TabIndex = 15;
            this.matriz_tx.TabStop = true;
            this.matriz_tx.Text = "matriz";
            this.matriz_tx.UseVisualStyleBackColor = false;
            // 
            // filial_tx
            // 
            this.filial_tx.AutoSize = true;
            this.filial_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.filial_tx.Location = new System.Drawing.Point(61, 5);
            this.filial_tx.Name = "filial_tx";
            this.filial_tx.Size = new System.Drawing.Size(42, 17);
            this.filial_tx.TabIndex = 16;
            this.filial_tx.TabStop = true;
            this.filial_tx.Text = "filial";
            this.filial_tx.UseVisualStyleBackColor = false;
            // 
            // grande_tx
            // 
            this.grande_tx.AutoSize = true;
            this.grande_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grande_tx.Location = new System.Drawing.Point(3, 13);
            this.grande_tx.Name = "grande_tx";
            this.grande_tx.Size = new System.Drawing.Size(58, 17);
            this.grande_tx.TabIndex = 17;
            this.grande_tx.TabStop = true;
            this.grande_tx.Text = "grande";
            this.grande_tx.UseVisualStyleBackColor = false;
            // 
            // pequeno_tx
            // 
            this.pequeno_tx.AutoSize = true;
            this.pequeno_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pequeno_tx.Location = new System.Drawing.Point(133, 13);
            this.pequeno_tx.Name = "pequeno_tx";
            this.pequeno_tx.Size = new System.Drawing.Size(67, 17);
            this.pequeno_tx.TabIndex = 18;
            this.pequeno_tx.TabStop = true;
            this.pequeno_tx.Text = "pequeno";
            this.pequeno_tx.UseVisualStyleBackColor = false;
            // 
            // medio_tx
            // 
            this.medio_tx.AutoSize = true;
            this.medio_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.medio_tx.Location = new System.Drawing.Point(71, 13);
            this.medio_tx.Name = "medio_tx";
            this.medio_tx.Size = new System.Drawing.Size(53, 17);
            this.medio_tx.TabIndex = 19;
            this.medio_tx.TabStop = true;
            this.medio_tx.Text = "médio";
            this.medio_tx.UseVisualStyleBackColor = false;
            // 
            // real_tx
            // 
            this.real_tx.AutoSize = true;
            this.real_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.real_tx.Location = new System.Drawing.Point(10, 29);
            this.real_tx.Name = "real_tx";
            this.real_tx.Size = new System.Drawing.Size(47, 17);
            this.real_tx.TabIndex = 20;
            this.real_tx.TabStop = true;
            this.real_tx.Text = "Real";
            this.real_tx.UseVisualStyleBackColor = false;
            this.real_tx.CheckedChanged += new System.EventHandler(this.real_tx_CheckedChanged);
            // 
            // lucroP_tx
            // 
            this.lucroP_tx.AutoSize = true;
            this.lucroP_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lucroP_tx.Location = new System.Drawing.Point(10, 0);
            this.lucroP_tx.Name = "lucroP_tx";
            this.lucroP_tx.Size = new System.Drawing.Size(104, 17);
            this.lucroP_tx.TabIndex = 21;
            this.lucroP_tx.TabStop = true;
            this.lucroP_tx.Text = "Lucro Presumido";
            this.lucroP_tx.UseVisualStyleBackColor = false;
            // 
            // simplesN_tx
            // 
            this.simplesN_tx.AutoSize = true;
            this.simplesN_tx.BackColor = System.Drawing.SystemColors.ControlLight;
            this.simplesN_tx.Location = new System.Drawing.Point(10, 17);
            this.simplesN_tx.Name = "simplesN_tx";
            this.simplesN_tx.Size = new System.Drawing.Size(106, 17);
            this.simplesN_tx.TabIndex = 22;
            this.simplesN_tx.TabStop = true;
            this.simplesN_tx.Text = "Simples Nacional";
            this.simplesN_tx.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lucroP_tx);
            this.panel1.Controls.Add(this.simplesN_tx);
            this.panel1.Controls.Add(this.real_tx);
            this.panel1.Location = new System.Drawing.Point(283, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 46);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.matriz_tx);
            this.panel2.Controls.Add(this.filial_tx);
            this.panel2.Location = new System.Drawing.Point(583, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 22);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.grande_tx);
            this.panel3.Controls.Add(this.pequeno_tx);
            this.panel3.Controls.Add(this.medio_tx);
            this.panel3.Location = new System.Drawing.Point(583, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 33);
            this.panel3.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidade_tx);
            this.Controls.Add(this.endereco_tx);
            this.Controls.Add(this.estado_tx);
            this.Controls.Add(this.naturezaJuridica_tx);
            this.Controls.Add(this.nomeP_tx);
            this.Controls.Add(this.capitalSocial_tx);
            this.Controls.Add(this.telefone_tx);
            this.Controls.Add(this.dataInicio_tx);
            this.Controls.Add(this.situacaoCadastral_tx);
            this.Controls.Add(this.nomeFantasia_tx);
            this.Controls.Add(this.razaoSocial_tx);
            this.Controls.Add(this.cnpj_tx);
            this.Controls.Add(this.cpf_tx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox cpf_tx;
        private System.Windows.Forms.MaskedTextBox cnpj_tx;
        private System.Windows.Forms.TextBox razaoSocial_tx;
        private System.Windows.Forms.TextBox nomeFantasia_tx;
        private System.Windows.Forms.ComboBox situacaoCadastral_tx;
        private System.Windows.Forms.DateTimePicker dataInicio_tx;
        private System.Windows.Forms.MaskedTextBox telefone_tx;
        private System.Windows.Forms.TextBox capitalSocial_tx;
        private System.Windows.Forms.TextBox nomeP_tx;
        private System.Windows.Forms.ComboBox naturezaJuridica_tx;
        private System.Windows.Forms.ComboBox estado_tx;
        private System.Windows.Forms.TextBox endereco_tx;
        private System.Windows.Forms.TextBox cidade_tx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton matriz_tx;
        private System.Windows.Forms.RadioButton filial_tx;
        private System.Windows.Forms.RadioButton grande_tx;
        private System.Windows.Forms.RadioButton pequeno_tx;
        private System.Windows.Forms.RadioButton medio_tx;
        private System.Windows.Forms.RadioButton real_tx;
        private System.Windows.Forms.RadioButton lucroP_tx;
        private System.Windows.Forms.RadioButton simplesN_tx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}