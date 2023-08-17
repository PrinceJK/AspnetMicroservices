namespace Basket.API.Entities
{
    public abstract class ShoppingCartItem
    {
        public int Quality { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public decimal ProductId { get; set; }
        public decimal ProductName { get; set; }
    }
}