using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVencimento
{
    internal class Compra
    {
        //Propriedades
        public Int64 Lote { get; set; }
        public Int16 Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataVencimento { get; set; }
        public Produto Produtos { get; set; }

        //Métodos
        public Decimal CalcularTotal()
        {
            return Quantidade * Produtos.Preco;
        }

        public Compra(Int64 lote, Int16 quantidade, DateTime dataCompra, DateTime dataVencimento, Produto produtos)
        {
            Lote = lote;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            DataVencimento = dataVencimento;
            Produtos = produtos;
        }
    }
}
