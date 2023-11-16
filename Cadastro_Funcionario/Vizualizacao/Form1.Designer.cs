namespace Cadastro_Funcionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.email_tx = new System.Windows.Forms.TextBox();
            this.estadoCivil_tx = new System.Windows.Forms.TextBox();
            this.telefone_tx = new System.Windows.Forms.TextBox();
            this.funcao_tx = new System.Windows.Forms.TextBox();
            this.cidade_tx = new System.Windows.Forms.TextBox();
            this.nome_tx = new System.Windows.Forms.TextBox();
            this.estado_tx = new System.Windows.Forms.TextBox();
            this.salario_tx = new System.Windows.Forms.TextBox();
            this.endereco_tx = new System.Windows.Forms.TextBox();
            this.rg_tx = new System.Windows.Forms.TextBox();
            this.cpf_tx = new System.Windows.Forms.MaskedTextBox();
            this.datanascimento_tx = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, -4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(789, 495);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // email_tx
            // 
            this.email_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.email_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tx.Location = new System.Drawing.Point(484, 226);
            this.email_tx.Name = "email_tx";
            this.email_tx.Size = new System.Drawing.Size(229, 20);
            this.email_tx.TabIndex = 1;
            // 
            // estadoCivil_tx
            // 
            this.estadoCivil_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estadoCivil_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estadoCivil_tx.Location = new System.Drawing.Point(233, 295);
            this.estadoCivil_tx.Name = "estadoCivil_tx";
            this.estadoCivil_tx.Size = new System.Drawing.Size(202, 20);
            this.estadoCivil_tx.TabIndex = 2;
            this.estadoCivil_tx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // telefone_tx
            // 
            this.telefone_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.telefone_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefone_tx.Location = new System.Drawing.Point(233, 226);
            this.telefone_tx.Name = "telefone_tx";
            this.telefone_tx.Size = new System.Drawing.Size(135, 20);
            this.telefone_tx.TabIndex = 3;
            // 
            // funcao_tx
            // 
            this.funcao_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.funcao_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.funcao_tx.Location = new System.Drawing.Point(484, 295);
            this.funcao_tx.Name = "funcao_tx";
            this.funcao_tx.Size = new System.Drawing.Size(229, 20);
            this.funcao_tx.TabIndex = 4;
            // 
            // cidade_tx
            // 
            this.cidade_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cidade_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidade_tx.Location = new System.Drawing.Point(233, 375);
            this.cidade_tx.Name = "cidade_tx";
            this.cidade_tx.Size = new System.Drawing.Size(202, 20);
            this.cidade_tx.TabIndex = 5;
            // 
            // nome_tx
            // 
            this.nome_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nome_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_tx.Location = new System.Drawing.Point(292, 73);
            this.nome_tx.Name = "nome_tx";
            this.nome_tx.Size = new System.Drawing.Size(465, 20);
            this.nome_tx.TabIndex = 6;
            // 
            // estado_tx
            // 
            this.estado_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.estado_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estado_tx.Location = new System.Drawing.Point(54, 375);
            this.estado_tx.Name = "estado_tx";
            this.estado_tx.Size = new System.Drawing.Size(139, 20);
            this.estado_tx.TabIndex = 7;
            // 
            // salario_tx
            // 
            this.salario_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.salario_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salario_tx.Location = new System.Drawing.Point(484, 375);
            this.salario_tx.Name = "salario_tx";
            this.salario_tx.Size = new System.Drawing.Size(100, 20);
            this.salario_tx.TabIndex = 8;
            this.salario_tx.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // endereco_tx
            // 
            this.endereco_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.endereco_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endereco_tx.Location = new System.Drawing.Point(54, 447);
            this.endereco_tx.Name = "endereco_tx";
            this.endereco_tx.Size = new System.Drawing.Size(530, 20);
            this.endereco_tx.TabIndex = 9;
            // 
            // rg_tx
            // 
            this.rg_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rg_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rg_tx.Location = new System.Drawing.Point(448, 150);
            this.rg_tx.Name = "rg_tx";
            this.rg_tx.Size = new System.Drawing.Size(100, 20);
            this.rg_tx.TabIndex = 10;
            this.rg_tx.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // cpf_tx
            // 
            this.cpf_tx.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cpf_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpf_tx.Location = new System.Drawing.Point(247, 150);
            this.cpf_tx.Mask = "000,000,000-00";
            this.cpf_tx.Name = "cpf_tx";
            this.cpf_tx.Size = new System.Drawing.Size(136, 20);
            this.cpf_tx.TabIndex = 11;
            // 
            // datanascimento_tx
            // 
            this.datanascimento_tx.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.datanascimento_tx.Location = new System.Drawing.Point(567, 150);
            this.datanascimento_tx.Name = "datanascimento_tx";
            this.datanascimento_tx.Size = new System.Drawing.Size(214, 20);
            this.datanascimento_tx.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(636, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datanascimento_tx);
            this.Controls.Add(this.cpf_tx);
            this.Controls.Add(this.rg_tx);
            this.Controls.Add(this.endereco_tx);
            this.Controls.Add(this.salario_tx);
            this.Controls.Add(this.estado_tx);
            this.Controls.Add(this.nome_tx);
            this.Controls.Add(this.cidade_tx);
            this.Controls.Add(this.funcao_tx);
            this.Controls.Add(this.telefone_tx);
            this.Controls.Add(this.estadoCivil_tx);
            this.Controls.Add(this.email_tx);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox email_tx;
        private System.Windows.Forms.TextBox estadoCivil_tx;
        private System.Windows.Forms.TextBox telefone_tx;
        private System.Windows.Forms.TextBox funcao_tx;
        private System.Windows.Forms.TextBox cidade_tx;
        private System.Windows.Forms.TextBox nome_tx;
        private System.Windows.Forms.TextBox estado_tx;
        private System.Windows.Forms.TextBox salario_tx;
        private System.Windows.Forms.TextBox endereco_tx;
        private System.Windows.Forms.TextBox rg_tx;
        private System.Windows.Forms.MaskedTextBox cpf_tx;
        private System.Windows.Forms.DateTimePicker datanascimento_tx;
        private System.Windows.Forms.Button button1;
    }
}

