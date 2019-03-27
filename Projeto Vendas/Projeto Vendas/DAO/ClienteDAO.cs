using Projeto_Vendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.DAO
{
    class ClienteDAO
    {
        private static List<Cliente> store = new List<Cliente>();
        private static ValidaCpf val = new ValidaCpf();

        public static void cadDAO(Cliente cad)
        {
            store.Add(cad);
        }
        public static Boolean ValCPF(Cliente cad)
        {

            foreach (Cliente stm in store)
            {
                if (stm.cpfCli.Equals(cad.cpfCli) || !val.Valida(cad.cpfCli))
                {
                    return true;
                }
            }

            return false;

        }
        public static List<Cliente> RetornoLista()
        {
            return store;
        }

        internal static bool ValCPF(string cpfCli)
        {
            throw new NotImplementedException();
        }

        public static Cliente BuscaClienteCPF(Cliente c)
        {
            foreach(Cliente CliCad in store)
            {
                if(CliCad.cpfCli.Equals(c.cpfCli))
                {
                    return CliCad;
                }
            }
            return null;
        }

    }
}
