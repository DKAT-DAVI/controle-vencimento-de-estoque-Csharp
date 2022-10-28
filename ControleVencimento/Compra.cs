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
        
        private static Int64 Serial { get; set; }
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
        static Compra()
        {
            // Pega os dois últimos digitos do ano atual * 100000
            Serial = Convert.ToInt64(DateTime.Now.Year.ToString().Substring(2)) * 100000;
        }

        public Compra()
        {
            Lote = Serial;
            Serial++;
            DataCompra = DateTime.Now;
        }

        public Compra(Produto produto, Int16 quantidade, DateTime dataVencimento) : this()
        {
            Produto = produto;
            Quantidade = quantidade;
            DataVencimento = dataVencimento;
        }

        public override string ToString()
        {
            return $"{Lote}: {Quantidade} x {Produto} [{Produto.Preco}] = {CalcularTotal()}";
        }
    }
}
