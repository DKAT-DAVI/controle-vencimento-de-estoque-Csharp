namespace ControleVencimento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastroNovoLote = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioTodosLotes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioVencer1Dia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioVencer2Dia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorioVencerPersonalizado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastro,
            this.mnuRelatorios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivoSobre,
            this.mnuArquivoSair});
            this.mnuArquivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mnuArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(75, 23);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSobre
            // 
            this.mnuArquivoSobre.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuArquivoSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuArquivoSobre.Name = "mnuArquivoSobre";
            this.mnuArquivoSobre.Size = new System.Drawing.Size(180, 24);
            this.mnuArquivoSobre.Text = "Sobre";
            // 
            // mnuArquivoSair
            // 
            this.mnuArquivoSair.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuArquivoSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuArquivoSair.Name = "mnuArquivoSair";
            this.mnuArquivoSair.Size = new System.Drawing.Size(180, 24);
            this.mnuArquivoSair.Text = "Sair";
            this.mnuArquivoSair.Click += new System.EventHandler(this.mnuArquivoSair_Click);
            // 
            // mnuCadastro
            // 
            this.mnuCadastro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastroNovoLote});
            this.mnuCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuCadastro.Name = "mnuCadastro";
            this.mnuCadastro.Size = new System.Drawing.Size(81, 23);
            this.mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroNovoLote
            // 
            this.mnuCadastroNovoLote.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuCadastroNovoLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuCadastroNovoLote.Name = "mnuCadastroNovoLote";
            this.mnuCadastroNovoLote.Size = new System.Drawing.Size(180, 24);
            this.mnuCadastroNovoLote.Text = "Novo lote";
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelatorioTodosLotes,
            this.mnuRelatorioVencer1Dia,
            this.mnuRelatorioVencer2Dia,
            this.mnuRelatorioVencerPersonalizado});
            this.mnuRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(89, 23);
            this.mnuRelatorios.Text = "Relatórios";
            // 
            // mnuRelatorioTodosLotes
            // 
            this.mnuRelatorioTodosLotes.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRelatorioTodosLotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuRelatorioTodosLotes.Name = "mnuRelatorioTodosLotes";
            this.mnuRelatorioTodosLotes.Size = new System.Drawing.Size(255, 24);
            this.mnuRelatorioTodosLotes.Text = "Todos Lotes";
            this.mnuRelatorioTodosLotes.Click += new System.EventHandler(this.mnuRelatorioTodosLotes_Click);
            // 
            // mnuRelatorioVencer1Dia
            // 
            this.mnuRelatorioVencer1Dia.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRelatorioVencer1Dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuRelatorioVencer1Dia.Name = "mnuRelatorioVencer1Dia";
            this.mnuRelatorioVencer1Dia.Size = new System.Drawing.Size(255, 24);
            this.mnuRelatorioVencer1Dia.Text = "A vencer em até 1 dia";
            this.mnuRelatorioVencer1Dia.Click += new System.EventHandler(this.mnuRelatorioVencer1Dia_Click);
            // 
            // mnuRelatorioVencer2Dia
            // 
            this.mnuRelatorioVencer2Dia.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRelatorioVencer2Dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuRelatorioVencer2Dia.Name = "mnuRelatorioVencer2Dia";
            this.mnuRelatorioVencer2Dia.Size = new System.Drawing.Size(255, 24);
            this.mnuRelatorioVencer2Dia.Text = "A vencer em até 5 dias";
            this.mnuRelatorioVencer2Dia.Click += new System.EventHandler(this.mnuRelatorioVencer2Dia_Click);
            // 
            // mnuRelatorioVencerPersonalizado
            // 
            this.mnuRelatorioVencerPersonalizado.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRelatorioVencerPersonalizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuRelatorioVencerPersonalizado.Name = "mnuRelatorioVencerPersonalizado";
            this.mnuRelatorioVencerPersonalizado.Size = new System.Drawing.Size(255, 24);
            this.mnuRelatorioVencerPersonalizado.Text = "Vencimento personalizado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vencimento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastroNovoLote;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioTodosLotes;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioVencer1Dia;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioVencer2Dia;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorioVencerPersonalizado;
    }
}

