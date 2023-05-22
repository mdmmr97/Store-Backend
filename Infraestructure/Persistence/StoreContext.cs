using Microsoft.EntityFrameworkCore;
using Store_Backend.Domain.Entities;

namespace Store_Backend.Infraestructure.Persistence
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
