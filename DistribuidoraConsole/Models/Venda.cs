using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidoraConsole.Models
{
    class Venda
    {
        //Aqui é um construtor

        //Toda vez que é criado um objeto, vai ser adicionado a data e hora do sistema que sera guardado dentro do atributo "CriadoEm"
        public Venda()
        {
            CriadoEm = DateTime.Now;
            //Aqui abaixo está sendo instancioado o objeto para que o construtor libere os atributos de cada objeto
            //Somente no caso de "RELACIONAMENTOS". Sem está instancia, quando tentar salvar alguma coisa na classe relacionada, irá estourar a excessão Null
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            Itens = new List<ItemVenda>();

        }

        //Aqui são os atributos, propriedades
        //Neste caso o atributo foi definido como o proprio cliente pois está tendo um "RELACIONAMENTO" entre as classes
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        //Aqui abaixo é uma lista de itens de venda
        public List<ItemVenda> Itens { get; set; }
        public DateTime CriadoEm { get; set; }

        //Aqui é realizado o sobreescrever o método
        //public override string ToString()
        //{
        //    return $"Tipo: {Tipo} | Nome: {Nome} | Marca: {Marca} | Volume (ml): {Volume} | Data: {Validade} | Criado em: {CriadoEm}";
        //}
    }
}
