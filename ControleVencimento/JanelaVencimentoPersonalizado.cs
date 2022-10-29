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
        public JanelaVencimentoPersonalizado()
        {
            InitializeComponent();
        }

        // A cada vez que a data é atualizada, o DataSource do DataGridView tbm é atualizado passando pela filtragem
        private void dtpData1_ValueChanged(object sender, EventArgs e)
        {
            dgvVencerPersonalizado.DataSource = BancoDados.FiltrarVencimentoPersonalizado(dtpData1.Value.Date, dtpData2.Value.Date);
            BancoDados.ConfigurarDataGridView(dgvVencerPersonalizado);
        }

        private void dtpData2_ValueChanged(object sender, EventArgs e)
        {
            dgvVencerPersonalizado.DataSource = BancoDados.FiltrarVencimentoPersonalizado(dtpData1.Value.Date, dtpData2.Value.Date);
            BancoDados.ConfigurarDataGridView(dgvVencerPersonalizado);
        }

        private void imgReload_Click(object sender, EventArgs e)
        {
            dgvVencerPersonalizado.DataSource = BancoDados.FiltrarVencimentoPersonalizado(dtpData1.Value.Date, dtpData2.Value.Date);
        }
    }
}
