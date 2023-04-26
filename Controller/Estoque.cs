using System;

using Models;

namespace Controller
{

    public class Estoque
    {

        public static List<Models.Estoque>  BuscarEstoque() {
            return Models.Estoque.BuscarEstoque();
        }

        public static void CadastrarEstoque(string nome)
        {
           new Models.Estoque(nome);
        }

        public static Models.Estoque BuscarEstoqueId(string id) {
            return Models.Estoque.BuscarEstoqueId(int.Parse(id));
        }

        public static void ExcluirEstoque(string id) {
            Models.Estoque.ExcluirEstoque(int.Parse(id));
        }

        public static void EditarEstoque(string id, string nome) {
            // Models.Produto.EditarProduto(id,nome, Double.Parse(preco));
            Models.Estoque estoque = Models.Estoque.BuscarEstoqueId(int.Parse(id));
            estoque.Nome = nome;
        }
    }
    

}