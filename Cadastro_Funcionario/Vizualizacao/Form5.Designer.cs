namespace Cadastro_Funcionario.Vizualizacao
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CadastrarFuncionario = new System.Windows.Forms.Button();
            this.ConsultarEmpresa = new System.Windows.Forms.Button();
            this.CadastrarEmpresa = new System.Windows.Forms.Button();
            this.ConsultarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarFuncionario
            // 
            this.CadastrarFuncionario.BackColor = System.Drawing.SystemColors.GrayText;
            this.CadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarFuncionario.Location = new System.Drawing.Point(501, 282);
            this.CadastrarFuncionario.Name = "CadastrarFuncionario";
            this.CadastrarFuncionario.Size = new System.Drawing.Size(190, 37);
            this.CadastrarFuncionario.TabIndex = 2;
            this.CadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.CadastrarFuncionario.UseVisualStyleBackColor = false;
            this.CadastrarFuncionario.Click += new System.EventHandler(this.CadastrarFuncionario_Click);
            // 
            // ConsultarEmpresa
            // 
            this.ConsultarEmpresa.BackColor = System.Drawing.SystemColors.GrayText;
            this.ConsultarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsultarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarEmpresa.Location = new System.Drawing.Point(161, 359);
            this.ConsultarEmpresa.Name = "ConsultarEmpresa";
            this.ConsultarEmpresa.Size = new System.Drawing.Size(179, 37);
            this.ConsultarEmpresa.TabIndex = 3;
            this.ConsultarEmpresa.Text = "Consultar Empresas";
            this.ConsultarEmpresa.UseVisualStyleBackColor = false;
            this.ConsultarEmpresa.Click += new System.EventHandler(this.ConsultarEmpresa_Click);
            // 
            // CadastrarEmpresa
            // 
            this.CadastrarEmpresa.BackColor = System.Drawing.SystemColors.GrayText;
            this.CadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CadastrarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarEmpresa.Location = new System.Drawing.Point(161, 282);
            this.CadastrarEmpresa.Name = "CadastrarEmpresa";
            this.CadastrarEmpresa.Size = new System.Drawing.Size(183, 37);
            this.CadastrarEmpresa.TabIndex = 4;
            this.CadastrarEmpresa.Text = "Cadastrar Empresa";
            this.CadastrarEmpresa.UseVisualStyleBackColor = false;
            this.CadastrarEmpresa.Click += new System.EventHandler(this.CadastrarEmpresa_Click);
            // 
            // ConsultarFuncionario
            // 
            this.ConsultarFuncionario.BackColor = System.Drawing.SystemColors.GrayText;
            this.ConsultarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConsultarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarFuncionario.Location = new System.Drawing.Point(501, 359);
            this.ConsultarFuncionario.Name = "ConsultarFuncionario";
            this.ConsultarFuncionario.Size = new System.Drawing.Size(190, 37);
            this.ConsultarFuncionario.TabIndex = 5;
            this.ConsultarFuncionario.Text = "Consultar Funcionário";
            this.ConsultarFuncionario.UseVisualStyleBackColor = false;
            this.ConsultarFuncionario.Click += new System.EventHandler(this.ConsultarFuncionario_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsultarFuncionario);
            this.Controls.Add(this.CadastrarEmpresa);
            this.Controls.Add(this.ConsultarEmpresa);
            this.Controls.Add(this.CadastrarFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CadastrarFuncionario;
        private System.Windows.Forms.Button ConsultarEmpresa;
        private System.Windows.Forms.Button CadastrarEmpresa;
        private System.Windows.Forms.Button ConsultarFuncionario;
    }
}