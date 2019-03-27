using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas
{
    class Produtos
    {
        public Produtos()
        {
            CriadoEm = DateTime.Now;
        }
        public string nmProduto { get; set; }
        public double vlProduto { get; set; }
        public int qtProduto { get; set; }
        public DateTime CriadoEm { get; internal set; }

        public override string ToString()
        {
            return "Produto: " + nmProduto + "\n" +
                   "Valor Produto: " + "R$ " + vlProduto + "\n" +
                   "Quantidade: " + qtProduto + "\n" +
                   "Data de Criação: " + CriadoEm + "\n";
        }
    }
}
