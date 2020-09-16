using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using DistribuidoraConsole.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class CadastrarProduto
    {
        public static void Executar()
        {
            Produto p = new Produto();
            Console.WriteLine("-- Cadastrar Produto --");
            Console.WriteLine("Digite o Tipo do produto: ");
            p.Tipo = Console.ReadLine();
            Console.WriteLine("Digite o Nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Marca do produto: ");
            p.Marca = Console.ReadLine();
            Console.WriteLine("Digite o volume (ml) do produto: ");
            p.Volume = Console.ReadLine();
            Console.WriteLine("Digite a validade do produto: ");
            p.Validade = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto: ");
            p.Quatidade = Convert.ToInt32(Console.ReadLine());
            //Realiza a validação, se a MARCA e o VOLUME forem os mesmos já cadastrados na lista que está em ProdutoDAO.Listar()

            //Se ProdutoDAO.Cadastrar(p) for verdadeiro entra no laço do if. Caso contrario vai para o else, significando que o ProdutoDAO.Cadastrar(p) deu false 
            if (ProdutoDAO.Cadastrar(p))
            {
                    Console.WriteLine("Produto cadastrado com sucesso!!!");
            }
            else
            {
                    Console.WriteLine("\nProduto já cadastrado! Informe outro produto e tente novamente.");
            }
        }
    }
}
