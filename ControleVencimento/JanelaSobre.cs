using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVencimento
{
    public partial class JanelaSobre : Form
    {
        private static JanelaSobre instance;
        private JanelaSobre()
        {
            InitializeComponent();
        }

        public static JanelaSobre GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaSobre();
            }

            return instance;
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            lblLink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/DKAT-DAVI/controle-vencimento-de-estoque-Csharp");
        }
    }
}
