using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole
{
    class Funcionario
    {
        //Aqui é um construtor (Este é oque está sendo utilizado)
        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }

        //Aqui são os atributos, propriedades
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string DataNasc { get; set; }
        public string Cargo { get; set; }
        public string Salario { get; set; }
      

        public DateTime CriadoEm { get; set; }

        //Aqui é realizado o sobreescrever o método
        public override string ToString()
        {
            return $"Nome: {Nome} | RG: {Rg} | CPF: {Cpf} | Data Nascimento: {DataNasc} | Cargo: {Cargo} | Salário: {Salario} |Criado em: {CriadoEm}";        }
    }
}
