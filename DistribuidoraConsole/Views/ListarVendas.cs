using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class ListarVendas
    {
        public static void Executar()
        {
            double totalGeral = 0, totalVenda = 0, totalItem = 0;
            Console.WriteLine("-- Listar Vendas --");
            foreach (Venda vendaCadastrada in VendaDAO.Listar())
            {
                totalVenda = 0;
                Console.WriteLine($"Cliente: {vendaCadastrada.Cliente.Nome}");
                Console.WriteLine($"Funcionário: {vendaCadastrada.Funcionario.Nome}");
                Console.WriteLine("\n--Itens da Venda --\n");
                Console.WriteLine($"\tProduto: {vendaCadastrada.Produto.Nome}");
                Console.WriteLine($"\tMarca: {vendaCadastrada.Produto.Marca}");
                totalItem = vendaCadastrada.Produto.Preco * vendaCadastrada.Quantidade;
                Console.WriteLine($"\tPreço: {vendaCadastrada.Produto.Preco:C2} x {vendaCadastrada.Produto.Quatidade} = {totalItem:C2}");

                totalVenda += totalItem;
                Console.WriteLine($"\n\tTotal da Venda: {totalVenda:C2}");
                totalGeral += totalVenda;
                Console.WriteLine();
            }
            Console.WriteLine($"Total da Geral: {totalGeral:C2}");
        }
    }
}
