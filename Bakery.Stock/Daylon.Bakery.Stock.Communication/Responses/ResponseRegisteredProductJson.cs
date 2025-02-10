namespace Daylon.Bakery.Stock.Communication.Responses
{
    public class ResponseRegisteredProductJson
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; } = false;
    }
}
