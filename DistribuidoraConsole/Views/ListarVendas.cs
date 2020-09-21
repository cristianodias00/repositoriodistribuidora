using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class ListarVendas
    {
        //Quando for chamado o Executar, vai receber uma lista de vendas(nome da Lista = "vendas"), essa lista de vendas vai ser utilizada no foreach
        public static void Executar(List<Venda> vendas)
        {
            double totalGeral = 0, totalVenda = 0, totalItem = 0;
            Console.WriteLine("-- Listar Vendas --");
            foreach (Venda vendaCadastrada in vendas)
                
            {
                totalVenda = 0;
                Console.WriteLine($"Cliente: {vendaCadastrada.Cliente.Nome}");
                Console.WriteLine($"Funcionário: {vendaCadastrada.Funcionario.Nome}");
                Console.WriteLine("\n--Itens da Venda --\n");
                foreach (ItemVenda itemCadastrado in vendaCadastrada.Itens)
                {
                    Console.WriteLine($"\tProduto(s): {itemCadastrado.Produto.Nome}");
                    Console.WriteLine($"\tMarca: {itemCadastrado.Produto.Marca}");
                    totalItem = itemCadastrado.Produto.Preco * itemCadastrado.Quantidade;
                    Console.WriteLine($"\tPreço: {itemCadastrado.Produto.Preco:C2} x {itemCadastrado.Quantidade} = {totalItem:C2}");
                    //Para cada iteração , será adicionado um item de venda em "totalVenda"
                    totalVenda += totalItem;
                }
                Console.WriteLine($"\n\tTotal da Venda: {totalVenda:C2}\n");
                totalGeral += totalVenda;
            }
            Console.WriteLine($"Total Geral: {totalGeral:C2}");
        }
    }
}
