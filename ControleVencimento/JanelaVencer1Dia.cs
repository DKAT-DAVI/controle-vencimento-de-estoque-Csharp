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

            dgvVencer1Dias.DataSource = BancoDados.FiltrarVencimento1Dia();
        }
        
        public static JanelaVencer1Dia GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaVencer1Dia();
            }

            return instance; 
        }

        
    }
}
