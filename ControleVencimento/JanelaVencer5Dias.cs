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
    public partial class JanelaVencer5Dias : Form
    {
        private static JanelaVencer5Dias instance;

        public JanelaVencer5Dias()
        {
            InitializeComponent();

            dgvVencer5Dias.DataSource = BancoDados.FiltrarVencimento5Dias();
        }

        public static JanelaVencer5Dias GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaVencer5Dias();
            }

            return instance;
        }
    }
}
