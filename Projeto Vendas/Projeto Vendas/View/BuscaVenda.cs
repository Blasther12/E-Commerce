using Projeto_Vendas.DAO;
using Projeto_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.View
{
    class BuscaVenda
    {
        public static void Renderizar(List<Venda> vendas)
        {
            double subtotal, totalVenda = 0, totalGeral = 0;
            Console.Clear();
            Console.WriteLine("  -- LISTAR VENDAS --  \n");

            foreach (Venda vendaCadastrada in vendas)
            {
                Console.WriteLine("Cliente: " + vendaCadastrada.Cliente.nmCli);
                Console.WriteLine("Funcionário: " + vendaCadastrada.Funcionario.nmVen);
                Console.WriteLine("Data: " + vendaCadastrada.DataVenda);
                Console.WriteLine("\n  -- ITENS DA VENDA --  \n");
                totalVenda = 0;
                foreach (ItemVenda itemCadastrado in vendaCadastrada.ItensVenda)
                {
                    Console.WriteLine("\tNome: " + itemCadastrado.Produto.nmProduto);
                    Console.WriteLine("\tQuantidade: " + itemCadastrado.Quantidade);
                    Console.WriteLine("\tPreço: " + itemCadastrado.vlVenda.ToString("C2"));
                    subtotal = itemCadastrado.vlVenda * itemCadastrado.Quantidade;
                    totalVenda += subtotal;
                    Console.WriteLine("\tSubtotal: " + subtotal.ToString("C2"));
                    Console.WriteLine("-----------------------------------\n");
                }
                Console.WriteLine("\n\tTotal venda: " + totalVenda.ToString("C2"));
                Console.WriteLine("-----------------------------------\n");
                totalGeral += totalVenda;
            }
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Total geral: " + totalGeral.ToString("C2"));
        }
    }
}
