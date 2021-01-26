using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id+" "+customer.FirstName+" "+customer.LastName+" "+customer.Age+" "+ "müşterisi eklendi");
            Console.WriteLine("--------------------");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Id+" "+customer.FirstName+" "+customer.LastName+" "+customer.Age+" "+ "müşterisi listelendi");
            
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age + "müşterisi silindi ");
            
        }
    }
}
