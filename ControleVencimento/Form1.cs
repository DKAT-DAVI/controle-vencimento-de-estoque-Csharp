using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVencimento
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            
            return instance;
        }

        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuRelatorioTodosLotes_Click(object sender, EventArgs e)
        {
            JanelaVencimento j = JanelaVencimento.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        private void mnuRelatorioVencer1Dia_Click(object sender, EventArgs e)
        {
            JanelaVencimento j = JanelaVencimento.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        private void mnuRelatorioVencer2Dia_Click(object sender, EventArgs e)
        {
            JanelaVencimento j = JanelaVencimento.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
                
                
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }
    }
}
