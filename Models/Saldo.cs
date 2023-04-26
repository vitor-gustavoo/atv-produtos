using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Repository;


namespace Models
{
    public class Saldo
    {
        
        public int Id {get; set;}
        public int ProdutoId {get; set;}
        public int EstoqueId {get; set;}
        public int Quantidade {get; set;}
        public Estoque Estoque {get; set;}
        public Produto Produto {get; set;}
      

        public Saldo(){}

        
        public Saldo(int quantidade, int produtoId, int estoqueId)
        {
            ProdutoId = produtoId;
            EstoqueId = estoqueId;
            Quantidade = quantidade;

            Database db = new Database();
            db.Saldos.Add(this);
            db.SaveChanges();
        }

        public static List<Saldo> BuscarSaldos()
        {
            Database db = new Database();
            return db.Saldos.ToList();
        }

        public static Models.Saldo BuscarSaldoId(int id)
        {
            Database db = new Database();    
            return db.Saldos.Find(id);
        }
        
        public static void EditarSaldo(int id, int quantidade, int produtoId, int estoqueId)
        {
            Database db = new Database();
            Saldo saldo = Models.Saldo.BuscarSaldoId(id);
            saldo.Quantidade = quantidade;
            saldo.ProdutoId = produtoId;
            saldo.EstoqueId = estoqueId;

           db.Saldos.Update(saldo);
           db.SaveChanges();
        }


        public static void ExcluirSaldo(int id)
        {
            Database db = new Database();
            Saldo saldo =  Models.Saldo.BuscarSaldoId(id);
            db.Saldos.Remove(saldo);
            db.SaveChanges();
        }
    }
}