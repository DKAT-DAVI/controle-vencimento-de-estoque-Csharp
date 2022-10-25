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
    public partial class JanelaVencimento : Form
    {
        public static JanelaVencimento instance;
        private JanelaVencimento()
        {
            InitializeComponent();
        }

        public static JanelaVencimento GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaVencimento();
            }
            
            return instance;
        }
    }
}
