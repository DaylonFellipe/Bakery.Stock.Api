namespace Daylon.Bakery.Stock.Communication.Requests
{
    public class RequestRegisterProductJson
    {
        public required string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public required int Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; } = false;
    }
}
