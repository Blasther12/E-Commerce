using Projeto_Vendas.DAO;
using Projeto_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.View
{
    class CadastrarVenda
    {
       

        public static void ReinderizarVen()
        {
            Venda ven = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produtos p = new Produtos();
            ItemVenda iven = new ItemVenda();

            Console.WriteLine("-=Cadastro de Venda=-");
            Console.WriteLine("Digiteo CPF do Cliente: ");
            c.cpfCli = Console.ReadLine();
            c = ClienteDAO.BuscaClienteCPF(c);
            if (c != null)
            {
                ven.Cliente = c;
                Console.WriteLine("Digite o CPF do Vendedor: ");
                v.cpfVen = Console.ReadLine();
                v = VendedorDAO.BuscaVendedorCPF(v);
                if(v != null)
                {
                    ven.Funcionario = v;
                    do
                    {
                        p = new Produtos();
                        iven = new ItemVenda();
                        Console.Clear();
                        Console.WriteLine("-=Adicionar ao Carrinho=-\n");
                        Console.WriteLine("Digite o nome do Produto: ");
                        p.nmProduto = Console.ReadLine();
                        p = ProdutosDAO.BuscaProdutoNome(p);
                        if (p != null)
                        {
                            iven.Produto = p;
                            Console.WriteLine("Quantidade de Produto: ");
                            iven.Quantidade = int.Parse(Console.ReadLine());
                            iven.vlVenda = p.vlProduto;
                            ven.ItensVenda.Add(iven);
                        }
                        else
                        {
                            Console.WriteLine("Produto não Cadastrado!\n");
                        }
                       
                       Console.WriteLine("Deseja adicionar mais itens?");
                            
                    } while (Console.ReadLine().ToUpper().Equals("S"));
                    VendaDAO.CadVen(ven);
                    Console.WriteLine("Venda Cadastrada com sucesso!!\n");
                }
                else
                {
                    Console.WriteLine("Vendedor não Cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("Cliente Não Foi encontrado!");
            }
           
        }
    }
}
