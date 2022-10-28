namespace ControleVencimento
{
    partial class TodosLotes
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
            this.pnlTodosLotes = new System.Windows.Forms.Panel();
            this.lblTodosLotes = new System.Windows.Forms.Label();
            this.dgvTodosLotes = new System.Windows.Forms.DataGridView();
            this.pnlTodosLotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTodosLotes
            // 
            this.pnlTodosLotes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlTodosLotes.Controls.Add(this.lblTodosLotes);
            this.pnlTodosLotes.Controls.Add(this.dgvTodosLotes);
            this.pnlTodosLotes.Location = new System.Drawing.Point(-1, -1);
            this.pnlTodosLotes.Name = "pnlTodosLotes";
            this.pnlTodosLotes.Size = new System.Drawing.Size(576, 306);
            this.pnlTodosLotes.TabIndex = 0;
            // 
            // lblTodosLotes
            // 
            this.lblTodosLotes.AutoSize = true;
            this.lblTodosLotes.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLotes.Location = new System.Drawing.Point(123, 10);
            this.lblTodosLotes.Name = "lblTodosLotes";
            this.lblTodosLotes.Size = new System.Drawing.Size(308, 46);
            this.lblTodosLotes.TabIndex = 1;
            this.lblTodosLotes.Text = "Todos os Lotes";
            this.lblTodosLotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTodosLotes
            // 
            this.dgvTodosLotes.AllowUserToAddRows = false;
            this.dgvTodosLotes.AllowUserToDeleteRows = false;
            this.dgvTodosLotes.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvTodosLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosLotes.Location = new System.Drawing.Point(13, 59);
            this.dgvTodosLotes.Name = "dgvTodosLotes";
            this.dgvTodosLotes.ReadOnly = true;
            this.dgvTodosLotes.Size = new System.Drawing.Size(544, 222);
            this.dgvTodosLotes.TabIndex = 0;
            // 
            // TodosLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 301);
            this.Controls.Add(this.pnlTodosLotes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TodosLotes";
            this.Text = "Todos os Lotes";
            this.pnlTodosLotes.ResumeLayout(false);
            this.pnlTodosLotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTodosLotes;
        private System.Windows.Forms.DataGridView dgvTodosLotes;
        private System.Windows.Forms.Label lblTodosLotes;
    }
}