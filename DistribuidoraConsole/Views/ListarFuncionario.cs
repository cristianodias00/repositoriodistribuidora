using DistribuidoraConsole.DAL;
using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Views
{
    class ListarFuncionario
    {
        public static void Executar()
        {
            Console.WriteLine("-- Listar Funcionários --");
            foreach (Funcionario funcionarioCadastrado in FuncionarioDAO.Listar())
            {
                Console.WriteLine(funcionarioCadastrado);
            }
        }
    }
}
