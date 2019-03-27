using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas.Model
{
    class Venda
    {
        public Venda()
        {
            Cliente = new Cliente();
            Funcionario = new Vendedor();
            ItensVenda = new List<ItemVenda>();
            CriadoEm = DateTime.Now;
        }

        public Cliente Cliente { get; set; }
        public Vendedor Funcionario { get; set; }
        public List<ItemVenda> ItensVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime CriadoEm { get; set; }

        
    }

   
}
