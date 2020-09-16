using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();

        public static List<Venda> Listar()
        {
            return vendas;
        }

        public static void Cadastrar(Venda v)
        {
            vendas.Add(v);
        }
    }
}
