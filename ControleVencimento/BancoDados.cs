using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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

            // Lista de Compras
            Compras.Add(new Compra(11, p1, 200, new DateTime(2022, 09, 30), new DateTime(2022, 12, 31)));
            Compras.Add(new Compra(25, p3, 50, new DateTime(2022, 05, 20), new DateTime(2022, 11, 05)));
            Compras.Add(new Compra(32, p5, 20, new DateTime(2022, 10, 02), new DateTime(2022, 11, 25)));
            Compras.Add(new Compra(14, p7, 30, new DateTime(2022, 05, 30), new DateTime(2023, 01, 30)));
            Compras.Add(new Compra(22, p9, 100, new DateTime(2022, 09, 30), new DateTime(2022, 12, 15)));
            Compras.Add(new Compra(90, p2, 150, new DateTime(2022, 08, 31), new DateTime(2022, 10, 27)));
            Compras.Add(new Compra(55, p4, 80, new DateTime(2022, 07, 30), new DateTime(2022, 10, 31)));            
        }

        public static BindingList<Compra> FiltrarVencimento1Dia()
        {
            DateTime dataAtual = DateTime.Now;
            BindingList<Compra> compraFiltrada = new BindingList<Compra>();

            foreach (Compra compra in Compras)
            {
                if ((compra.DataVencimento - dataAtual).Days + 1 <= 1)
                {
                    compraFiltrada.Add(compra);
                }
            }

            return compraFiltrada;
        }

        public static BindingList<Compra> FiltrarVencimento5Dias()
        {
            DateTime dataAtual = DateTime.Now;
            BindingList<Compra> compraFiltrada = new BindingList<Compra>();

            foreach (Compra compra in Compras)
            {
                if (((compra.DataVencimento - dataAtual).Days + 1) <= 5)
                {
                    compraFiltrada.Add(compra);
                }
            }

            return compraFiltrada;
        }

        public static BindingList<Compra> FiltrarVencimentoPersonalizado(DateTime data1, DateTime data2)
        {
            DateTime dataAtual = DateTime.Now;
            BindingList<Compra> compraFiltrada = new BindingList<Compra>();

            foreach (Compra compra in Compras)
            {
                if (compra.DataVencimento >= data1 && compra.DataVencimento <= data2 )
                {
                    compraFiltrada.Add(compra);
                }
            }

            return compraFiltrada;
        }
    }
}
