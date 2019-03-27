using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas
{
    class Vendedor
    {
        public string nmVen { get; set; }
        public string cpfVen { get; set; }
        public DateTime CriadoEm { get; internal set; }

        public override string ToString()
        {
            return "Nome: " + nmVen + "\n" +
                   "CPF: " + cpfVen + "\n" +
                   "Data de Criação: " + CriadoEm + "\n";
        }
    }
}
