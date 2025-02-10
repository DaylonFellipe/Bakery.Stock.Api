namespace Daylon.Bakery.Stock.Domain.Repositories.Product
{
    public interface IProductRepository
    {
        Task AddAsync(Entities.ProductBase product);
    }
}
