using System;

namespace _05_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product { ProductId = 1, CategoryId = 1, ProductName = "Notebook", UnitPrice=2000 };
            Product product2 = new Product { ProductId = 2, CategoryId = 1, ProductName = "Phone", UnitPrice = 1.500};
            Product product3 = new Product { ProductId=3, CategoryId = 3, ProductName = "Bycicle", UnitPrice = 750};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Delete(product3);
            productManager.Update(product2);
 
        }
    }
}
