﻿using System.Collections.Generic;
using System.Linq;

namespace Karadag.Northwind.Entities.Concrete
{
    public class Cart {

        public List<CartLine> CartLines { get; set; }
        public decimal Total {
            get { return CartLines.Sum(c=>c.Product.UnitPrice*c.Quantity); }
        }

        public Cart()
        {
            CartLines = new List<CartLine>();
        }
    }
}
