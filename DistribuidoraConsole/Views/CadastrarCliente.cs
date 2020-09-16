using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using DistribuidoraConsole.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class CadastrarCliente
    {
        public static void Executar()
        {
            Cliente c = new Cliente();
            Console.WriteLine("-- Cadastrar Cliente --");
            Console.WriteLine("Digite o Nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Esse cliente já existe");
                }
            }
            else
            {
                Console.WriteLine("\nCPF Inválido. Informe um CPF válido e tente novamente!");
            }
        }
    }
}
