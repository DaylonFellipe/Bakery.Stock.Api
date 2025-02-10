namespace Daylon.Bakery.Stock.Domain.Repositories
{
    public interface IUnitOfWork
    {
        public Task CommitAsync();
    }
}
