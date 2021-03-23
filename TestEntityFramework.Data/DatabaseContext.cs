using Microsoft.EntityFrameworkCore;
using TestEntityFramework.Data.Entities;

namespace TestEntityFramework.Data
{
    internal class DatabaseContext : DbContext
    {
        // Classes toe voegen

        public DbSet<Samurai> Samurais { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<Horse> Horses { get; set; }

        private const string CONNECTION = @"Server=.\SQLEXPRESS;Database=SamuaraiDB;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION);
        }
    }
}