using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControleVencimento
{
    public partial class JanelaNovoLote : Form
    {
        // Variavel Singleton
        private static JanelaNovoLote instance;
        private JanelaNovoLote()
        {
            InitializeComponent();
        }

        // Método get para abrir uma instancia de janela
        public static JanelaNovoLote GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaNovoLote();
            }

            return instance;
        }

        // Fechar a janela pelo click no botao sair
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Buscar Produto para novo lote de compra

        // Buscar pelo código do produto
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            // Reseta a lista de produtos para evitar conflitos
            lstProdutos.DataSource = null;
            lstProdutos.Items.Clear();

            // Verifica se a textBox não está vazia e se o código digitado é um código numérico
            if (txtCodigo.Text != String.Empty
                && Regex.IsMatch(txtCodigo.Text, "^[0-9]+$"))
            {
                // Verifica se o método LocalizarProdutoPorCodigo() está retornando null
                if (BancoDados.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)) != null)
                {

                    // Adiciona o produto referente ao código digitado na lstProdutos
                    lstProdutos.Items.Add(BancoDados.LocalizarProdutoPorCodigo(Convert.ToInt64(txtCodigo.Text)));

                    // Reseta a caixa de busca por nome
                    txtNome.Text = null;

                    // Seleciona o item na lstProdutos
                    lstProdutos.SelectedIndex = 0;

                }
            }

            // Faz a verificação de habilitação do botão ACRESCENTAR
            HabilitarBotaoAcrescentar();
        }

        // Buscar produto por parte do nome
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            // Limpa a txtBox de busca por código
            txtCodigo.Text = null;

            // O DataSource da lista de produtos recebe a lista retornada do método LocalizarProdutoPorParteNome()
            lstProdutos.DataSource = BancoDados.LocalizarProdutoPorParteNome(txtNome.Text);

            // Faz a verificação de habilitação do botão ACRESCENTAR
            HabilitarBotaoAcrescentar();
        }

        // Acrescentando um novo lote

        // Botao para acrescentar um novo lote na lista de lotes
        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            // Verificar data de vencimento
            if (dtpDataVencimento.Value <= DateTime.Now)
            {
                MessageBox.Show("LOTE FORA DO PRAZO DE VALIDADE!");
            }
            else
            { 
                // Cria a compra principal que vai receber os valores transportados da compraAuxiliar
                Compra compra = new Compra((Produto)lstProdutos.SelectedItem, Convert.ToInt16(nudQuantidade.Value), dtpDataVencimento.Value.Date);
                lstNovosLotes.Items.Add(compra);

                // Resetar a GUI para Acrescentar um novo lote
                txtCodigo.Text = null;
                txtNome.Text = null;
                nudQuantidade.Value = 1;
                lstProdutos.DataSource = null;
                lstProdutos.Items.Clear();
                dtpDataVencimento.Value = DateTime.Now;

                // Seleciona o primeiro item da lista de novos lotes
                lstNovosLotes.SelectedIndex = 0;

                // Verificar a habilitação do btnAcrescentar
                HabilitarBotaoAcrescentar();
            }
        }

        // Botão de salvar os novos lotes de compras
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificar a habilitação do botão
            HabilitarBotaoAcrescentar();

            // Para cada lote de compra que estiver em lstNovosLotes
            foreach (Compra compra in lstNovosLotes.Items)
            {
                // Adicione na lista de lotes do Banco de Dados
                BancoDados.AdicionarCompra(compra);
            }

            // Resetar a GUI para inserir novos lotes
            lstNovosLotes.Items.Clear();

        }

        // Opção de excluir um lote antes de finalizar a compra 

        // Abrindo um menu de contexto ao clicar com o botão direito do mouse
        private void mnuExcluir_MouseUp(object sender, MouseEventArgs e)
        {
            lstNovosLotes.Items.Remove(lstNovosLotes.SelectedItem);
            HabilitarBotaoAcrescentar();
        }

        // DoubleClick no lote selecionado
        private void lstNovosLotes_DoubleClick(object sender, EventArgs e)
        {
            lstNovosLotes.Items.Remove(lstNovosLotes.SelectedItem);
            HabilitarBotaoAcrescentar();
        }

        private void lstNovosLotes_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right
                && lstNovosLotes.Items.Count > 0)
            {
                ctxmnuExcluir.Show(Cursor.Position);
                lstNovosLotes.SelectedIndex = lstNovosLotes.IndexFromPoint(e.Location);
            }
        }

        // Habilitar e desabilitar botões da GUI

        // btnAcrescentar
        private void HabilitarBotaoAcrescentar()
        {
            // Se a lista de produtos estiver vazia, o botão acrescentar fica desabilitado
            if (lstProdutos.Items.Count > 0)
            {
                btnAcrescentar.Enabled = true;
            }
            else
            {
                btnAcrescentar.Enabled = false;
            }
        }
    }
}
