using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace DistribuidoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c;
            List<Cliente> clientes = new List<Cliente>();

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
                        c = new Cliente();
                        Console.WriteLine("-- Cadastrar Cliente --");
                        Console.WriteLine("Digite o NOME do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();

                        if (ValidarCpf(c.Cpf))
                        {

                            if (clientes.Count == 0)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso!!!");
                            }
                            else
                            {
                                bool encontrado = false;
                                foreach (Cliente clienteCadastrado in clientes)
                                {
                                    if (clienteCadastrado.Cpf == c.Cpf)
                                    {
                                        encontrado = true;
                                    }
                                }
                                if (!encontrado)
                                {
                                    clientes.Add(c);
                                    Console.WriteLine("Cliente salvo com sucesso!!!");
                                }
                                else
                                {
                                    Console.WriteLine("Não foi possível realizar o cadastro!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nCPF Inválido");
                        }
                        break;
                    case 2:
                        Console.WriteLine("-- Listar Clientes --");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
                        break;
                    case 3:
                        Console.WriteLine("-- Cadastrar Funcionário --");
                        break;
                    case 4:
                        Console.WriteLine("-- Listar Funcionários --");
                        break;
                    case 5:
                        Console.WriteLine("-- Cadastrar Produto --");
                        break;
                    case 6:
                        Console.WriteLine("-- Listar Produtos --");
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

        //Aqui é o método de validação do CPF
        private static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, digito1, digito2;
            //Este código abaixo é para realizar a substituição do "." e "-" do cadastro do CPF
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }

            //Primeiro Digito do CPF
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            //Aqui é calculado o resto da multiplicação
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            //Segundo Digito do CPF
            peso = 11;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            //Aqui é calculado o resto da multiplicação
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }
            return true;
        }
    }
}
