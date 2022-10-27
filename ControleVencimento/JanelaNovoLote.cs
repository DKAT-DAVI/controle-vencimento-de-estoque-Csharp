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
    public partial class JanelaNovoLote : Form
    {
        private static JanelaNovoLote instance;
        private JanelaNovoLote()
        {
            InitializeComponent();
        }

        public static JanelaNovoLote GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaNovoLote();
            }

            return instance;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
