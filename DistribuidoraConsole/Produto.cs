using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole
{
    class Produto
    {
        //Aqui é um construtor (Este é oque está sendo utilizado)
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        //Aqui são os atributos, propriedades
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Volume { get; set; }
        public string Validade { get; set; }

        public DateTime CriadoEm { get; set; }

        //Aqui é realizado o sobreescrever o método
        public override string ToString()
        {
            return $"Tipo: {Tipo} | Nome: {Nome} | Marca: {Marca} | Volume (ml): {Volume} | Data: {Validade} | Criado em: {CriadoEm}";
        }
    }
}
