using Microsoft.EntityFrameworkCore;

namespace Bagels.Models
{
    public class BagelsContext : DbContext
    {
        public BagelsContext(DbContextOptions<BagelsContext> options) : base(options)
        {
        }

        public DbSet<Bagel> Bagels { get; set; }
        public DbSet<Topping> Toppings { get; set; }
    }
}