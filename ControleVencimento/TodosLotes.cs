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
        // Variável Singleton
        public static TodosLotes instance;

        private TodosLotes()
        {
            InitializeComponent();

            // Ligando o DataSource ao Banco de Dados
            dgvTodosLotes.DataSource = BancoDados.Compras;

            BancoDados.ConfigurarDataGridView(dgvTodosLotes);
        }

        // Método get para chamar a janela
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
