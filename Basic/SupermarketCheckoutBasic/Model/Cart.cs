namespace SupermarketCheckout.Model
{
    /// <summary>
    /// Cart model, using as shopping cart
    /// </summary>
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Subtotal { get; set; }

    }
}
