using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;



namespace Repository
{
    public class Database : DbContext
    {
        
        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Estoque> Estoques {get; set;}
        public DbSet<Saldo> Saldos {get; set;}
        
        
        string connection = "Server=localhost;Uid=root;Database=dbProdutos;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          =>  optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection)); 


    }
}