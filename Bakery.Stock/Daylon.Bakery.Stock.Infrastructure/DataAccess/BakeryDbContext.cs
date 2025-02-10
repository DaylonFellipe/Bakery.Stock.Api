using Daylon.Bakery.Stock.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Daylon.Bakery.Stock.Infrastructure.DataAccess
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext(DbContextOptions<BakeryDbContext> options) : base(options)
        {
        }

        public DbSet<ProductBase> Products { get; set; }

    }
}
