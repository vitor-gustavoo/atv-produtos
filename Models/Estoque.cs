using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Repository;


namespace Models
{
    public class Estoque
    {
        
        public int Id {get; set;}
        public string Nome {get; set;}


        public Estoque(){}

        
        public Estoque(string nome)
        {
            Nome = nome;

            Database db = new Database();
            db.Estoques.Add(this);
            db.SaveChanges();
        }

        public static List<Estoque> BuscarEstoque()
        {
            Database db = new Database();
            return db.Estoques.ToList();
        }

        public static Models.Estoque BuscarEstoqueId(int id)
        {
            Database db = new Database();
            return db.Estoques.Find(id);

        }
        
        public static void EditarEstoque(int id, string nome)
        {
            Database db = new Database();
            Estoque estoque = Models.Estoque.BuscarEstoqueId(id);
            estoque.Nome = nome;

           db.Estoques.Update(estoque);
           db.SaveChanges();
        }


        public static void ExcluirEstoque(int id)
        {
            Database db = new Database();
            Estoque estoque =  Models.Estoque.BuscarEstoqueId(id);
            db.Estoques.Remove(estoque);
            db.SaveChanges();
        }
    }
}