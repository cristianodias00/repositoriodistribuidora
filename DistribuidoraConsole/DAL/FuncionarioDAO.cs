using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class FuncionarioDAO
    {
        //Aqui é a declaração da lista
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        //Aqui é um método que retorna a lista de clientes (Retorna todos da lista)
        public static List<Funcionario> Listar()
        {
            return funcionarios;
        }

        //Aqui é um método de cadastrar o cliente, onde primeiramente é validado pelo método BuscarCliente se o cpf existe, caso seja null é realizado o cadastro 
        public static bool Cadastrar(Funcionario f)
        {
            if (BuscarFuncionario(f.Cpf) == null)
            {
                funcionarios.Add(f);
                return true;
            }
            return false;
        }

        //Aqui é um método que faz a busca somente do cliente
        //Lembrando que sempre que é encontrada uma linha de retorno em um método, ele para a execução do método pois já houve retorno
        public static Funcionario BuscarFuncionario(string cpf)
        {
            foreach (Funcionario funcionarioCadastrado in funcionarios)
            {
                if (funcionarioCadastrado.Cpf == cpf)
                {
                    return funcionarioCadastrado;
                }
            }
            //Significa que foi pesquisado "foreach" na lista, e se não entrou no if significa que o cpf não era igual
            //E se pesquisou "foreach" inteiro e não encontrou ninguém (Ou seja, ao final é retornado NULL)
            return null;
        }

    }
}
