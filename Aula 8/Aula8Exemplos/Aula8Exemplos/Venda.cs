using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8Exemplos
{
    class Venda
    {
        public Venda()
        {
            Data = DateTime.Now;
        }

        public Venda(DateTime data)
        {
            Data = data;
        }

        public Venda(int data)
        {
            //Data = data;
        }

        public DateTime Data { get; set; }

        public string  NroCupomFiscal { get; set; }

        public List<VendaProduto> Produtos { get; set; }

        public decimal GetTotalVenda()
        {
            decimal total = 0;

            foreach (var produto in Produtos)
            {
                total += produto.Quantidade * produto.Valor;
            }

            return total;
        }
    }
}
