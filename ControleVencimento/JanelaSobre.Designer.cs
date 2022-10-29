namespace ControleVencimento
{
    partial class JanelaSobre
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
            this.pnlSobre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.pnlSobre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSobre
            // 
            this.pnlSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSobre.Controls.Add(this.lblLink);
            this.pnlSobre.Controls.Add(this.label1);
            this.pnlSobre.Controls.Add(this.pictureBox1);
            this.pnlSobre.Location = new System.Drawing.Point(-4, -1);
            this.pnlSobre.Name = "pnlSobre";
            this.pnlSobre.Size = new System.Drawing.Size(331, 295);
            this.pnlSobre.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ControleVencimento.Properties.Resources.img_profile;
            this.pictureBox1.Location = new System.Drawing.Point(100, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(46, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programa de controle de vencimento de estoque\r\nDesenvolvido por: Davi Kalel Andra" +
    "de Teixeira\r\n\r\nData: 28/10/2022";
            // 
            // lblLink
            // 
            this.lblLink.ActiveLinkColor = System.Drawing.Color.PaleTurquoise;
            this.lblLink.AutoSize = true;
            this.lblLink.LinkColor = System.Drawing.Color.Honeydew;
            this.lblLink.Location = new System.Drawing.Point(26, 269);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(108, 13);
            this.lblLink.TabIndex = 2;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "github.com/dkat-davi";
            this.lblLink.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // JanelaSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 289);
            this.Controls.Add(this.pnlSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaSobre";
            this.Text = "Sobre";
            this.pnlSobre.ResumeLayout(false);
            this.pnlSobre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSobre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Label label1;
    }
}