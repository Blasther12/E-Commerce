using Projeto_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.DAO
{
    class VendedorDAO
    {
        private static List<Vendedor> store = new List<Vendedor>();
        private static ValidaCpf val = new ValidaCpf();

        public static void cadDAO(Vendedor cad)
        {
            store.Add(cad);
        }
        public static Boolean ValCPF(Vendedor cad)
        {

            foreach (Vendedor stm in store)
            {
                if (stm.cpfVen.Equals(cad.cpfVen) || !val.Valida(cad.cpfVen))
                {
                    return true;
                }
            }
            
            return false;

        }

        public static List<Vendedor> RetornoLista()
        {
            return store;
        }
        public static Vendedor BuscaVendedorCPF(Vendedor c)
        {
            foreach (Vendedor cliVen in store)
            {
                if (cliVen.cpfVen.Equals(c.cpfVen))
                {
                    return cliVen;
                }
                
            }
            return null;
        }
    }

}
