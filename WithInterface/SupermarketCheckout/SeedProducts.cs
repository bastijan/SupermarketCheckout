using System;
using System.Collections.Generic;
using SupermarketCheckout.Model;

namespace SupermarketCheckout
{
    /// <summary>
    /// Seed product data 
    /// </summary>
    public class SeedProducts
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Apple", Price = 30, DiscountQty = 2, DiscountQtyPrice = 45 },
                new Product { Id = 2, Name = "Banana", Price = 50, DiscountQty = 3, DiscountQtyPrice = 130 },
                new Product { Id = 3, Name = "Peach", Price = 60, DiscountQty = null, DiscountQtyPrice = null },
            };
        }
    }
}
