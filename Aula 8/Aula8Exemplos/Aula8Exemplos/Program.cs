using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            var venda2 = new Venda(DateTime.Now);

            var venda3 = new Venda();
            
            var vendaProdutos = new List<VendaProduto>();

            var produto1 = new VendaProduto { Descricao = "Coca Cola", Quantidade = 100, Valor = 4 };

            var produto2 = new VendaProduto { Descricao = "Pepsi", Quantidade = 50, Valor = 3.90M };

            vendaProdutos.Add(produto1);
            vendaProdutos.Add(produto2);

            var venda = new Venda { Data = DateTime.Now, NroCupomFiscal = "1", Produtos = vendaProdutos};

            var totalVenda = venda.GetTotalVenda();

            Console.ReadLine();
        }
    }
}
