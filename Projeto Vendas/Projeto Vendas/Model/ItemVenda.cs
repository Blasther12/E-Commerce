using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.Model
{
    class ItemVenda
    {
        public ItemVenda()
        {
            Produto = new Produtos();
            CriadoEm = DateTime.Now;
        }
        public Produtos Produto { get; set; }
        public double vlVenda { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return "Produto: " + Produto.nmProduto + "\n" +
                   "Valor Produto: " + vlVenda + "\n" +
                   "Quantidade: " + Quantidade + "\n" +
                   "Criado Em: " + CriadoEm + "\n";
        }
    }
}
