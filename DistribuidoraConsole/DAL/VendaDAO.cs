using DistribuidoraConsole.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DistribuidoraConsole.DAL
{
    class VendaDAO
    {
        private static List<Venda> vendas = new List<Venda>();

        private static List<Venda> aux = new List<Venda>();
        public static void Cadastrar(Venda v)
        {
            vendas.Add(v);
        }

        //Este é o Método "Listar" que diz respeito a toda lista
        public static List<Venda> Listar()
        {
            return vendas;
        }

        //Aqui é um Método
        //Podemos chamar este método de "Lista Filtrada". Lembrando que este método retorna uma LISTA com todas as informações
        //O metodo irá retornar uma lista de venda por cliente, isto significa que esta sendo realizado um "filtro", onde é utilizado o cpf como parâmetro
        public static List<Venda> ListarPorCliente(string cpf)
        {
            //Este Clear abaixo realiza a limpeza da lista (Irá manter a lista que está já está criada na memória, mas todos os itens anteriores (iteração anterior) serão limpos
            aux.Clear();
            foreach (Venda vendaCadastrada in Listar())
            {
                //É realizada a pesquisa, validando se o cpf informado no parâmetro é "igual" ha algum Cpf de Cliente cadastrado em alguma venda
                if (vendaCadastrada.Cliente.Cpf == cpf)
                {
                    //Caso entre no laço significa que foi encontrado informações.
                    //Estas informações que estão dentro de "vendaCadastrada" serão salvas na Lista Filtrada (aux)
                    aux.Add(vendaCadastrada);
                }
            }
            //Após sair do laço, é retornado a lista que está dentro de "aux"
            return aux;
        }
    }
}
