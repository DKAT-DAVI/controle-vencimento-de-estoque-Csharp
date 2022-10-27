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
    public partial class JanelaVencimentoPersonalizado : Form
    {
        private static JanelaVencimentoPersonalizado instance;
        private JanelaVencimentoPersonalizado()
        {
            InitializeComponent();
        }

        public static JanelaVencimentoPersonalizado GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaVencimentoPersonalizado();
            }

            return instance;
        }

        private void dtpData1_ValueChanged(object sender, EventArgs e)
        {
            dgvVencerPersonalizado.DataSource = BancoDados.FiltrarVencimentoPersonalizado(dtpData1.Value, dtpData2.Value);
        }

        private void dtpData2_ValueChanged(object sender, EventArgs e)
        {
            dgvVencerPersonalizado.DataSource = BancoDados.FiltrarVencimentoPersonalizado(dtpData1.Value, dtpData2.Value);
        }
    }
}
