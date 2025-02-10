using Daylon.Bakery.Stock.Domain.Entities;
using Daylon.Bakery.Stock.Domain.Repositories.Product;

namespace Daylon.Bakery.Stock.Infrastructure.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BakeryDbContext _dbContext;

        public ProductRepository(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(ProductBase product) =>
            await _dbContext.Products.AddAsync(product);
    }
}
