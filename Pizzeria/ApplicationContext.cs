using Microsoft.EntityFrameworkCore;
using Pizzeria.models;

namespace Pizzeria
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Pizza>().Property(x => x.Ingredients).IsRequired();
            modelBuilder.Entity<Pizza>().Property(x => x.Picture).IsRequired();
        }
    }
}
