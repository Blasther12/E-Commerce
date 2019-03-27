using Projeto_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.View
{
    class CadastroProduto
    {
        private static Produtos cad1 = new Produtos();
        private static List<Produtos> store = ProdutosDAO.RetornoLista();
        public static void reinderizarPro()
        {
            cad1 = new Produtos(); 
            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("Informe o Nome do produto: ");
            cad1.nmProduto = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto: ");
            cad1.vlProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade que deseja Armazenar: ");
            cad1.qtProduto = int.Parse(Console.ReadLine());

            if(ProdutosDAO.cadProdutos(cad1))
            {
                Console.WriteLine("Cadastro efetuado com sucesso");
            }
            else
            {
                Console.WriteLine("Erro no cadastro");
            }

            
        }
        public static void RetornaLista()
        {
            Console.WriteLine("\n-=Produtos Cadastrados=-");
            foreach (Produtos stm in store)
            {
                
                    Console.WriteLine(stm.ToString());
                

            }
        }
        
    }
}
