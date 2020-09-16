using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using DistribuidoraConsole.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class CadastrarFuncionario
    {
        public static void Executar()
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("-- Cadastrar Funcionário --");
            Console.WriteLine("Digite o Nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Digite o RG do funcionário: ");
            f.Rg = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário: ");
            f.Cpf = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do funcionário: ");
            f.DataNasc = Console.ReadLine();
            Console.WriteLine("Digite o Cargo do funcionário: ");
            f.Cargo = Console.ReadLine();
            Console.WriteLine("Digite o Salário do funcionário: ");
            f.Salario = Console.ReadLine();

            if (Validacao.ValidarCpf(f.Cpf))
            {
                if (FuncionarioDAO.Cadastrar(f))
                {
                    Console.WriteLine("Funcionário salvo com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse funcionário já existe");
                }
            }
            else
            {
                Console.WriteLine("\nCPF Inválido. Informe um CPF válido e tente novamente!");
            }
        }
    }
}
