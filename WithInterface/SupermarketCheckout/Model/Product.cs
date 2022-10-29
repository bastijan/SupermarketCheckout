using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketCheckout.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? DiscountQty { get; set; }
        public decimal? DiscountQtyPrice { get; set; }
    }
}
