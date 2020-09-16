using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Models
{
    class Cliente
    {
        //Aqui é um construtor (Este NÃO está sendo utilizado, está só de exemplo)
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        //Aqui é um construtor (Este é oque está sendo utilizado)
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }

        //Aqui são os atributos, propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        //Aqui é realizado o sobreescrever o método
        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
