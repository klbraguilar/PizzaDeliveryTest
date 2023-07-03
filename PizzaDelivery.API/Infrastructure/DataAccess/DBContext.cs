using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using PizzaDelivery.API.Core.Entities;

namespace PizzaDelivery.API.Infrastructure.DataAccess
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Seed();
        }

        public DbSet<Pizza> Pizza { get; set; }
    }
}
