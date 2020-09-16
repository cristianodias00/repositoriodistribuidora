using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class ClienteDAO
    {
        //Aqui é a declaração da lista
        private static List<Cliente> clientes = new List<Cliente>();

        //Aqui é um método que retorna a lista de clientes (Retorna todos da lista)
        public static List<Cliente> Listar()
        {
            return clientes;
        }

        //Aqui é um método de cadastrar o cliente, onde primeiramente é validado pelo método BuscarCliente se o cpf existe, caso seja null é realizado o cadastro 
        public static bool Cadastrar(Cliente c)
        {
            if(BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;
        } 

        //Aqui é um método que faz a busca somente do cliente
        //Lembrando que sempre que é encontrada uma linha de retorno em um método, ele para a execução do método pois já houve retorno
        public static Cliente BuscarCliente(string cpf)
        {
            foreach (Cliente clienteCadastrado in clientes)
            {
                if (clienteCadastrado.Cpf == cpf)
                {
                    return clienteCadastrado;
                }
            }
            //Significa que foi pesquisado "foreach" na lista, e se não entrou no if significa que o cpf não era igual
            //E se pesquisou "foreach" inteiro e não encontrou ninguém (Ou seja, ao final é retornado NULL)
            return null;
        } 
    }
}
