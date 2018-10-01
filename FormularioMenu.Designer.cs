namespace CadastroMenu
{
    partial class FormularioMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioPorNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.AbrirCadastroDeFuncionariosClick);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioPorCodigoToolStripMenuItem,
            this.funcionarioPorNomeToolStripMenuItem,
            this.todosOsFuncionariosToolStripMenuItem,
            this.geraisToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // funcionarioPorCodigoToolStripMenuItem
            // 
            this.funcionarioPorCodigoToolStripMenuItem.Name = "funcionarioPorCodigoToolStripMenuItem";
            this.funcionarioPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.funcionarioPorCodigoToolStripMenuItem.Text = "Funcionario por codigo";
            // 
            // funcionarioPorNomeToolStripMenuItem
            // 
            this.funcionarioPorNomeToolStripMenuItem.Name = "funcionarioPorNomeToolStripMenuItem";
            this.funcionarioPorNomeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.funcionarioPorNomeToolStripMenuItem.Text = "Funcionario por nome";
            // 
            // todosOsFuncionariosToolStripMenuItem
            // 
            this.todosOsFuncionariosToolStripMenuItem.Name = "todosOsFuncionariosToolStripMenuItem";
            this.todosOsFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.todosOsFuncionariosToolStripMenuItem.Text = "Todos os funcionarios";
            // 
            // geraisToolStripMenuItem
            // 
            this.geraisToolStripMenuItem.Name = "geraisToolStripMenuItem";
            this.geraisToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.geraisToolStripMenuItem.Text = "Gerais";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairClick);
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 305);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioMenu";
            this.Text = "Sistema De Cadastro De Funcionarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioPorNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

