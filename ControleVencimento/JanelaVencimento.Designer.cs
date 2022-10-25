namespace ControleVencimento
{
    partial class JanelaVencimento
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
            this.pnlVencimento = new System.Windows.Forms.Panel();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.dgvVencimento = new System.Windows.Forms.DataGridView();
            this.pnlVencimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimento)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVencimento
            // 
            this.pnlVencimento.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlVencimento.Controls.Add(this.lblVencimento);
            this.pnlVencimento.Controls.Add(this.dgvVencimento);
            this.pnlVencimento.Location = new System.Drawing.Point(0, 0);
            this.pnlVencimento.Name = "pnlVencimento";
            this.pnlVencimento.Size = new System.Drawing.Size(633, 433);
            this.pnlVencimento.TabIndex = 0;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVencimento.Location = new System.Drawing.Point(139, 12);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(374, 46);
            this.lblVencimento.TabIndex = 1;
            this.lblVencimento.Text = "Janela Vencimento";
            // 
            // dgvVencimento
            // 
            this.dgvVencimento.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvVencimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencimento.Location = new System.Drawing.Point(31, 61);
            this.dgvVencimento.Name = "dgvVencimento";
            this.dgvVencimento.Size = new System.Drawing.Size(565, 342);
            this.dgvVencimento.TabIndex = 0;
            // 
            // JanelaVencimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 427);
            this.Controls.Add(this.pnlVencimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaVencimento";
            this.Text = "Janela Vencimento";
            this.pnlVencimento.ResumeLayout(false);
            this.pnlVencimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVencimento;
        private System.Windows.Forms.DataGridView dgvVencimento;
        private System.Windows.Forms.Label lblVencimento;
    }
}