using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Projeto_Vendas.View;
using Projeto_Vendas.DAO;

namespace Projeto_Vendas
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Dados.inserir();
            Boolean control = true;
            int op;

            do
            {

                Console.WriteLine("\nSistema de Vendas\n");
                Console.WriteLine("1 – Cadastrar de Cliente");
                Console.WriteLine("2 – Listar de Clientes");
                Console.WriteLine("3 – Cadastrar de Vendedor");
                Console.WriteLine("4 – Listar de Vendedores");
                Console.WriteLine("5 – Cadastrar de Produto");
                Console.WriteLine("6 – Listar de Produtos");
                Console.WriteLine("7 – Registrar Venda");
                Console.WriteLine("8 – Listar Vendas");
                Console.WriteLine("9 – Listar Vendas por Cliente");
                Console.WriteLine("0 – Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        CadastroPF.RenderizarCli();
                        break;
                    case 2:
                        CadastroPF.ListaCli();
                        break;
                    case 3:
                        CadastroPF.ReinderizarVend();
                        break;
                    case 4:
                        CadastroPF.ListaVend();
                        break;
                    case 5:
                        CadastroProduto.reinderizarPro();
                        break;
                    case 6:
                        CadastroProduto.RetornaLista();
                        break;
                    case 7:
                        CadastrarVenda.ReinderizarVen();
                        break;
                    case 8:
                        BuscaVenda.Renderizar(VendaDAO.ListaVenda());
                        break;
                    case 9:
                        Cliente c = new Cliente();
                        Console.WriteLine("Digite o CPF do cliente:");
                        c.cpfCli = Console.ReadLine();
                        BuscaVenda.Renderizar(VendaDAO.ListaVenCliente(c));
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (control);

            Console.ReadKey();

        }
    }
}
