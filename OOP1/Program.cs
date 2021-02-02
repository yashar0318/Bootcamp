using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product() { ID = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            // void ile yazanda konkret cem tapilir,daha sonra o cem ustunde emeliyyat aparmaq mumkun olmur
           // productManager.Topla2(3, 6);
            // voidsiz yazanda ise return vasitesile hemin cem ustunde emeliyyat aparmaq mumkun olur
            //int toplamanetice = productManager.Topla(3, 6);
            //Console.WriteLine(toplamanetice * 2);

           // int eded = 100;
            //productManager.BirSeyYap(eded);
            //Console.WriteLine(eded);
          
            // int,double,bool .......... deger tip
            // class,arrays,abstract class,interface........referans tip
        }
    }
}
