using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Univesidade POSITIVO",
                Cpf = "05721782986"                
            };
            Produto produto = new Produto
            {
                Tipo = "Bebida",
                Nome = "Cerveja",
                Marca = "Brahma",
                Volume = "350",
                Validade = "31/12/2020",
                Preco = 2.29,
                Quatidade = 10
            };
            Funcionario funcionario = new Funcionario
            {
                Nome = "Cristiano Dias",
                Rg = "96923384",
                Cpf = "05721782986",
                DataNasc = "17/06/1987",
                Cargo = "Analista de T.I",
                Salario = "5.000,00"
            };
            ClienteDAO.Cadastrar(cliente);
            ProdutoDAO.Cadastrar(produto);
            FuncionarioDAO.Cadastrar(funcionario);
        }
    }
}
