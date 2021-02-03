using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yashar Isgenderov
            İnvidualCustomer customer1 = new İnvidualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Yashar";
            customer1.Surname = "Isgenderov";
            customer1.TcNo = "12345678910";

            // Kodlama.io
            CoorparateCustomer customer2 = new CoorparateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "1234567890";

            Customer customer3 = new İnvidualCustomer();
            Customer customer4 = new CoorparateCustomer();
            // customer hem invidualin hem de coorparate customerin referansini saxlaya biler

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
