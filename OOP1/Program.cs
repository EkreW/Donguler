using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prodcut1 = new Product();
            prodcut1.Id = 1;
            prodcut1.CategoryId = 2;
            prodcut1.ProductName = "Masa";
            prodcut1.UnitPrice = 500;
            prodcut1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, 
                ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(prodcut1);
            Console.WriteLine(prodcut1.ProductName);

        }
    }
}
