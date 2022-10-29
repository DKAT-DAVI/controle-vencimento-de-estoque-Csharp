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
    public partial class Form1 : Form
    {
        // Variável Singleton
        private static Form1 instance;
        private Form1()
        {
            InitializeComponent();
            new BancoDados();
        }

        // Método get para nova Janela
        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            
            return instance;
        }

        // Fechar programa pelo menu sair
        private void mnuArquivoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chamando Janela com Todos os Lotes
        private void mnuRelatorioTodosLotes_Click(object sender, EventArgs e)
        {
            TodosLotes j = TodosLotes.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }


        // Chamando Janela de produtos que vencem em 1 dia
        private void mnuRelatorioVencer1Dia_Click(object sender, EventArgs e)
        {
            JanelaVencer1Dia j = JanelaVencer1Dia.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        // Chamando Janela de Produtos que vencem em 5 dias
        private void mnuRelatorioVencer5Dias_Click(object sender, EventArgs e)
        {
            JanelaVencer5Dias j = JanelaVencer5Dias.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        // Chamando Janela de Vencimento Personalizado
        private void mnuRelatorioVencerPersonalizado_Click(object sender, EventArgs e)
        {
            JanelaVencimentoPersonalizado j = new JanelaVencimentoPersonalizado();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        // Chamando janela de novo lote
        private void mnuCadastroNovoLote_Click(object sender, EventArgs e)
        {
            JanelaNovoLote j = JanelaNovoLote.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }

        // Chamando Janela Sobre
        private void mnuArquivoSobre_Click(object sender, EventArgs e)
        {
            JanelaSobre j = JanelaSobre.GetInstance();

            if (j.MdiParent == null)
            {
                j.MdiParent = this;
                j.Show();
            }

            else
            {
                j.WindowState = FormWindowState.Normal;
            }

            j.Activate();
        }
    }
}
