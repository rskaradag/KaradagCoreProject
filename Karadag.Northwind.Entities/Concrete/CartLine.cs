using System;
using System.Text;

namespace Karadag.Northwind.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
