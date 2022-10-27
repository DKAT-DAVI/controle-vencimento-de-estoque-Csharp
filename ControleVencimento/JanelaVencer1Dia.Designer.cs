namespace ControleVencimento
{
    partial class JanelaVencer1Dia
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
            this.pnlVencer1Dias = new System.Windows.Forms.Panel();
            this.lblVencer1Dias = new System.Windows.Forms.Label();
            this.dgvVencer1Dias = new System.Windows.Forms.DataGridView();
            this.pnlVencer1Dias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencer1Dias)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVencer1Dias
            // 
            this.pnlVencer1Dias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlVencer1Dias.Controls.Add(this.lblVencer1Dias);
            this.pnlVencer1Dias.Controls.Add(this.dgvVencer1Dias);
            this.pnlVencer1Dias.Location = new System.Drawing.Point(-1, -1);
            this.pnlVencer1Dias.Name = "pnlVencer1Dias";
            this.pnlVencer1Dias.Size = new System.Drawing.Size(578, 308);
            this.pnlVencer1Dias.TabIndex = 1;
            // 
            // lblVencer1Dias
            // 
            this.lblVencer1Dias.AutoSize = true;
            this.lblVencer1Dias.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencer1Dias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVencer1Dias.Location = new System.Drawing.Point(61, 16);
            this.lblVencer1Dias.Name = "lblVencer1Dias";
            this.lblVencer1Dias.Size = new System.Drawing.Size(416, 46);
            this.lblVencer1Dias.TabIndex = 1;
            this.lblVencer1Dias.Text = "Vencimento em 1 Dia";
            this.lblVencer1Dias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVencer1Dias
            // 
            this.dgvVencer1Dias.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvVencer1Dias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencer1Dias.Location = new System.Drawing.Point(13, 69);
            this.dgvVencer1Dias.Name = "dgvVencer1Dias";
            this.dgvVencer1Dias.Size = new System.Drawing.Size(544, 222);
            this.dgvVencer1Dias.TabIndex = 0;
            // 
            // JanelaVencer1Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.pnlVencer1Dias);
            this.Name = "JanelaVencer1Dia";
            this.Text = "Vencimento em 1 Dia";
            this.pnlVencer1Dias.ResumeLayout(false);
            this.pnlVencer1Dias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencer1Dias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVencer1Dias;
        private System.Windows.Forms.Label lblVencer1Dias;
        private System.Windows.Forms.DataGridView dgvVencer1Dias;
    }
}