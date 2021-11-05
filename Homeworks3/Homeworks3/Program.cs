using System;

namespace Homeworks3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ali Furkan";
            customer1.LastName = "Kurban";

            ICustomerService customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

        }
    }
}
