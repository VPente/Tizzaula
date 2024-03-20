using Microsoft.EntityFrameworkCore;
using TizzaApi.Pizzarias;
using TizzaApi.Pizzas;
using TizzaApi.Promote;

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
        public DbSet<Promover> Promover { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);
            modelBuilder.Entity<Promover>().HasKey(p => p.Id);
            modelBuilder.Entity<Promover>().HasOne(p => p.Pizzaria).WithMany().HasForeignKey(p => p.CodigoPizzaria);


            base.OnModelCreating(modelBuilder);
        }
    }
}
