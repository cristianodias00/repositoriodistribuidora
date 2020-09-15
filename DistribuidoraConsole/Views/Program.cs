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
            //Aqui abaixo é um objeto
            Cliente c;
            Funcionario f;
            Produto p;
            //Aqui são as listas
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Funcionario> funcionarios = new List<Funcionario>();

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
                        Console.WriteLine("Digite o Nome do cliente: ");
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
                        f = new Funcionario();
                        Console.WriteLine("-- Cadastrar Funcionário --");
                        Console.WriteLine("Digite o Nome do funcionário: ");
                        f.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o RG do funcionário: ");
                        f.Rg = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do funcionário: ");
                        f.Cpf = Console.ReadLine();
                        if (ValidarCpf(f.Cpf))
                        {
                            if (funcionarios.Count == 0)
                            {
                                Console.WriteLine("Digite a data de nascimento do funcionário: ");
                                f.DataNasc = Console.ReadLine();
                                Console.WriteLine("Digite o Cargo do funcionário: ");
                                f.Cargo = Console.ReadLine();
                                Console.WriteLine("Digite o Salário do funcionário: ");
                                f.Salario = Console.ReadLine();
                                funcionarios.Add(f);
                                Console.WriteLine("Funcionário salvo com sucesso!!!");
                            }
                            else
                            {
                                bool encontrado = false;
                                foreach (Funcionario funcionarioCadastrado in funcionarios)
                                {
                                    if (funcionarioCadastrado.Cpf == f.Cpf)
                                    {
                                        encontrado = true;
                                    }
                                }
                                if (!encontrado)
                                {
                                    Console.WriteLine("Digite a data de nascimento do funcionário: ");
                                    f.DataNasc = Console.ReadLine();
                                    Console.WriteLine("Digite o Cargo do funcionário: ");
                                    f.Cargo = Console.ReadLine();
                                    Console.WriteLine("Digite o Salário do funcionário: ");
                                    f.Salario = Console.ReadLine();
                                    funcionarios.Add(f);
                                    Console.WriteLine("Funcionário salvo com sucesso!!!");
                                }
                                else
                                {
                                    Console.WriteLine("Não foi possível realizar o cadastro! CPF já cadastrado!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nCPF Inválido");
                        }
                        break;
                    case 4:
                        Console.WriteLine("-- Listar Funcionários --");
                        foreach (Funcionario funcionarioCadastrado in funcionarios)
                        {
                            Console.WriteLine(funcionarioCadastrado);
                        }
                        break;
                    case 5:
                        p = new Produto();
                        Console.WriteLine("-- Cadastrar Produto --");
                        Console.WriteLine("Digite o Tipo do produto: ");
                        p.Tipo = Console.ReadLine();
                        Console.WriteLine("Digite o Nome do produto: ");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o Marca do produto: ");
                        p.Marca = Console.ReadLine();
                        Console.WriteLine("Digite o volume (ml) do produto: ");
                        p.Volume = Console.ReadLine();

                        if (produtos.Count == 0)
                        {
                            Console.WriteLine("Digite a data de validade do produto: ");
                            p.Validade = Console.ReadLine();
                            produtos.Add(p);
                            Console.WriteLine("Produto salvo com sucesso!!!");
                        }
                        else
                        {
                            bool encontrado = false;
                            //Lembre-se que não é possível realizar uma alteração enquanto a iteração está em execução. (Exemplo "produtos.Add(p)" não pode ficar dentro do laço de repetição pois ao modificar dá erro) 
                            foreach (Produto produtoCadastrado in produtos)
                            {
                                //Aqui está validando se o produto já existe na lista com as caracteristicas iguais de Marca e Volume
                                if (produtoCadastrado.Marca == p.Marca & produtoCadastrado.Volume == p.Volume)
                                {
                                    encontrado = true;
                                }
                            }
                            //Aqui foi inserido uma "negação" (Com isso, entendemos que se o produto passar pelo if acima, ele estará como "false" pois não foi localizado no laço do foreach, e com isso pode ser cadastrado )
                            if (!encontrado)
                            {
                                Console.WriteLine("Digite a data de validade do produto: ");
                                p.Validade = Console.ReadLine();
                                produtos.Add(p);
                                Console.WriteLine("Produto salvo com sucesso!!!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi possível realizar o cadastro. Produto já cadastrado!");
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("-- Listar Produtos --");
                        foreach (Produto produtoCadastrado in produtos)
                        {
                            Console.WriteLine(produtoCadastrado);
                        }
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
            //Este código abaixo é para remover o "." e "-" do cadastro do CPF
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
