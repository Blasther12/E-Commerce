using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas
{
    class Cliente
    {
        public string nmCli { get; set; }
        public string cpfCli { get; set; }
        public DateTime CriadoEm { get; internal set; }

        public override string ToString()
        {
            return "Nome: " + nmCli + "\n" +
                   "CPF: " + cpfCli + "\n" +
                   "Data de Criação: " + CriadoEm + "\n";
        }
    }
}
