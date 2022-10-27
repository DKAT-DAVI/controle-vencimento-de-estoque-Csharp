namespace ControleVencimento
{
    partial class JanelaVencimentoPersonalizado
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
            this.pnlVencerPersonalizado = new System.Windows.Forms.Panel();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblVencerPersonalizado = new System.Windows.Forms.Label();
            this.dgvVencerPersonalizado = new System.Windows.Forms.DataGridView();
            this.pnlVencerPersonalizado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencerPersonalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVencerPersonalizado
            // 
            this.pnlVencerPersonalizado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlVencerPersonalizado.Controls.Add(this.dtpData2);
            this.pnlVencerPersonalizado.Controls.Add(this.dtpData1);
            this.pnlVencerPersonalizado.Controls.Add(this.lblData2);
            this.pnlVencerPersonalizado.Controls.Add(this.lblData1);
            this.pnlVencerPersonalizado.Controls.Add(this.lblVencerPersonalizado);
            this.pnlVencerPersonalizado.Controls.Add(this.dgvVencerPersonalizado);
            this.pnlVencerPersonalizado.Location = new System.Drawing.Point(-2, -3);
            this.pnlVencerPersonalizado.Name = "pnlVencerPersonalizado";
            this.pnlVencerPersonalizado.Size = new System.Drawing.Size(576, 308);
            this.pnlVencerPersonalizado.TabIndex = 1;
            // 
            // dtpData2
            // 
            this.dtpData2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData2.Location = new System.Drawing.Point(141, 91);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(276, 22);
            this.dtpData2.TabIndex = 5;
            this.dtpData2.ValueChanged += new System.EventHandler(this.dtpData2_ValueChanged);
            // 
            // dtpData1
            // 
            this.dtpData1.CalendarForeColor = System.Drawing.Color.PaleTurquoise;
            this.dtpData1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpData1.CalendarTitleForeColor = System.Drawing.Color.PaleTurquoise;
            this.dtpData1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData1.Location = new System.Drawing.Point(141, 63);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(276, 22);
            this.dtpData1.TabIndex = 4;
            this.dtpData1.ValueChanged += new System.EventHandler(this.dtpData1_ValueChanged);
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData2.Location = new System.Drawing.Point(84, 91);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(51, 24);
            this.lblData2.TabIndex = 3;
            this.lblData2.Text = "Até:";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblData1.Location = new System.Drawing.Point(14, 62);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(121, 24);
            this.lblData1.TabIndex = 2;
            this.lblData1.Text = "A partir de:";
            // 
            // lblVencerPersonalizado
            // 
            this.lblVencerPersonalizado.AutoSize = true;
            this.lblVencerPersonalizado.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencerPersonalizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVencerPersonalizado.Location = new System.Drawing.Point(56, 11);
            this.lblVencerPersonalizado.Name = "lblVencerPersonalizado";
            this.lblVencerPersonalizado.Size = new System.Drawing.Size(447, 40);
            this.lblVencerPersonalizado.TabIndex = 1;
            this.lblVencerPersonalizado.Text = "Vencimento Personalizado";
            this.lblVencerPersonalizado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvVencerPersonalizado
            // 
            this.dgvVencerPersonalizado.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvVencerPersonalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencerPersonalizado.Location = new System.Drawing.Point(14, 123);
            this.dgvVencerPersonalizado.Name = "dgvVencerPersonalizado";
            this.dgvVencerPersonalizado.Size = new System.Drawing.Size(544, 171);
            this.dgvVencerPersonalizado.TabIndex = 0;
            // 
            // JanelaVencimentoPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.pnlVencerPersonalizado);
            this.Name = "JanelaVencimentoPersonalizado";
            this.Text = "Vencimento Personalizado";
            this.pnlVencerPersonalizado.ResumeLayout(false);
            this.pnlVencerPersonalizado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencerPersonalizado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVencerPersonalizado;
        private System.Windows.Forms.Label lblVencerPersonalizado;
        private System.Windows.Forms.DataGridView dgvVencerPersonalizado;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.DateTimePicker dtpData1;
    }
}