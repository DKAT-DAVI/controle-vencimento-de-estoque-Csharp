namespace ControleVencimento
{
    partial class JanelaVencer5Dias
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
            this.pnlVencer5Dias = new System.Windows.Forms.Panel();
            this.lblVencer5Dias = new System.Windows.Forms.Label();
            this.dgvVencer5Dias = new System.Windows.Forms.DataGridView();
            this.imgReload = new System.Windows.Forms.PictureBox();
            this.pnlVencer5Dias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencer5Dias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReload)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVencer5Dias
            // 
            this.pnlVencer5Dias.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlVencer5Dias.Controls.Add(this.imgReload);
            this.pnlVencer5Dias.Controls.Add(this.lblVencer5Dias);
            this.pnlVencer5Dias.Controls.Add(this.dgvVencer5Dias);
            this.pnlVencer5Dias.Location = new System.Drawing.Point(-1, -1);
            this.pnlVencer5Dias.Name = "pnlVencer5Dias";
            this.pnlVencer5Dias.Size = new System.Drawing.Size(578, 305);
            this.pnlVencer5Dias.TabIndex = 1;
            // 
            // lblVencer5Dias
            // 
            this.lblVencer5Dias.AutoSize = true;
            this.lblVencer5Dias.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencer5Dias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVencer5Dias.Location = new System.Drawing.Point(72, 10);
            this.lblVencer5Dias.Name = "lblVencer5Dias";
            this.lblVencer5Dias.Size = new System.Drawing.Size(438, 46);
            this.lblVencer5Dias.TabIndex = 1;
            this.lblVencer5Dias.Text = "Vencimento em 5 Dias";
            this.lblVencer5Dias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVencer5Dias
            // 
            this.dgvVencer5Dias.AllowUserToAddRows = false;
            this.dgvVencer5Dias.AllowUserToDeleteRows = false;
            this.dgvVencer5Dias.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvVencer5Dias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencer5Dias.Location = new System.Drawing.Point(13, 65);
            this.dgvVencer5Dias.Name = "dgvVencer5Dias";
            this.dgvVencer5Dias.ReadOnly = true;
            this.dgvVencer5Dias.Size = new System.Drawing.Size(544, 222);
            this.dgvVencer5Dias.TabIndex = 0;
            // 
            // imgReload
            // 
            this.imgReload.Image = global::ControleVencimento.Properties.Resources.reload;
            this.imgReload.Location = new System.Drawing.Point(22, 19);
            this.imgReload.Name = "imgReload";
            this.imgReload.Size = new System.Drawing.Size(34, 28);
            this.imgReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgReload.TabIndex = 2;
            this.imgReload.TabStop = false;
            this.imgReload.Click += new System.EventHandler(this.imgReload_Click);
            // 
            // JanelaVencer5Dias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.pnlVencer5Dias);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "JanelaVencer5Dias";
            this.Text = "Vencimento em 5 Dias";
            this.pnlVencer5Dias.ResumeLayout(false);
            this.pnlVencer5Dias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencer5Dias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVencer5Dias;
        private System.Windows.Forms.Label lblVencer5Dias;
        private System.Windows.Forms.DataGridView dgvVencer5Dias;
        private System.Windows.Forms.PictureBox imgReload;
    }
}