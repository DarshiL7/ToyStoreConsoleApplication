using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToyStoreApplication.Context;
using ToyStoreApplication.Models;

namespace ToyStoreApplication.Domains
{
    class CustomerDomain : BaseContext
    {
        Customer customer = new Customer();
        public void AddCustomer()
        {
            repeate:
            Console.WriteLine("--->> ADD Customer <<---");
            Console.WriteLine("Enter Customer Name: ");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Address: ");
            customer.CustomerPermanentAddress= Console.ReadLine();
            if (customer.CustomerName!= null && customer.CustomerPermanentAddress!= null)
            {
                try
                {
                    Customers.Add(customer);
                    Console.WriteLine("Customer Added");
                    SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine(" !!Enter all required fields!! ");
                goto repeate;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return Customers.ToList();
        }

        public void DeleteCustomer(Customer customer20)
        {
            Customers.Remove(customer20);
            SaveChanges();
            Console.WriteLine("Customer " + customer20.CustomerId + " Deleted");
        }

       
    }
}

