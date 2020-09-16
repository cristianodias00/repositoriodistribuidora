using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace DistribuidoraConsole.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui é uma variável
            int opcao;

            Produto p;

            List<Produto> produtos = new List<Produto>();

            do
            {
                Console.Clear();
                Console.WriteLine("\n Distribuidora Lemon \n");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Cadastrar Funcionário");
                Console.WriteLine("4 - Listar Funcionários");
                Console.WriteLine("5 - Cadastrar Produto");
                Console.WriteLine("6 - Listar Produtos");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Executar();
                        break;
                    case 2:
                        ListarClientes.Executar();
                        break;
                    case 3:
                        CadastrarFuncionario.Executar();
                        break;
                    case 4:
                        ListarFuncionario.Executar();
                        break;
                    case 5:
                        CadastrarProduto.Executar();
                        break;
                    case 6:
                        ListarProduto.Executar();
                        break;
                    case 0:
                        Console.WriteLine("-- Saindo... --\n");
                        break;
                    default:
                        Console.WriteLine("\n--- Opção Inválida!!! ---\n");
                        break;
                }
                Console.WriteLine("\nPrecione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
