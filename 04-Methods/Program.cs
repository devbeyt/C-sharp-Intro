using System;

namespace _04_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            CartManager cartManager = new CartManager();

            Product product1 = new Product();
            product1.ProductName = "Phone";
            product1.UnitPrice = 650;
            

            Product product2 = new Product();
            product2.ProductName = "Notebook";
            product2.UnitPrice = 2000;

            Product product3 = new Product();
            product3.ProductName = "Bycicle";
            product3.UnitPrice = 790;
            

            Product[] products = new Product[] { product1,product2,product3 };

            Console.WriteLine("------------------- Add && Delete Methods --------------");

            cartManager.Add(product1);
            cartManager.Add(product2);
            cartManager.Delete(product3);

            Console.WriteLine("------------------- foreach --------------");

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
