using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Repository;


namespace Models
{
    public class Produto
    {
        
        public int Id {get; set;}
        public string Nome {get; set;}
        public double Preco {get; set;}

        public Produto(){}

        
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

            Database db = new Database();
            db.Produtos.Add(this);
            db.SaveChanges();
        }

        public static List<Produto> BuscarProdutos()
        {
            Database db = new Database();
            return db.Produtos.ToList();
        }

        public static Models.Produto BuscarProdutoId(int id)
        {
            Database db = new Database();

            db.Produtos.Find(id);

            Models.Produto produto = (
                from p in db.Produtos
                where p.Id == id 
                select p
            ).First();

            return produto;

        }
        
        public static void EditarProduto(int id, string nome, double preco)
        {
            Database db = new Database();
            Produto produto = Models.Produto.BuscarProdutoId(id);
            produto.Nome = nome;
            produto.Preco = preco;

           db.Produtos.Update(produto);
           db.SaveChanges();
        }


        public static void ExcluirProduto(int id)
        {
            Database db = new Database();
            Produto produto =  Models.Produto.BuscarProdutoId(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
        }
    }
}