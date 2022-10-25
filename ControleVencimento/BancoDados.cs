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
        
        static BancoDados()
        {
            Compras = new BindingList<Compra>();

            // Lista de Compras
            
        }
    }
}
