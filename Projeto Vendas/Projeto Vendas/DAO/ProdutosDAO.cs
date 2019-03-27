using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.DAO
{
    class ProdutosDAO
    {
        private static List<Produtos> cadProd = new List<Produtos>();

        public static Boolean cadProdutos(Produtos cad)
        {
            if(cad != null)
            {
                cadProd.Add(cad);
                return true;
            }
            return false;
            
        }

        public static List<Produtos> RetornoLista()
        {
            return cadProd;
        }
        public static Produtos BuscaProdutoNome(Produtos c)
        {
            foreach (Produtos prod in cadProd)
            {
                if (prod.nmProduto.Equals(c.nmProduto))
                {
                    return prod;
                }
                
            }
            return null;
        }


    }
}
