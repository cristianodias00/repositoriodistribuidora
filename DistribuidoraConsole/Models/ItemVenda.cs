using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Models
{
    class ItemVenda
    {
        //Aqui é um construtor
        public ItemVenda()
        {
            CriadoEm = DateTime.Now;
            Produto = new Produto();


        }

        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        //Aqui é realizado o sobreescrever o método
        //public override string ToString()
        //{
        //    return $"Tipo: {Tipo} | Nome: {Nome} | Marca: {Marca} | Volume (ml): {Volume} | Data: {Validade} | Criado em: {CriadoEm}";
        //}
    }
}
