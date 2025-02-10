using Daylon.Bakery.Stock.Domain.Entities.Enum;

namespace Daylon.Bakery.Stock.Domain.Entities
{
    public class ProductBase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public CategoryEnum Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
    }
}
