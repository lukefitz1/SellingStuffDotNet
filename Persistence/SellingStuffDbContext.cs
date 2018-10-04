using Microsoft.EntityFrameworkCore;
using SellingStuffDotNet.Models;

namespace SellingStuffDotNet.Persistence
{
    public class SellingStuffDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public SellingStuffDbContext(DbContextOptions<SellingStuffDbContext> options)
            : base(options)
        {
            
        }
        
    }
}