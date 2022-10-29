using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControleVencimento
{
    internal class BancoDados
    {
        public static BindingList<Compra> Compras;
        public static List<Produto> Produtos;
        
        static BancoDados()
        {
            Produtos = new List<Produto>();
            Compras = new BindingList<Compra>();

            //Lista de Produtos disponíveis
            Produto p1 = new Produto(1, "Abacaxi", 12.20m);
            Produto p2 = new Produto(2, "Batata-Palha", 7.00m);
            Produto p3 = new Produto(3, "Cheiro-Verde", 2.00m);
            Produto p4 = new Produto(4, "Desinfetante", 6.00m);
            Produto p5 = new Produto(5, "Esfregão", 18.00m);
            Produto p6 = new Produto(6, "Farinha", 8.00m);
            Produto p7 = new Produto(7, "Gengibre", 15.50m);
            Produto p8 = new Produto(8, "Hortelã", 2.50m);
            Produto p9 = new Produto(9, "Iogurte", 4.50m);
            Produto p10 = new Produto(10, "Jambo", 5.50m);

            Produtos.Add(p1);
            Produtos.Add(p2);
            Produtos.Add(p3);
            Produtos.Add(p4);
            Produtos.Add(p5);
            Produtos.Add(p6);
            Produtos.Add(p7);
            Produtos.Add(p8);
            Produtos.Add(p9);
            Produtos.Add(p10);            
        }


        // Métodos

        // Adicionar compra na lista de novos lotes
        public static void AdicionarCompra(Compra compra)
        {
            Compras.Add(compra);
        }

        // Filtrar os vencimentos dos lotes

        // Filtrar o vencimento em um número específico de dias
        public static BindingList<Compra> FiltrarVencimento(Int16 intervaloDeDias)
        {
            BindingList<Compra> listaFiltrada = new BindingList<Compra>();
            DateTime dataAtual = DateTime.Now.Date;

            foreach (Compra compra in Compras)
            {
                if ((compra.DataVencimento - dataAtual).Days <= intervaloDeDias)
                {
                    listaFiltrada.Add(compra);
                }
            }

            return listaFiltrada;
        }


        // Filtrar vencimento em um intervalo de duas datas
        public static BindingList<Compra> FiltrarVencimentoPersonalizado(DateTime data1, DateTime data2)
        {
            DateTime dataAtual = DateTime.Now;
            BindingList<Compra> compraFiltrada = new BindingList<Compra>();

            foreach (Compra compra in Compras)
            {
                if (compra.DataVencimento >= data1 && compra.DataVencimento <= data2)
                {
                    compraFiltrada.Add(compra);
                }
            }

            return compraFiltrada;
        }

        // Buscar os produtos para um novo lote
        public static Produto LocalizarProdutoPorCodigo(Int64 codigo)
        {
            //Cria uma lista pra receber o produto buscado
            Produto produto = null;

            //Varre a lista de produtos buscando o código digitado
            foreach (Produto p in Produtos)
            {
                //Verifica se o código passado como parâmetro é IGUAL ao código do produto
                if (codigo == p.Codigo)
                {
                    //Se for igual adiciona na lista
                    produto = p;
                }
            }

            //Retorna a lista
            return produto;
        }

        public static List<Produto> LocalizarProdutoPorParteNome(String parte)
        {
            //Cria uma lista para armazenar os produtos buscados
            List<Produto> lista = new List<Produto>();

            //Varre a lista de Produtos existentes no BancoDadosSimulado
            foreach (Produto produto in Produtos)
            {
                //Verifica se a string buscada faz parte do nome de algum produto
                if (produto.Nome.ToLower().Contains(parte.ToLower()))
                {
                    //Adiciona na lista de produtos
                    lista.Add(produto);
                }
            }

            //Retorna a lista com os elementos selecionados
            return lista;
        }

        // Configurar o DataGridView
        public static void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[2].HeaderText = "Qtde";
            dataGridView.Columns[4].HeaderText = "Vencimento";
            dataGridView.Columns[5].HeaderText = "Total (R$)";
        }
    }
}
