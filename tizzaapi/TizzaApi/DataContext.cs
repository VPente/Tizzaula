using Microsoft.EntityFrameworkCore;
using TizzaApi.Pizzarias;
using TizzaApi.Pizzas;

namespace TizzaApi
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext>options): base(options)
        {
            
        }

        public DbSet<Pizzaria> pizzarias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
