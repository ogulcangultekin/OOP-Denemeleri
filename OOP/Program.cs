using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "1234567";
            customer1.Name = "Abuzittin";
            customer1.Surname = "Killibacak";
            customer1.TcNo = "11111111111";
            //Şirket
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "7654321";
            customer2.CompanyName = "ToprakAtanOgullari";
            customer2.TaxNo = "654123";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
