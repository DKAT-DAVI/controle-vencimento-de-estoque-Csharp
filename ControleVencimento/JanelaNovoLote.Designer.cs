namespace ControleVencimento
{
    partial class JanelaNovoLote
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
            this.pnlNovoLote = new System.Windows.Forms.Panel();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNovosLotes = new System.Windows.Forms.ListBox();
            this.lblNovoLote = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.ctxmnuExcluir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNovoLote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.ctxmnuExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNovoLote
            // 
            this.pnlNovoLote.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlNovoLote.Controls.Add(this.dtpDataVencimento);
            this.pnlNovoLote.Controls.Add(this.label2);
            this.pnlNovoLote.Controls.Add(this.lstNovosLotes);
            this.pnlNovoLote.Controls.Add(this.lblNovoLote);
            this.pnlNovoLote.Controls.Add(this.btnCancelar);
            this.pnlNovoLote.Controls.Add(this.btnSalvar);
            this.pnlNovoLote.Controls.Add(this.btnAcrescentar);
            this.pnlNovoLote.Controls.Add(this.nudQuantidade);
            this.pnlNovoLote.Controls.Add(this.txtNome);
            this.pnlNovoLote.Controls.Add(this.txtCodigo);
            this.pnlNovoLote.Controls.Add(this.lstProdutos);
            this.pnlNovoLote.Controls.Add(this.lblQuantidade);
            this.pnlNovoLote.Controls.Add(this.lblNome);
            this.pnlNovoLote.Controls.Add(this.lblCodigo);
            this.pnlNovoLote.Controls.Add(this.lblProduto);
            this.pnlNovoLote.Location = new System.Drawing.Point(-2, -3);
            this.pnlNovoLote.Name = "pnlNovoLote";
            this.pnlNovoLote.Size = new System.Drawing.Size(647, 301);
            this.pnlNovoLote.TabIndex = 1;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimento.Location = new System.Drawing.Point(168, 227);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(104, 22);
            this.dtpDataVencimento.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data de Vencimento: ";
            // 
            // lstNovosLotes
            // 
            this.lstNovosLotes.BackColor = System.Drawing.Color.LightCyan;
            this.lstNovosLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNovosLotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstNovosLotes.FormattingEnabled = true;
            this.lstNovosLotes.ItemHeight = 16;
            this.lstNovosLotes.Location = new System.Drawing.Point(280, 39);
            this.lstNovosLotes.Name = "lstNovosLotes";
            this.lstNovosLotes.Size = new System.Drawing.Size(353, 212);
            this.lstNovosLotes.TabIndex = 29;
            this.lstNovosLotes.DoubleClick += new System.EventHandler(this.lstNovosLotes_DoubleClick);
            this.lstNovosLotes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstNovosLotes_MouseUp);
            // 
            // lblNovoLote
            // 
            this.lblNovoLote.AutoSize = true;
            this.lblNovoLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoLote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNovoLote.Location = new System.Drawing.Point(280, 11);
            this.lblNovoLote.Name = "lblNovoLote";
            this.lblNovoLote.Size = new System.Drawing.Size(132, 25);
            this.lblNovoLote.TabIndex = 28;
            this.lblNovoLote.Text = "Novos Lotes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnCancelar.Location = new System.Drawing.Point(480, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnSalvar.Location = new System.Drawing.Point(566, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 31);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcrescentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcrescentar.Enabled = false;
            this.btnAcrescentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcrescentar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnAcrescentar.Location = new System.Drawing.Point(169, 257);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(102, 31);
            this.btnAcrescentar.TabIndex = 24;
            this.btnAcrescentar.Text = "ACRESCENTAR";
            this.btnAcrescentar.UseVisualStyleBackColor = false;
            this.btnAcrescentar.Click += new System.EventHandler(this.btnAcrescentar_Click);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.BackColor = System.Drawing.Color.LightCyan;
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudQuantidade.Location = new System.Drawing.Point(104, 193);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(166, 26);
            this.nudQuantidade.TabIndex = 23;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightCyan;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(68, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 26);
            this.txtNome.TabIndex = 22;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightCyan;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.Location = new System.Drawing.Point(68, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 26);
            this.txtCodigo.TabIndex = 21;
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.Color.LightCyan;
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 20;
            this.lstProdutos.Location = new System.Drawing.Point(9, 103);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(261, 84);
            this.lstProdutos.TabIndex = 20;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantidade.Location = new System.Drawing.Point(5, 196);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(5, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Location = new System.Drawing.Point(5, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProduto.Location = new System.Drawing.Point(6, 9);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(87, 25);
            this.lblProduto.TabIndex = 14;
            this.lblProduto.Text = "Produto";
            // 
            // ctxmnuExcluir
            // 
            this.ctxmnuExcluir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExcluir});
            this.ctxmnuExcluir.Name = "ctxmnuExcluir";
            this.ctxmnuExcluir.Size = new System.Drawing.Size(121, 28);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mnuExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(120, 24);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mnuExcluir_MouseUp);
            // 
            // JanelaNovoLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 296);
            this.Controls.Add(this.pnlNovoLote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaNovoLote";
            this.Text = "Novo Lote";
            this.pnlNovoLote.ResumeLayout(false);
            this.pnlNovoLote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ctxmnuExcluir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNovoLote;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ListBox lstNovosLotes;
        private System.Windows.Forms.Label lblNovoLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.ContextMenuStrip ctxmnuExcluir;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluir;
    }
}