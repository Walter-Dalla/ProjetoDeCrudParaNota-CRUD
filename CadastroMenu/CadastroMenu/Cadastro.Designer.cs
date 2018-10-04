namespace CadastroMenu
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            this.Nome = new System.Windows.Forms.Label();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CBCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBSItuacao = new System.Windows.Forms.ComboBox();
            this.BTNCadastrar = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(19, 47);
            this.Nome.MaximumSize = new System.Drawing.Size(1000, 100);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(22, 63);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(334, 20);
            this.TXTNome.TabIndex = 1;
            this.TXTNome.Validating += new System.ComponentModel.CancelEventHandler(this.TXTNome_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 110);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 171);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 110);
            this.label3.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data De Nascimento";
            // 
            // DTPDataDeNascimento
            // 
            this.DTPDataDeNascimento.Location = new System.Drawing.Point(156, 129);
            this.DTPDataDeNascimento.Name = "DTPDataDeNascimento";
            this.DTPDataDeNascimento.Size = new System.Drawing.Size(200, 20);
            this.DTPDataDeNascimento.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(425, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CBCargo
            // 
            this.CBCargo.FormattingEnabled = true;
            this.CBCargo.Items.AddRange(new object[] {
            "Disney",
            "Professor",
            "Diretor",
            "Proletariado"});
            this.CBCargo.Location = new System.Drawing.Point(22, 187);
            this.CBCargo.Name = "CBCargo";
            this.CBCargo.Size = new System.Drawing.Size(147, 21);
            this.CBCargo.TabIndex = 10;
            this.CBCargo.Text = "Selecione Uma Opcao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 172);
            this.label4.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salario (000,00)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Situacao";
            // 
            // CBSItuacao
            // 
            this.CBSItuacao.AutoCompleteCustomSource.AddRange(new string[] {
            "Trabalhando",
            "Desempregado",
            "Proletariado"});
            this.CBSItuacao.FormattingEnabled = true;
            this.CBSItuacao.Items.AddRange(new object[] {
            "Trabalhando",
            "Desempregado",
            "Proletariado"});
            this.CBSItuacao.Location = new System.Drawing.Point(22, 252);
            this.CBSItuacao.Name = "CBSItuacao";
            this.CBSItuacao.Size = new System.Drawing.Size(147, 21);
            this.CBSItuacao.TabIndex = 15;
            this.CBSItuacao.Text = "Selecione Uma Opcao";
            // 
            // BTNCadastrar
            // 
            this.BTNCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTNCadastrar.Location = new System.Drawing.Point(67, 301);
            this.BTNCadastrar.Name = "BTNCadastrar";
            this.BTNCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCadastrar.TabIndex = 16;
            this.BTNCadastrar.Text = "Cadastrar";
            this.BTNCadastrar.UseVisualStyleBackColor = true;
            this.BTNCadastrar.Click += new System.EventHandler(this.BTNCadastro);
            this.BTNCadastrar.Validated += new System.EventHandler(this.validatedNome);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTNLimpar.Location = new System.Drawing.Point(149, 301);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpar.TabIndex = 17;
            this.BTNLimpar.Text = "Limpa";
            this.BTNLimpar.UseVisualStyleBackColor = true;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Limpar);
            // 
            // BTNFechar
            // 
            this.BTNFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTNFechar.Location = new System.Drawing.Point(230, 301);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(75, 23);
            this.BTNFechar.TabIndex = 18;
            this.BTNFechar.Text = "Fechar";
            this.BTNFechar.UseVisualStyleBackColor = true;
            this.BTNFechar.Click += new System.EventHandler(this.BTNFechar_Fechar);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(22, 129);
            this.mtxtCPF.Mask = "00.000.000-0";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxtCPF.TabIndex = 19;
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Location = new System.Drawing.Point(175, 188);
            this.mtxtSalario.Mask = "00000,00";
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(181, 20);
            this.mtxtSalario.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 336);
            this.Controls.Add(this.mtxtSalario);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.BTNFechar);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNCadastrar);
            this.Controls.Add(this.CBSItuacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBCargo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DTPDataDeNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNome);
            this.Controls.Add(this.Nome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPDataDeNascimento;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox CBCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBSItuacao;
        private System.Windows.Forms.Button BTNCadastrar;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNFechar;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtSalario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}