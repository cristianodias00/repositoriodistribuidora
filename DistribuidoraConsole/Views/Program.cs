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
            //Aqui abaixo é referente ao import de dados automaticamente para adicionar as informações automaticamente
            Dados.Inicializar();
            //Aqui é uma variável utilizada para verificar qual a opção informada pelo usuário
            int opcao;

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
                Console.WriteLine("7 - Cadastrar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("9 - Listar Vendas por Cliente");
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
                    case 7:
                        CadastrarVenda.Executar();
                        break;
                    case 8:
                        //Aqui vai ser executado a lista completa
                        ListarVendas.Executar(VendaDAO.Listar());
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        string cpf = Console.ReadLine();
                        ListarVendas.Executar(VendaDAO.ListarPorCliente(cpf));
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
