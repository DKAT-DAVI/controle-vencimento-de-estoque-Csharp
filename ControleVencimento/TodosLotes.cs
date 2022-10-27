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
    public partial class TodosLotes : Form
    {
        public static TodosLotes instance;

        private TodosLotes()
        {
            InitializeComponent();

            dgvTodosLotes.DataSource = BancoDados.Compras;
        }

        public static TodosLotes GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TodosLotes();
            }
            
            return instance;
        }        
    }
}
