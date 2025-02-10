using Daylon.Bakery.Stock.Domain.Repositories;

namespace Daylon.Bakery.Stock.Infrastructure.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BakeryDbContext _dbContext;

        public UnitOfWork(BakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();
    }
}
