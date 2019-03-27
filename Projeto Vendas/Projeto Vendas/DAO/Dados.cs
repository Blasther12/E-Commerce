using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.DAO
{
    class Dados
    {
       public static void inserir()
        {
            Cliente c = new Cliente()
            {
                nmCli = "Rafael Fonseca Oliviera",
                cpfCli = "070.844.339-70",
                CriadoEm = DateTime.Now
                
            };

            Vendedor b = new Vendedor()
            {
                nmVen = "Gislaine Fonseca Oliviera",
                cpfVen = "070.844.329-06",
                CriadoEm = DateTime.Now

            };

            Produtos g = new Produtos()
            {
                nmProduto = "Sabonete",
                vlProduto = 4.25,
                qtProduto = 50,
                CriadoEm = DateTime.Now

            };
            ClienteDAO.cadDAO(c);
            VendedorDAO.cadDAO(b);
            ProdutosDAO.cadProdutos(g);

        }


    }

}
