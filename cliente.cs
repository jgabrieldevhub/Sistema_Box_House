using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Box_House
{
    internal class cliente
    {

        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public string NomePet { get; set; }


        public cliente(string nomeCliente, string telefone, string nomePet)
        {
            NomeCliente = nomeCliente;
            Telefone = telefone;
            NomePet = nomePet;
        }
    }
}
