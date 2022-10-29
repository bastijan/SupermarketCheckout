namespace SupermarketCheckout.Model
{
    /// <summary>
    /// Product model
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? DiscountQty { get; set; }
        public decimal? DiscountQtyPrice { get; set; }
    }
}
