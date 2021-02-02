using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = (product.ProductName + "eklendi");
        }

        public void Update(Product product)
        {
            product.ProductName = (product.ProductName + "guncellendi");
        }

        public int Topla(int s1,int s2)
        {
            return s1 + s2;
        }

        public void Topla2(int s1, int s2)
        {
            Console.WriteLine(s1 + s2);
        }


       // public void BirSeyYap(int eded)
        //{
          // eded = 99;
        //}
    }
}
