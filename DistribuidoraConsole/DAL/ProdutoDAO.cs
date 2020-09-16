using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class ProdutoDAO
    {
        private static List<Produto> produtos = new List<Produto>();

        public static List<Produto> Listar()
        {
            return produtos;
        }

        public static bool Cadastrar(Produto p)
        {
            if (BuscarProduto(p.Marca, p.Volume) == null)
            {
                produtos.Add(p);
                return true;
            }
            return false;
        }

        //Aqui é um método que faz a busca somente do cliente
        //Lembrando que sempre que é encontrada uma linha de retorno em um método, ele para a execução do método pois já houve retorno
        public static Produto BuscarProduto(string marca, string volume)
        {
            foreach (Produto produtoCadastrado in produtos)
            {
                if (produtoCadastrado.Marca == marca & produtoCadastrado.Volume == volume)
                {
                    return produtoCadastrado;
                }
            }
            //Significa que foi pesquisado "foreach" na lista, e se não entrou no if significa que o cpf não era igual
            //E se pesquisou "foreach" inteiro e não encontrou ninguém (Ou seja, ao final é retornado NULL)
            return null;
        }
    }
}
