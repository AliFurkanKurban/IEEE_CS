using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks3
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisi Eklendi \n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisi Silindi \n");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " +customer.LastName + " Müşterisi Güncellendi \n");
        }
    }

}
