using System;

namespace _07_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer { CustomerName="Jhone"};

            CorporateCustomer customer2 = new CorporateCustomer { CompanyName="anonim" };

            Customer customer3 = new IndividualCustomer { CustomerNo="123456" };
            Customer customer4 = new CorporateCustomer { CustomerNo = "987654" };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer4);
            customerManager.Delete(customer3);
        }
    }
}
