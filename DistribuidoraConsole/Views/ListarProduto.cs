using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class ListarProduto
    {
        public static void Executar()
        {
            Console.WriteLine("-- Listar Produtos --");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
