using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketCheckout.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Subtotal { get; set; }

    }
}
