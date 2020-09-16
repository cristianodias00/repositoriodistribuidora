using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using DistribuidoraConsole.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class CadastrarVenda
    {
        public static void Executar()
        {
            Venda v = new Venda();
            Cliente c = new Cliente();
            Funcionario f = new Funcionario();
            Produto p = new Produto();

            Console.WriteLine("-- Cadastrar Venda --");
            Console.WriteLine("Digite o CPF do cliente: ");

            //Cliente
            c.Cpf = Console.ReadLine();
            //Aqui abaixo está sendo armazenado o resultado do MÉTODO dentro do objeto "c"
            c = ClienteDAO.BuscarCliente(c.Cpf);
            ///Somente entrará no laço se o cliente existir
            if (c != null)
            {
                v.Cliente = c;
                //Vendedor
                Console.WriteLine("Digite o CPF do funcionario: ");
                f.Cpf = Console.ReadLine();
                //Aqui abaixo está sendo armazenado o resultado do MÉTODO dentro do objeto "c"
                f = FuncionarioDAO.BuscarFuncionario(f.Cpf);
                ///Somente entrará no laço se o funcionário existir
                if (f != null)
                {
                    v.Funcionario = f;
                    //Produto 
                    Console.WriteLine("Digite a Marca do produto: ");
                    p.Marca = Console.ReadLine();
                    Console.WriteLine("Digite o Volume do produto: ");
                    p.Volume = Console.ReadLine();
                    //Aqui abaixo está sendo armazenado o resultado do MÉTODO dentro do objeto "c"
                    p = ProdutoDAO.BuscarProduto(p.Marca, p.Volume);
                    ///Somente entrará no laço se o produto existir
                    if (p != null)
                    {
                        //Está abaixo é referente a QUANTIDADE em ESTOQUE
                        v.Produto = p;
                        Console.WriteLine("Digite a quantidade do produto: ");
                        //Está abaixo é referente a QUANTIDADE que está sendo COMPRADA no momento
                        v.Quantidade = Convert.ToInt32(Console.ReadLine());
                        VendaDAO.Cadastrar(v);
                        Console.WriteLine("Venda cadastrada com Sucesso!!");
                    }
                    else

                    {
                        Console.WriteLine("\n-- Produto não encontrado! --");
                    }
                }
                else
                {
                    Console.WriteLine("\n-- Funcionário não encontrado! --");
                }
                //Continuar vendas
            }
            else
            {
                Console.WriteLine("\n-- Cliente não encontrado! --");
            }
        }
    }
}
