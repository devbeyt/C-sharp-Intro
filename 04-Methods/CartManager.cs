using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Methods
{
    class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName} Added to Cart");
        }

        public void Delete(Product product)
        {
            Console.WriteLine($" Deleted {product.ProductName} ");
        }
    }
}
