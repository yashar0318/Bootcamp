using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Alma";
            urun1.Qiymet = 15;
            urun1.Aciklama = "Amasya almasi";
            urun1.StokEdedi = 10;   //1:13:01

            Urun urun2 = new Urun();
            urun2.Adi = "Qarpiz";
            urun2.Qiymet = 20;
            urun2.Aciklama = "Sabirabad qarpizi";
            urun2.StokEdedi = 9;

            Urun[] products = new Urun[] { urun1, urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Qiymet);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("------------------------");
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
