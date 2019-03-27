using Projeto_Vendas.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.View
{
    class CadastroPF
    {
        private static Cliente cadCli = new Cliente();
        private static Vendedor cadVem = new Vendedor();
        private static List<Cliente> store = ClienteDAO.RetornoLista();
        private static List<Vendedor> store1 = VendedorDAO.RetornoLista();
        public static void RenderizarCli()
        {


            cadCli = new Cliente();
            Console.WriteLine("\nCadastro de clientes");
            Console.WriteLine("\nInforme o nome: ");
            cadCli.nmCli = Console.ReadLine();
            Console.WriteLine("\nInforme o cpf: ");
            cadCli.cpfCli = Console.ReadLine();

            if (ClienteDAO.ValCPF(cadCli))
            {
                Console.WriteLine("\nCPF Invalido ou Já Existente");
            }
            else
            {
                ClienteDAO.cadDAO(cadCli);
                Console.WriteLine("\nCliente Cadastrado");
            }

        }
        public static void ListaCli()
        {

            Console.WriteLine("\n-=Clientes Cadastrados=-");
            foreach (Cliente stm in store)
            {


                Console.WriteLine(stm.ToString());


            }
        }
        public static void ReinderizarVend()
        {
            cadVem = new Vendedor();
            Console.WriteLine("\nCadastro de Vendedor");
            Console.WriteLine("\nInforme o nome: ");
            cadVem.nmVen = Console.ReadLine();
            Console.WriteLine("\nInforme o cpf: ");
            cadVem.cpfVen = Console.ReadLine();

            if (VendedorDAO.ValCPF(cadVem))
            {
                Console.WriteLine("\nCPF Invalido ou Já Existente");
            }
            else
            {
                VendedorDAO.cadDAO(cadVem);
                Console.WriteLine("\nVendedor Cadastrado");
            }
        }
        public static void ListaVend()
        {
            Console.WriteLine("\n-=Vendedores Cadastrados=-");
            foreach (Vendedor stm in store1)
            {
               
                
                    Console.WriteLine(stm.ToString());
                

            }
        }
    }
}
