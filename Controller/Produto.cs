using System;

using Models;

namespace Controller
{

    public class Produto
    {

        public static List<Models.Produto>  BuscarProdutos() {
            return Models.Produto.BuscarProdutos();
        }

        public static void CadastrarProduto(string nome, string preco)
        {
           new Models.Produto(nome, Double.Parse(preco));
        }

        public static Models.Produto BuscarProdutoId(string id) {
            return Models.Produto.BuscarProdutoId(int.Parse(id));
        }

        public static void ExcluirProduto(string id) {
            Models.Produto.ExcluirProduto(int.Parse(id));
        }

        public static void EditarProduto(string id, string nome, string preco) {
            // Models.Produto.EditarProduto(id,nome, Double.Parse(preco));
            Models.Produto produto = Models.Produto.BuscarProdutoId(int.Parse(id));
            produto.Nome = nome;
            produto.Preco = Double.Parse(preco);
        }
    }
    

}