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
        public Produto Produto { get; set; }
        public Int16 Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataVencimento { get; set; }

        // Métodos
        public Decimal CalcularTotal()
        {
            return Quantidade * Produto.Preco;
        }

        // Construtores
        public Compra(Int64 lote, Produto produto, Int16 quantidade, DateTime dataCompra, DateTime dataVencimento)
        {
            Lote = lote * 100;
            Quantidade = quantidade;
            DataCompra = dataCompra;
            DataVencimento = dataVencimento;
            Produto = produto;
        }
    }
}
