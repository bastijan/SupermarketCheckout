namespace SupermarketCheckout.Model
{
    /// <summary>
    /// Product model
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? DiscountQty { get; set; }
        public int? DiscountQtyPrice { get; set; }
    }
}
