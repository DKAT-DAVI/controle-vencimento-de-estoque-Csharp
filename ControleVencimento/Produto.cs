using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPedidos
{
    internal class Produto
    {
        //Propriedades
        public Int64 Codigo { get; set; }
        public Decimal Preco { get; set; }

        private string _nome;
        public String Nome
        {
            get
            {
                return _nome;
            }

            // Se o _nome for maior que 45 caracteres o _nome vai receber somente os 32 primeiros caracteres
            set
            {
                if (value.Length > 45)
                {
                    _nome = value.Substring(0, 45);
                }

                else
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}
