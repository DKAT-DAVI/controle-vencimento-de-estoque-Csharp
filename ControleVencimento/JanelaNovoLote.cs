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
        private static JanelaNovoLote instance;
        private JanelaNovoLote()
        {
            InitializeComponent();
        }

        public static JanelaNovoLote GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new JanelaNovoLote();
            }

            return instance;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Buscar Produto para novo lote de compra

        // Buscar pelo código do produto
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            // Limpa o DataSource da lstProdutos
            lstProdutos.DataSource = null;

            // Limpa a lista de produtos para fazer a busca novamente
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

        // Acrescenta um novo lote na lista de lotes
        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            // Cria a compra principal que vai receber os valores transportados da compraAuxiliar
            Compra compra = new Compra((Produto)lstProdutos.SelectedItem, Convert.ToInt16(nudQuantidade.Value), dtpDataVencimento.Value);
            lstNovosLotes.Items.Add(compra);    
            HabilitarBotaoSalvar();

            // Resetar a GUI para Acrescentar um novo lote
            txtCodigo.Text = null;
            txtNome.Text = null;
            nudQuantidade.Value = 0;
            lstProdutos.DataSource = null;
            lstProdutos.Items.Clear();
            dtpDataVencimento.Value = DateTime.Now;
        }

        // Botão de salvar os novos lotes de compras
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (Compra compra in lstNovosLotes.Items)
            {
                BancoDados.AdicionarCompra(compra);
            }

            HabilitarBotaoSalvar();

            // Resetar a GUI para inserir novos lotes
            lstNovosLotes.Items.Clear();
        }

        // Habilitar e desabilitar o botão Acrescentar
        private void HabilitarBotaoAcrescentar()
        {
            // Se a lista de produtos estiver vazia, o botão fica desabilitado
            if (lstProdutos.Items.Count > 0)
            {
                btnAcrescentar.Enabled = true;
            }
            else
            {
                btnAcrescentar.Enabled = false;
            }
        }

        // Habilitar e desabilitar o botão Salvar
        private void HabilitarBotaoSalvar()
        {
            // Se a lista de novos lotes estiver vazia, o botão fica desabilitado
            if (lstNovosLotes.Items.Count > 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }
    }
}
