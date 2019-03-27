using Projeto_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.DAO
{
    class VendaDAO
    {
        private static List<Venda> store = new List<Venda>();

        public static void CadVen(Venda v)
        {
            store.Add(v);
        }
        public static List<Venda> ListaVenda()
        {
            return store;
        }

        public static List<Venda> ListaVenCliente(Cliente cad)
        {
            List<Venda> aux = new List<Venda>();
            foreach (Venda stm in store)
            {
                if (stm.Cliente.cpfCli.Equals(cad.cpfCli))
                {
                    aux.Add(stm);
                }
            }
            return aux;
        }


    }
}
