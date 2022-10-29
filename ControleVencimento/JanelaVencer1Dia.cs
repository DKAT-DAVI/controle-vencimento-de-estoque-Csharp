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
    public partial class JanelaVencer1Dia : Form
    {
        private static JanelaVencer1Dia instance;
        private JanelaVencer1Dia()
        {
            InitializeComponent();

            dgvVencer1Dia.DataSource = BancoDados.FiltrarVencimento(1);
            BancoDados.ConfigurarDataGridView(dgvVencer1Dia);
        }
        
        public static JanelaVencer1Dia GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaVencer1Dia();
            }

            return instance; 
        }

        private void imgReload_Click(object sender, EventArgs e)
        {
            dgvVencer1Dia.DataSource = BancoDados.FiltrarVencimento(1);
        }
    }
}
