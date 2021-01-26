using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1995;
            customer1.FirstName = "Bayram";
            customer1.LastName = "Göze";
            customer1.Age = 25;

            Customer customer2 = new Customer();
            customer2.Id = 1960;
            customer2.FirstName = "Mehmet";
            customer2.LastName = "Göze";
            customer2.Age = 60;

            Customer[] customers = new Customer[] {customer1,customer2};
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id+" "+customer.FirstName+" "+customer.LastName+" "+customer.Age);
                Console.WriteLine("------------------");
            }
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            CustomerManager customerManager1 = new CustomerManager();
            customerManager.List(customer1);
            customerManager.List(customer2);

            CustomerManager customerManager2 = new CustomerManager();
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
        }
    }
}
