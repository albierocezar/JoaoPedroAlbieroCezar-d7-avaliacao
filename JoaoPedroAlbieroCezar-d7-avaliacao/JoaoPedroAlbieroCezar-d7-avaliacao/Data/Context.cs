using Microsoft.EntityFrameworkCore;
using System;
using System.IO.Packaging;
using System.Linq;

namespace JoaoPedroAlbieroCezar_d7_avaliacao.Data
{
    class Context : DbContext
    {
        public DbSet<User> users { get; set; } //pega todas as entidades do db
        public string dbPath;

        public Context() : base()
        {
            dbPath = "C:\\Users\\Usuario\\Desktop\\JoaoPedroAlbieroCezar-d7-avaliacao\\JoaoPedroAlbieroCezar-d7-avaliacao\\JoaoPedroAlbieroCezar-d7-avaliacao\\bin\\Debug\\net6.0-windows\\users.db";
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={dbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            base.OnModelCreating(modelBuilder);
        }

    
    }
}
