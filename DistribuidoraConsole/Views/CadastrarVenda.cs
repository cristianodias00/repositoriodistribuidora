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
            ItemVenda iv = new ItemVenda();

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
                    do
                    {
                        iv = new ItemVenda();
                        p = new Produto();
                        Console.Clear();
                        Console.WriteLine("-- Adicionar Produto --\n");
                        //Produto
                        Console.WriteLine("Digite a Marca do produto: ");
                        p.Marca = Console.ReadLine();
                        Console.WriteLine("Digite o Volume do produto: ");
                        p.Volume = Convert.ToDouble(Console.ReadLine());
                        //Aqui abaixo está sendo armazenado o resultado do MÉTODO dentro do objeto "c"
                        p = ProdutoDAO.BuscarProduto(p.Marca, p.Volume);
                        if (p != null)
                        {
                            iv.Produto = p;
                            Console.WriteLine("Digite a quantidade do produto: ");
                            //Está abaixo é referente a QUANTIDADE que está sendo COMPRADA no momento
                            iv.Quantidade = Convert.ToInt32(Console.ReadLine());
                            //Aqui abaixo é preenchido o preço de venda "atual" do produto, e é guardado/salvo em "iv.Preco" .
                            iv.Preco = p.Preco;
                            //Aqui estamos pegando o objeto "v"-Venda e dentro dele nós temos o atributo "Itens" (Lembrando que este atributo é uma lista) 
                            // Add(iv) está adicionando o "iv"-Item de venda dentro da lista de Itens
                            v.Itens.Add(iv);
                            Console.WriteLine("Produto cadastrado com Sucesso!!");
                        }
                        else

                        {
                            Console.WriteLine("\n-- Produto não encontrado! --");
                        }
                        Console.WriteLine("\nDeseja adicionar mais produtos? (S/N)");
                        //ToUpper pega a letra digitada no console pelo usuario e transforma em caixa alta, após isso valida se é igual a "S"
                    } while (Console.ReadLine().ToUpper() == "S");
                    //Cadastrar Venda 
                    //(Somente é cadastrada a venda após sair do laço de repetição acima, pois enquanto isso o sistema ficará adicionando produtos na lista de itens de venda
                    VendaDAO.Cadastrar(v);
                    Console.WriteLine("Venda cadastrada com Sucesso!!");


                    ///Somente entrará no laço se o produto existir

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
